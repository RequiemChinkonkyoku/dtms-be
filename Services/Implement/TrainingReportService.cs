using AutoMapper;
using Microsoft.IdentityModel.Tokens;
using Models.Constants;
using Models.DTOs;
using Models.DTOs.Certification;
using Models.DTOs.TrainerReport;
using Models.DTOs.TrainingReport;
using Models.Entities;
using Repositories.Interface;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Services.Implement
{
    public class TrainingReportService : ITrainingReportService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public TrainingReportService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<BaseResponseDTO<TrainingReportResponse>> GetAllTrainingReports()
        {
            var result = await _unitOfWork.TrainingReports.GetAll();
            var response = _mapper.Map<List<TrainingReportResponse>>(result);
            return new BaseResponseDTO<TrainingReportResponse> { Success = true, ObjectList = response };
        }

        public async Task<BaseResponseDTO<TrainingReportResponse>> GetTrainingReportById(string id)
        {
            var result = await _unitOfWork.TrainingReports.GetById(id);

            if (result == null)
            {
                return new BaseResponseDTO<TrainingReportResponse> { Success = false, Message = "Unable to find training report with id " + id };
            }

            var response = _mapper.Map<TrainingReportResponse>(result);
            return new BaseResponseDTO<TrainingReportResponse> { Success = true, Object = response };
        }

        public async Task<BaseResponseDTO<TrainingReportResponse>> GetTrainingReportsByDogId(string dogId)
        {
            var enrollments = (await _unitOfWork.Enrollments.GetAll())
                                            .Where(e => e.DogId == dogId)
                                            .Select(e => e.Id)
                                            .ToList();

            if (enrollments.IsNullOrEmpty())
            {
                return new BaseResponseDTO<TrainingReportResponse>
                {
                    Success = false,
                    Message = "Unable to find enrollment with dogId " + dogId
                };
            }

            //var result = await _unitOfWork.TrainingReports.Get(d => d.DogId == dogId);

            var result = new List<TrainingReport>();

            foreach (var enrollment in enrollments)
            {
                var report = (await _unitOfWork.TrainingReports.GetAll())
                                        .Where(tr => tr.EnrollmentId == enrollment)
                                        .ToList();

                if (report.IsNullOrEmpty())
                {
                    return new BaseResponseDTO<TrainingReportResponse>
                    {
                        Success = false,
                        Message = "Unable to find training report with enrollmentId " + enrollment
                    };
                }

                result.AddRange(report);
            }

            if (result.IsNullOrEmpty())
            {
                return new BaseResponseDTO<TrainingReportResponse> { Success = false, Message = "Unable to find training report with dogId " + dogId };
            }

            var response = _mapper.Map<List<TrainingReportResponse>>(result);
            return new BaseResponseDTO<TrainingReportResponse> { Success = true, ObjectList = response };
        }

        public async Task<BaseResponseDTO<TrainingReportResponse>> CreateTrainingReportAsync(CreateTrainingReportRequest createTrainingReportRequest)
        {
            if (string.IsNullOrWhiteSpace(createTrainingReportRequest.EnrollmentId) ||
            string.IsNullOrWhiteSpace(createTrainingReportRequest.TrainerProfileId))
            {
                throw new ArgumentException("DogId and TrainerProfileId are required.");
            }

            var enrollment = await _unitOfWork.Enrollments.GetById(createTrainingReportRequest.EnrollmentId);
            var trainerProfile = await _unitOfWork.Accounts.GetById(createTrainingReportRequest.TrainerProfileId);

            if (enrollment == null)
            {
                throw new KeyNotFoundException("EnrollmentId is not valid.");
            }

            if (trainerProfile == null)
            {
                throw new KeyNotFoundException("TrainerProfileId is not valid.");
            }

            var trainerRole = await _unitOfWork.Roles.GetById(trainerProfile.RoleId);
            if (trainerRole == null)
            {
                throw new KeyNotFoundException("TrainerProfileId is not valid.");
            }
            if (trainerRole.Name != "Trainer_Member" && trainerRole.Name != "Trainer_Lead")
            {
                throw new ArgumentException("TrainerProfileId is not a trainer.");
            }

            var report = _mapper.Map<TrainingReport>(createTrainingReportRequest);

            report.TrainerId = createTrainingReportRequest.TrainerProfileId;

            try
            {
                await _unitOfWork.TrainingReports.Add(report);
                await _unitOfWork.SaveChanges();
            }
            catch (Exception ex)
            {
                return new BaseResponseDTO<TrainingReportResponse>
                {
                    Success = false,
                    Message = $"There has been an error adding the trainingReport. Ex: {ex.Message}."
                };
            }

            enrollment.Status = (int)EnrollmentStatusEnum.Concluded;

            try
            {
                await _unitOfWork.Enrollments.Update(enrollment);
                await _unitOfWork.SaveChanges();
            }
            catch (Exception ex)
            {
                return new BaseResponseDTO<TrainingReportResponse>
                {
                    Success = false,
                    Message = $"There has been an error updating the enrollment. Ex: {ex.Message}."
                };
            }

            var cage = await _unitOfWork.Cages.GetById(enrollment.CageId);
            cage.Status = (int)CageStatusEnum.Available;

            try
            {
                await _unitOfWork.Cages.Update(cage);
                await _unitOfWork.SaveChanges();
            }
            catch (Exception ex)
            {
                return new BaseResponseDTO<TrainingReportResponse>
                {
                    Success = false,
                    Message = $"There has been an error updating the cage. Ex: {ex.Message}."
                };
            }

            if (report.IsPassed)
            {
                try
                {
                    var existingClass = await _unitOfWork.Classes.GetById(enrollment.ClassId);
                    var course = await _unitOfWork.Courses.GetById(existingClass.CourseId);
                    var cert = (await _unitOfWork.Certificates.GetAll())
                                            .Where(c => c.CourseId == course.Id)
                                            .FirstOrDefault();

                    var dogCert = new DogCertificate
                    {
                        DogId = enrollment.DogId,
                        CertificateId = cert.Id
                    };

                    await _unitOfWork.DogCertificates.Add(dogCert);
                    await _unitOfWork.SaveChanges();
                }
                catch (Exception ex)
                {
                    return new BaseResponseDTO<TrainingReportResponse>
                    {
                        Success = false,
                        Message = $"There has been an error creating dogCertificate. Ex: {ex.Message}."
                    };
                }
            }

            var response = _mapper.Map<TrainingReportResponse>(report);
            return new BaseResponseDTO<TrainingReportResponse> { Success = true, Object = response };
        }

        public async Task<BaseResponseDTO<TrainingReportResponse>> UpdateTrainingReportAsync(string id, CreateTrainingReportRequest request)
        {
            var existingReport = await _unitOfWork.TrainingReports.GetById(id);

            if (existingReport == null)
            {
                throw new KeyNotFoundException($"Training Report not found.");
            }

            if (string.IsNullOrWhiteSpace(request.EnrollmentId) ||
            string.IsNullOrWhiteSpace(request.TrainerProfileId))
            {
                throw new ArgumentException("EnrollmentId and TrainerProfileId are required.");
            }

            var enrollmentId = await _unitOfWork.Enrollments.GetEnrolmentById(request.EnrollmentId);
            var trainerProfileId = await _unitOfWork.Accounts.GetById(request.TrainerProfileId);

            if (enrollmentId == null)
            {
                throw new KeyNotFoundException("EnrollmentId is not valid.");
            }

            if (trainerProfileId == null)
            {
                throw new KeyNotFoundException("TrainerProfileId is not valid.");
            }

            var trainerRole = await _unitOfWork.Roles.GetById(trainerProfileId.RoleId);
            if (trainerRole == null)
            {
                throw new KeyNotFoundException("TrainerProfileId is not valid.");
            }
            if (trainerRole.Name != "Trainer_Member" && trainerRole.Name != "Trainer_Lead")
            {
                throw new ArgumentException("TrainerProfileId is not a trainer.");
            }

            var createdDate = DateOnly.FromDateTime(existingReport.CreatedTime.UtcDateTime);
            var currentDate = DateOnly.FromDateTime(DateTime.UtcNow);

            if (currentDate != createdDate)
            {
                return new BaseResponseDTO<TrainingReportResponse>
                {
                    Success = false,
                    Message = "Updates can only be made within the same day."
                };
            }

            if (existingReport.IsPassed != request.IsPassed)
            {
                if (request.IsPassed)
                {
                    var dogId = enrollmentId.DogId;
                    var certificate = (await _unitOfWork.Certificates.GetCertificateByCourseId(enrollmentId.Class.CourseId));

                    if (certificate == null || dogId == null)
                    {
                        return new BaseResponseDTO<TrainingReportResponse>
                        {
                            Success = false,
                            Message = "Unable to find cert or dog."
                        };
                    }

                    var dogCert = new DogCertificate
                    {
                        DogId = dogId,
                        CertificateId = certificate.Id
                    };

                    try
                    {
                        await _unitOfWork.DogCertificates.Add(dogCert);
                        await _unitOfWork.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        return new BaseResponseDTO<TrainingReportResponse>
                        {
                            Success = false,
                            Message = $"There has been an error creating dogCertificate. Ex: {ex.Message}."
                        };
                    }
                }
                else
                {
                    var dogId = enrollmentId.DogId;
                    var certificate = (await _unitOfWork.Certificates.GetCertificateByCourseId(enrollmentId.Class.CourseId));

                    if (certificate == null || dogId == null)
                    {
                        return new BaseResponseDTO<TrainingReportResponse>
                        {
                            Success = false,
                            Message = "Unable to find cert or dog."
                        };
                    }

                    var existingDogCert = await _unitOfWork.DogCertificates.GetDogCertificateByDogAndCert(dogId, certificate.Id);

                    if (existingDogCert == null)
                    {
                        return new BaseResponseDTO<TrainingReportResponse>
                        {
                            Success = false,
                            Message = "Unable to find dogCertificate."
                        };
                    }

                    try
                    {
                        await _unitOfWork.DogCertificates.Delete(existingDogCert);
                        await _unitOfWork.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        return new BaseResponseDTO<TrainingReportResponse>
                        {
                            Success = false,
                            Message = $"There has been an error deleting dogCert. Ex: {ex.Message}."
                        };
                    }
                }
            }

            _mapper.Map(request, existingReport);

            existingReport.LastUpdatedTime = DateTime.UtcNow;

            _unitOfWork.TrainingReports.Update(existingReport);
            await _unitOfWork.SaveChanges();

            var response = _mapper.Map<TrainingReportResponse>(existingReport);
            return new BaseResponseDTO<TrainingReportResponse> { Success = true, Object = response };
        }

        public async Task<bool> DeleteTrainingReportAsync(string id)
        {
            var existingReport = await _unitOfWork.TrainingReports.GetById(id);

            if (existingReport == null)
            {
                throw new KeyNotFoundException($"Training Report not found.");
            }

            _unitOfWork.TrainingReports.Delete(existingReport);
            await _unitOfWork.SaveChanges();

            return true;
        }
    }
}
