using Microsoft.IdentityModel.Tokens;
using Models.DTOs;
using Models.Entities;
using Repositories.Interface;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Services.Implement
{
    public class PrerequisiteService : IPrerequisiteService
    {
        private readonly IUnitOfWork _unitOfWork;

        public PrerequisiteService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<BaseResponseDTO<Prerequisite>> GetAllPrerequisites()
        {
            var response = await _unitOfWork.Prerequisites.GetAll();

            return new BaseResponseDTO<Prerequisite> { Success = true, ObjectList = response };
        }

        public async Task<BaseResponseDTO<Prerequisite>> CreatePrerequisite(CreatePrerequisiteRequest request)
        {
            if (request.CourseId.IsNullOrEmpty() ||
                request.PrerequisiteCourseId.IsNullOrEmpty())
            {
                return new BaseResponseDTO<Prerequisite> { Success = false, Message = "Id must be given." };
            }

            var course = await _unitOfWork.Courses.GetById(request.CourseId);

            if (course == null)
            {
                return new BaseResponseDTO<Prerequisite>
                {
                    Success = false,
                    Message = "Unable to find course with id " + request.CourseId
                };
            }

            var prerequisiteCourse = await _unitOfWork.Courses.GetById(request.PrerequisiteCourseId);

            if (prerequisiteCourse == null)
            {
                return new BaseResponseDTO<Prerequisite>
                {
                    Success = false,
                    Message = "Unable to find prerequisiteCourse with id " + request.PrerequisiteCourseId
                };
            }

            var prerequisite = new Prerequisite()
            {
                CourseId = request.CourseId,
                PrerequisiteCourseId = request.PrerequisiteCourseId,
                CreatedTime = DateTime.UtcNow,
                LastUpdatedTime = DateTime.UtcNow,
            };

            await _unitOfWork.Prerequisites.Add(prerequisite);
            await _unitOfWork.SaveChanges();

            return new BaseResponseDTO<Prerequisite> { Success = true, Object = prerequisite };
        }

        public async Task<BaseResponseDTO<Prerequisite>> UpdatePrerequisite(UpdatePrerequisiteRequest request)
        {
            if (request.Id.IsNullOrEmpty() ||
                request.CourseId.IsNullOrEmpty() ||
                request.PrerequisiteCourseId.IsNullOrEmpty())
            {
                return new BaseResponseDTO<Prerequisite> { Success = false, Message = "Id must be given." };
            }

            var course = await _unitOfWork.Courses.GetById(request.CourseId);

            if (course == null)
            {
                return new BaseResponseDTO<Prerequisite>
                {
                    Success = false,
                    Message = "Unable to find course with id " + request.CourseId
                };
            }

            var prerequisiteCourse = await _unitOfWork.Courses.GetById(request.PrerequisiteCourseId);

            if (prerequisiteCourse == null)
            {
                return new BaseResponseDTO<Prerequisite>
                {
                    Success = false,
                    Message = "Unable to find prerequisiteCourse with id " + request.PrerequisiteCourseId
                };
            }

            var prerequisite = await _unitOfWork.Prerequisites.GetById(request.Id);

            if (prerequisite == null)
            {
                return new BaseResponseDTO<Prerequisite>
                {
                    Success = false,
                    Message = "Unable to find prerequisite with id " + request.Id
                };
            }

            prerequisite.CourseId = request.CourseId;
            prerequisite.PrerequisiteCourseId = request.PrerequisiteCourseId;
            prerequisite.LastUpdatedTime = DateTime.Now;

            await _unitOfWork.Prerequisites.Update(prerequisite);
            await _unitOfWork.SaveChanges();

            return new BaseResponseDTO<Prerequisite> { Success = true, Object = prerequisite };
        }
    }
}
