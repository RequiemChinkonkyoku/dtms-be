using AutoMapper.Configuration.Annotations;
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

        public async Task<BaseResponseDTO<Prerequisite>> GetPrerequisitesByCourseId(string id)
        {
            var course = await _unitOfWork.Courses.GetById(id);

            if (course == null)
            {
                return new BaseResponseDTO<Prerequisite> { Success = false, Message = "Unable to find course with id " + id };
            }

            var coursePrerequisites = (await _unitOfWork.Prerequisites.GetAll())
                                                .Where(p => p.CourseId == id)
                                                .ToList();

            return new BaseResponseDTO<Prerequisite> { Success = true, ObjectList = coursePrerequisites };
        }

        public async Task<BaseResponseDTO<Prerequisite>> CreatePrerequisite(CreatePrerequisiteRequest request)
        {
            if (request.CourseId.IsNullOrEmpty() ||
                request.PrerequisiteCourseIds.IsNullOrEmpty())
            {
                return new BaseResponseDTO<Prerequisite> { Success = false, Message = "Ids must be given." };
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

            var existingCourseIds = (await _unitOfWork.Courses.GetAll())
                                                .Select(c => c.Id)
                                                .ToList();
            var invalidIds = request.PrerequisiteCourseIds.Where(id => !existingCourseIds.Contains(id)).ToList();

            if (invalidIds.Any())
            {
                return new BaseResponseDTO<Prerequisite>
                {
                    Success = false,
                    Message = $"There are invalid ids: {string.Join(", ", invalidIds)}."
                };
            }

            var prerequisites = new List<Prerequisite>();

            foreach (var prereqId in request.PrerequisiteCourseIds)
            {
                var prerequisite = new Prerequisite()
                {
                    CourseId = request.CourseId,
                    PrerequisiteCourseId = prereqId,
                    CreatedTime = DateTime.UtcNow,
                    LastUpdatedTime = DateTime.UtcNow,
                };

                await _unitOfWork.Prerequisites.Add(prerequisite);
            }

            await _unitOfWork.SaveChanges();

            return new BaseResponseDTO<Prerequisite> { Success = true, ObjectList = prerequisites };
        }

        public async Task<BaseResponseDTO<Prerequisite>> UpdatePrerequisite(string id, UpdatePrerequisiteRequest request)
        {
            if (id.IsNullOrEmpty() ||
                request.PrerequisiteCourseIds.IsNullOrEmpty())
            {
                return new BaseResponseDTO<Prerequisite> { Success = false, Message = "Ids must be given." };
            }
            ;

            var course = await _unitOfWork.Courses.GetById(id);

            if (course == null)
            {
                return new BaseResponseDTO<Prerequisite>
                {
                    Success = false,
                    Message = $"Unable to find course with id {id}."
                };
            }

            var existingCourseIds = (await _unitOfWork.Courses.GetAll())
                                                .Select(c => c.Id)
                                                .ToList();

            var invalidIds = request.PrerequisiteCourseIds.Where(pId => !existingCourseIds.Contains(pId)).ToList();

            if (invalidIds.Any())
            {
                return new BaseResponseDTO<Prerequisite>
                {
                    Success = false,
                    Message = $"There are invalid ids {string.Join(", ", invalidIds)}."
                };
            }

            var currentPrerequisites = (await _unitOfWork.Prerequisites.GetAll())
                                                    .Where(p => p.CourseId == id)
                                                    .ToList();

            if (currentPrerequisites.Any())
            {
                foreach (var prerequisite in currentPrerequisites)
                {
                    await _unitOfWork.Prerequisites.Delete(prerequisite);
                }

                await _unitOfWork.SaveChanges();
            }

            foreach (var prerequisiteId in request.PrerequisiteCourseIds)
            {
                var newPrerequisite = new Prerequisite
                {
                    CourseId = id,
                    PrerequisiteCourseId = prerequisiteId
                };
                try
                {
                    await _unitOfWork.Prerequisites.Add(newPrerequisite);
                    await _unitOfWork.SaveChanges();
                }
                catch (Exception ex)
                {
                    return new BaseResponseDTO<Prerequisite>
                    {
                        Success = false,
                        Message = $"There has been and error updating prerequisite. Ex: {ex.Message}."
                    };
                }
            }

            return new BaseResponseDTO<Prerequisite> { Success = true };
        }

        public async Task<BaseResponseDTO<Prerequisite>> DeletePrerequisite(List<string> ids)
        {
            foreach (var id in ids)
            {
                var prerequisite = await _unitOfWork.Prerequisites.GetById(id);

                if (prerequisite == null)
                {
                    return new BaseResponseDTO<Prerequisite> { Success = false, Message = "Unable to find prerequisite with id " + id };
                }

                await _unitOfWork.Prerequisites.Delete(prerequisite);
            }
            await _unitOfWork.SaveChanges();

            return new BaseResponseDTO<Prerequisite> { Success = true };
        }
    }
}
