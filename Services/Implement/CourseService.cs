using Microsoft.EntityFrameworkCore.Query.Internal;
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
    public class CourseService : ICourseService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CourseService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<BaseResponseDTO<Course>> GetAllCourses()
        {
            var response = await _unitOfWork.Courses.GetAll();

            return new BaseResponseDTO<Course> { Success = true, ObjectList = response };
        }

        public async Task<BaseResponseDTO<Course>> CreateCourse(CreateCourseRequest request)
        {
            if (request.CategoryId.IsNullOrEmpty() | request.CreatedTrainerId.IsNullOrEmpty())
            {
                return new BaseResponseDTO<Course>
                {
                    Success = false,
                    Message = "Id must be given."
                };
            }

            var category = await _unitOfWork.Categories.GetById(request.CategoryId);

            if (category == null)
            {
                return new BaseResponseDTO<Course>
                {
                    Success = false,
                    Message = "Unable to find category with id " + request.CategoryId
                };
            }

            var trainerProfile = await _unitOfWork.TrainerProfiles.GetById(request.CreatedTrainerId);

            if (trainerProfile == null)
            {
                return new BaseResponseDTO<Course>
                {
                    Success = false,
                    Message = "Unable to find trainer with id " + request.CreatedTrainerId
                };
            }

            var course = new Course()
            {
                Name = request.Name,
                Description = request.Description,
                Status = 1,
                DurationInWeeks = request.DurationInWeeks,
                DaysPerWeek = request.DaysPerWeek,
                SlotsPerDay = request.SlotsPerDay,
                Price = request.Price,
                MinDogs = request.MinDogs,
                MaxDogs = request.MaxDogs,
                MinTrainers = request.MinTrainers,
                MaxTrainers = request.MaxTrainers,
                Complexity = request.Complexity,
                CreatedTrainerId = request.CreatedTrainerId,
                CategoryId = request.CategoryId,
                CreatedTime = DateTime.Now,
                LastUpdatedTime = DateTime.Now,
            };

            await _unitOfWork.Courses.Add(course);
            await _unitOfWork.SaveChanges();

            return new BaseResponseDTO<Course> { Success = true, Object = course };
        }

        public async Task<BaseResponseDTO<Course>> UpdateCourse(UpdateCourseRequest request)
        {
            if (request.Id.IsNullOrEmpty() ||
                request.CategoryId.IsNullOrEmpty())
            {
                return new BaseResponseDTO<Course> { Success = false, Message = "Id must be given." };
            }

            var category = await _unitOfWork.Categories.GetById(request.CategoryId);

            if (category == null)
            {
                return new BaseResponseDTO<Course>
                {
                    Success = false,
                    Message = "Unable to find category with id " + request.CategoryId
                };
            }

            var course = await _unitOfWork.Courses.GetById(request.Id);

            if (course == null)
            {
                return new BaseResponseDTO<Course>
                {
                    Success = false,
                    Message = "Unable to find course with id " + request.Id
                };
            }

            course.Name = request.Name;
            course.Description = request.Description;
            course.Status = request.Status;
            course.DurationInWeeks = request.DurationInWeeks;
            course.DaysPerWeek = request.DaysPerWeek;
            course.SlotsPerDay = request.SlotsPerDay;
            course.MinDogs = request.MinDogs;
            course.MaxDogs = request.MaxDogs;
            course.MinTrainers = request.MinTrainers;
            course.MaxTrainers = request.MaxTrainers;
            course.Complexity = request.Complexity;
            course.CategoryId = request.CategoryId;
            course.LastUpdatedTime = DateTime.Now;

            await _unitOfWork.Courses.Update(course);
            await _unitOfWork.SaveChanges();

            return new BaseResponseDTO<Course> { Success = true, Object = course };
        }
    }
}