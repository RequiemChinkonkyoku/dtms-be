using AutoMapper;
using Models.Constants;
using Models.DTOs;
using Models.DTOs.Enrollment.Response;
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
    public class EnrollmentService : IEnrollmentService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public EnrollmentService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<BaseResponseDTO<GetEnrollmentResponse>> GetAllEnrollments()
        {
            var response = await _unitOfWork.Enrollments.GetAllEnrollments();

            var mappedResponse = _mapper.Map<List<GetEnrollmentResponse>>(response);

            return new BaseResponseDTO<GetEnrollmentResponse> { Success = true, ObjectList = mappedResponse };
        }

        public async Task<BaseResponseDTO<GetEnrollmentResponse>> GetAllEnrollmentById(string id)
        {
            var enrollment = await _unitOfWork.Enrollments.GetEnrolmentById(id);

            if (enrollment == null)
            {
                return new BaseResponseDTO<GetEnrollmentResponse>
                {
                    Success = false,
                    Message = $"Unable to find enrollment with id {id}."
                };
            }

            var mappedResponse = _mapper.Map<GetEnrollmentResponse>(enrollment);

            return new BaseResponseDTO<GetEnrollmentResponse> { Success = true, Object = mappedResponse };
        }

        public async Task<BaseResponseDTO<GetEnrollmentResponse>> CancelEnrollment(string id)
        {
            var enrollment = await _unitOfWork.Enrollments.GetEnrolmentById(id);

            if (enrollment == null)
            {
                return new BaseResponseDTO<GetEnrollmentResponse>
                {
                    Success = false,
                    Message = $"Unable to find enrollment with id {id}."
                };
            }

            if (enrollment.Status != (int)EnrollmentStatusEnum.Pending)
            {
                return new BaseResponseDTO<GetEnrollmentResponse>
                {
                    Success = false,
                    Message = $"Only pending enrollments can be cancelled."
                };
            }

            var existingClass = await _unitOfWork.Classes.GetById(enrollment.ClassId);

            if (existingClass == null)
            {
                return new BaseResponseDTO<GetEnrollmentResponse>
                {
                    Success = false,
                    Message = $"Unable to find class with id {id}."
                };
            }

            existingClass.EnrolledDogCount -= 1;
            enrollment.Status = (int)EnrollmentStatusEnum.Inactive;

            try
            {
                await _unitOfWork.Enrollments.Update(enrollment);
                await _unitOfWork.SaveChanges();

                await _unitOfWork.Classes.Update(existingClass);
                await _unitOfWork.SaveChanges();
            }
            catch (Exception ex)
            {
                return new BaseResponseDTO<GetEnrollmentResponse>
                {
                    Success = false,
                    Message = $"There has been an error. Ex: {ex.Message}.",
                };
            }

            var mappedResponse = _mapper.Map<GetEnrollmentResponse>(enrollment);

            return new BaseResponseDTO<GetEnrollmentResponse> { Success = true, Object = mappedResponse };
        }
    }
}
