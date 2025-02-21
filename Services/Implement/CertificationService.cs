using AutoMapper;
using Models.DTOs.Certification;
using Models.DTOs.TrainerReport;
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
    public class CertificationService : ICertificationService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CertificationService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<List<CertificationResponse>> GetAllCertifications()
        {
            var result = await _unitOfWork.Certifications.GetAll();
            return _mapper.Map<List<CertificationResponse>>(result);
        }

        public async Task<CertificationResponse> GetCertificationsById(string id)
        {
            var result = await _unitOfWork.Certifications.GetById(id);
            return _mapper.Map<CertificationResponse>(result);
        }

        public async Task<List<CertificationResponse>> GetCertificationsByName(string name)
        {
            var result = await _unitOfWork.Certifications.Get(c => c.Name.Contains(name));
            return _mapper.Map<List<CertificationResponse>>(result);
        }

        public async Task<CertificationResponse> CreateCertificationsAsync(CreateCertificationRequest createCertificationRequest)
        {
            if (string.IsNullOrWhiteSpace(createCertificationRequest.TrainerProfileId))
            {
                throw new ArgumentException("TrainerProfileId is required.");
            }

            var trainerProfileId = await _unitOfWork.TrainerProfiles.GetById(createCertificationRequest.TrainerProfileId);
            if (trainerProfileId == null)
            {
                throw new KeyNotFoundException("TrainerProfileId is not valid.");
            }

            var certification = _mapper.Map<Certifications>(createCertificationRequest);

            certification.Status = 1;
            certification.UploadTime = DateTime.UtcNow;

            await _unitOfWork.Certifications.Add(certification);
            await _unitOfWork.SaveChanges();

            return _mapper.Map<CertificationResponse>(certification);
        }

        public async Task<CertificationResponse> UpdateCertificationsAsync(string id, CreateCertificationRequest request)
        {
            var existingCertification = await _unitOfWork.Certifications.GetById(id);

            if (existingCertification == null)
            {
                throw new KeyNotFoundException($"Certification not found.");
            }

            if (string.IsNullOrWhiteSpace(request.TrainerProfileId))
            {
                throw new ArgumentException("TrainerProfileId is required.");
            }

            var trainerProfileId = await _unitOfWork.TrainerProfiles.GetById(request.TrainerProfileId);
            if (trainerProfileId == null)
            {
                throw new KeyNotFoundException("TrainerProfileId is not valid.");
            }

            _mapper.Map(request, existingCertification);

            existingCertification.LastUpdatedTime = DateTime.UtcNow;

            _unitOfWork.Certifications.Update(existingCertification);
            await _unitOfWork.SaveChanges();

            return _mapper.Map<CertificationResponse>(existingCertification);
        }

        public async Task<bool> DeleteCertificationsAsync(string id)
        {
            var existingCertification = await _unitOfWork.Certifications.GetById(id);

            if (existingCertification == null)
            {
                throw new KeyNotFoundException($"Certification not found.");
            }

            _unitOfWork.Certifications.Delete(existingCertification);
            await _unitOfWork.SaveChanges();

            return true;
        }
    }
}
