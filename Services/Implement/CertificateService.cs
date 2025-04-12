using AutoMapper;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Models.DTOs;
using Models.DTOs.Certificate.Request;
using Models.DTOs.Certificate.Response;
using Models.DTOs.DogCertificate.Response;
using Models.Entities;
using Repositories.Interface;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Implement
{
    public class CertificateService : ICertificateService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CertificateService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<BaseResponseDTO<Certificate>> GetAllCertificates()
        {
            var response = await _unitOfWork.Certificates.GetAll();

            return new BaseResponseDTO<Certificate> { Success = true, ObjectList = response };
        }

        public async Task<CertificateResponse> GetCertificateById(string id)
        {
            var dogCertificate = await _unitOfWork.Certificates.GetByIdWithDetailsAsync(id);

            if (dogCertificate == null)
            {
                throw new KeyNotFoundException($"Certificate with ID {id} not found.");
            }

            return _mapper.Map<CertificateResponse>(dogCertificate);
        }

        public async Task<string> CreateCertificateAsync(CreateCertificateRequest request)
        {
            Course? linkedCourse = null;
            if (!string.IsNullOrEmpty(request.CourseId))
            {
                linkedCourse = await _unitOfWork.Courses.GetById(request.CourseId);
                if (linkedCourse == null)
                    throw new KeyNotFoundException($"Course with ID {request.CourseId} not found");

                bool courseHasCertificate = await _unitOfWork.Certificates.CourseHasCertificate(request.CourseId);

                if (courseHasCertificate)
                    throw new InvalidOperationException($"Course '{linkedCourse.Name}' already has a certificate");
            }

            // Create new certificate
            var newCertificate = new Certificate
            {
                Id = Guid.NewGuid().ToString(),
                Name = request.Name,
                Description = request.Description,
                Status = 1,
                CourseId = request.CourseId,
                CreatedTime = DateTime.UtcNow,
                LastUpdatedTime = DateTime.UtcNow
            };

            await _unitOfWork.Certificates.Add(newCertificate);
            await _unitOfWork.SaveChanges();

            return linkedCourse != null
                ? $"Successfully created certificate '{request.Name}' for course '{linkedCourse.Name}'"
                : $"Successfully created certificate '{request.Name}'";
        }

        public async Task<string> UpdateCertificateAsync(string certificateId, UpdateCertificateRequest request)
        {
            if (!request.IsValid())
                throw new ArgumentException("At least one update field must be provided");

            var certificate = await _unitOfWork.Certificates.GetByIdWithDetailsAsync(certificateId);
            if (certificate == null)
                throw new KeyNotFoundException($"Certificate with ID {certificateId} not found");

            var changes = new List<string>();
            var originalName = certificate.Name;

            if (request.Name != null && request.Name != certificate.Name)
            {
                changes.Add($"name from '{certificate.Name}' to '{request.Name}'");
                certificate.Name = request.Name;
            }

            if (request.Description != null && request.Description != certificate.Description)
            {
                changes.Add("description");
                certificate.Description = request.Description;
            }

            if (request.Status.HasValue && request.Status != certificate.Status)
            {
                changes.Add($"status from {certificate.Status} to {request.Status}");
                certificate.Status = request.Status.Value;
            }

            if (request.CourseId != certificate.CourseId)
            {
                Course? newCourse = null;

                if (request.CourseId != null)
                {
                    newCourse = await _unitOfWork.Courses.GetById(request.CourseId);
                    if (newCourse == null)
                        throw new KeyNotFoundException($"Course with ID {request.CourseId} not found");

                    // Changed to use new repository method
                    var existingCertForCourse = await _unitOfWork.Certificates
                        .GetCertificateByCourseId(request.CourseId);

                    if (existingCertForCourse != null && existingCertForCourse.Id != certificateId)
                        throw new InvalidOperationException($"Course '{newCourse.Name}' already has a certificate");
                }


                var oldCourseName = certificate.Course?.Name ?? "No Course";
                var newCourseName = newCourse?.Name ?? "No Course";

                changes.Add($"course association from '{oldCourseName}' to '{newCourseName}'");
                certificate.CourseId = request.CourseId;
            }

            if (changes.Count > 0)
            {
                certificate.LastUpdatedTime = DateTime.UtcNow;
                _unitOfWork.Certificates.Update(certificate);
                await _unitOfWork.SaveChanges();

                return $"Successfully updated certificate ";
            }

            return "No changes were made to the certificate";
        }

    }
}
