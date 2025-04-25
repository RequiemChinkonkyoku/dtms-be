using AutoMapper;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Microsoft.IdentityModel.Tokens;
using Models.DTOs;
using Models.DTOs.Course.Request;
using Models.DTOs.Course.Response;
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
        private readonly IMapper _mapper;

        public CourseService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<BaseResponseDTO<Course>> GetAllCourses()
        {
            var response = await _unitOfWork.Courses.GetAll();

            return new BaseResponseDTO<Course> { Success = true, ObjectList = response };
        }

        public async Task<BaseResponseDTO<Course>> GetCoursesByCategoryId(string categoryId)
        {
            var response = await _unitOfWork.Courses.GetCoursesByCategoryId(categoryId);

            return new BaseResponseDTO<Course> { Success = true, ObjectList = response };
        }

        public async Task<BaseResponseDTO<GetCourseResponse>> GetCourseById(string id)
        {
            var course = await _unitOfWork.Courses.GetCourseById(id);

            if (course == null)
            {
                return new BaseResponseDTO<GetCourseResponse> { Success = false, Message = "Unable to find course with id " + id };
            }

            var mappedCourse = _mapper.Map<GetCourseResponse>(course);

            return new BaseResponseDTO<GetCourseResponse> { Success = true, Object = mappedCourse };
        }

        public async Task<BaseResponseDTO<Course>> CreateCourse(CreateCourseRequest request)
        {
            if (request.CategoryId.IsNullOrEmpty() ||
                request.CreatedTrainerId.IsNullOrEmpty() ||
                request.LessonIds.Count <= 0 ||
                request.DogBreedIds.Count <= 0)
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

            var trainerAccount = await _unitOfWork.Accounts.GetById(request.CreatedTrainerId);

            if (trainerAccount == null)
            {
                return new BaseResponseDTO<Course>
                {
                    Success = false,
                    Message = "Unable to find trainer with id " + request.CreatedTrainerId
                };
            }

            foreach (var id in request.DogBreedIds)
            {
                var dogBreed = await _unitOfWork.DogBreeds.GetById(id);

                if (dogBreed == null)
                {
                    return new BaseResponseDTO<Course>
                    {
                        Success = false,
                        Message = "Unable to find dogBreed with id " + id
                    };
                }
            }

            var existingCourseName = (await _unitOfWork.Courses.GetAll())
                .FirstOrDefault(c => string.Equals(c.Name, request.Name, StringComparison.OrdinalIgnoreCase));

            if (existingCourseName != null)
            {
                return new BaseResponseDTO<Course>
                {
                    Success = false,
                    Message = $"There exist a course with the same name {request.Name}"
                };
            }

            var totalRequiredSlots = 0;

            foreach (var id in request.LessonIds)
            {
                var lesson = await _unitOfWork.Lessons.GetById(id);

                if (lesson == null)
                {
                    return new BaseResponseDTO<Course>
                    {
                        Success = false,
                        Message = "Unable to find lesson with id " + id
                    };
                }

                totalRequiredSlots += lesson.Duration;
            }

            var totalAvailableSlots = request.DurationInWeeks * request.DaysPerWeek * request.SlotsPerDay;

            if (totalRequiredSlots > totalAvailableSlots)
            {
                return new BaseResponseDTO<Course>
                {
                    Success = false,
                    Message = $"The course requires {totalRequiredSlots} slots for all lessons, " +
                              $"there are only {totalAvailableSlots} slots currently."
                };
            }

            try
            {
                var course = new Course()
                {
                    Name = request.Name,
                    Description = request.Description,
                    Status = 1,
                    ImageUrl = request.ImageUrl,
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

                foreach (var id in request.LessonIds)
                {
                    var courseLesson = new CourseLesson
                    {
                        Status = 1,
                        CourseId = course.Id,
                        LessonId = id,
                        CreatedTime = DateTime.Now,
                        LastUpdatedTime = DateTime.Now
                    };

                    await _unitOfWork.CourseLessons.Add(courseLesson);
                }

                await _unitOfWork.SaveChanges();

                foreach (var id in request.DogBreedIds)
                {
                    var courseDog = new CourseDog
                    {
                        Status = 1,
                        CourseId = course.Id,
                        DogBreedId = id,
                        CreatedTime = DateTime.Now,
                        LastUpdatedTime = DateTime.Now,
                    };

                    await _unitOfWork.CourseDogs.Add(courseDog);
                }

                await _unitOfWork.SaveChanges();

                var slotsPerWeek = request.DaysPerWeek * request.SlotsPerDay;
                var minWeekRequired = (int)Math.Ceiling((double)totalRequiredSlots / slotsPerWeek);
                var message = "";

                if (totalRequiredSlots < totalAvailableSlots)
                {
                    message = $"The lessons requires only {totalRequiredSlots} of {totalAvailableSlots} slots, " +
                              $"the course duration can be shorten to {minWeekRequired} weeks.";
                }

                var courseCert = new Certificate
                {
                    Name = course.Name + " Certificate",
                    Description = $"Certificate for {course.Name}.",
                    Status = 1,
                    CourseId = course.Id,
                };

                return new BaseResponseDTO<Course>
                {
                    Success = true,
                    Object = course,
                    Message = (!message.IsNullOrEmpty()) ? message : ""
                };
            }
            catch (Exception ex)
            {
                return new BaseResponseDTO<Course> { Success = false, Message = "There has been an error: " + ex.Message };
            }
        }

        public async Task<BaseResponseDTO<Course>> UpdateCourse(UpdateCourseRequest request)
        {
            if (request.Id.IsNullOrEmpty() ||
                request.CategoryId.IsNullOrEmpty() ||
                request.LessonIds.Count <= 0 ||
                request.DogBreedIds.Count <= 0)
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

            foreach (var id in request.DogBreedIds)
            {
                var dogBreed = await _unitOfWork.DogBreeds.GetById(id);

                if (dogBreed == null)
                {
                    return new BaseResponseDTO<Course>
                    {
                        Success = false,
                        Message = "Unable to find dogBreed with id " + id
                    };
                }
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

            var totalRequiredSlots = 0;

            foreach (var id in request.LessonIds)
            {
                var lesson = await _unitOfWork.Lessons.GetById(id);

                if (lesson == null)
                {
                    return new BaseResponseDTO<Course>
                    {
                        Success = false,
                        Message = "Unable to find lesson with id " + id
                    };
                }

                totalRequiredSlots += lesson.Duration;
            }

            var totalAvailableSlots = request.DurationInWeeks * request.DaysPerWeek * request.SlotsPerDay;

            if (totalRequiredSlots > totalAvailableSlots)
            {
                return new BaseResponseDTO<Course>
                {
                    Success = false,
                    Message = $"The course requires {totalRequiredSlots} slots for all lessons, " +
                              $"there are only {totalAvailableSlots} slots currently."
                };
            }

            try
            {
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

                var currentLessonIds = (await _unitOfWork.CourseLessons.GetAll())
                                                    .Where(cl => cl.CourseId == course.Id)
                                                    .Select(cl => cl.LessonId)
                                                    .ToList();

                var lessonIdsToAdd = request.LessonIds.Except(currentLessonIds).ToList();
                var lessonIdsToRemove = currentLessonIds.Except(request.LessonIds).ToList();

                if (lessonIdsToAdd.Any())
                {
                    foreach (var id in lessonIdsToAdd)
                    {
                        var newCourseLesson = new CourseLesson
                        {
                            CourseId = course.Id,
                            LessonId = id,
                            Status = 1,
                            CreatedTime = DateTime.UtcNow,
                            LastUpdatedTime = DateTime.UtcNow,
                        };

                        await _unitOfWork.CourseLessons.Add(newCourseLesson);
                    }

                    await _unitOfWork.SaveChanges();
                }

                if (lessonIdsToRemove.Any())
                {
                    var courseLessonsToRemove = (await _unitOfWork.CourseLessons.GetAll())
                                                        .Where(cl => lessonIdsToRemove.Contains(cl.LessonId))
                                                        .ToList();

                    foreach (var courseLesson in courseLessonsToRemove)
                    {
                        await _unitOfWork.CourseLessons.Delete(courseLesson);
                    }

                    await _unitOfWork.SaveChanges();
                }

                var currentDogBreedIds = (await _unitOfWork.CourseDogs.GetAll())
                                                    .Where(cd => cd.CourseId == course.Id)
                                                    .Select(cd => cd.DogBreedId)
                                                    .ToList();

                var dogBreedIdsToAdd = request.LessonIds.Except(currentDogBreedIds).ToList();
                var dogBreedIdsToRemove = currentDogBreedIds.Except(request.DogBreedIds).ToList();

                if (dogBreedIdsToAdd.Any())
                {
                    foreach (var id in dogBreedIdsToAdd)
                    {
                        var newCourseDog = new CourseDog
                        {
                            Status = 1,
                            CourseId = course.Id,
                            DogBreedId = id,
                            CreatedTime = DateTime.UtcNow,
                            LastUpdatedTime = DateTime.UtcNow,
                        };

                        await _unitOfWork.CourseDogs.Add(newCourseDog);
                    }

                    await _unitOfWork.SaveChanges();
                }

                if (dogBreedIdsToRemove.Any())
                {
                    var courseDogToRemove = (await _unitOfWork.CourseDogs.GetAll())
                                                        .Where(cd => dogBreedIdsToRemove.Contains(cd.DogBreedId))
                                                        .ToList();

                    foreach (var courseDog in courseDogToRemove)
                    {
                        await _unitOfWork.CourseDogs.Delete(courseDog);
                    }

                    await _unitOfWork.SaveChanges();
                }

                var slotsPerWeek = request.DaysPerWeek * request.SlotsPerDay;
                var minWeekRequired = (int)Math.Ceiling((double)totalRequiredSlots / slotsPerWeek);
                var message = "";

                if (totalRequiredSlots < totalAvailableSlots)
                {
                    message = $"The lessons requires only {totalRequiredSlots} of {totalAvailableSlots} slots, " +
                              $"the course duration can be shorten to {minWeekRequired} weeks.";
                }

                return new BaseResponseDTO<Course>
                {
                    Success = true,
                    Object = course,
                    Message = (!message.IsNullOrEmpty()) ? message : ""
                };
            }
            catch (Exception ex)
            {
                return new BaseResponseDTO<Course> { Success = false, Message = "There has been an error: " + ex.Message };
            }
        }

        public async Task<BaseResponseDTO<Course>> DeleteCourse(string id)
        {
            var course = await _unitOfWork.Courses.GetById(id);

            if (course == null)
            {
                return new BaseResponseDTO<Course>
                {
                    Success = false,
                    Message = "Unable to find course with id " + id
                };
            }

            try
            {
                course.Status = 0;

                await _unitOfWork.Courses.Update(course);
                await _unitOfWork.SaveChanges();

                var courseLessons = (await _unitOfWork.CourseLessons.GetAll())
                                                .Where(cl => cl.CourseId == course.Id)
                                                .ToList();

                foreach (var courseLesson in courseLessons)
                {
                    courseLesson.Status = 0;

                    await _unitOfWork.CourseLessons.Update(courseLesson);
                }

                await _unitOfWork.SaveChanges();

                var courseDogs = (await _unitOfWork.CourseDogs.GetAll())
                                            .Where(cd => cd.CourseId == course.Id)
                                            .ToList();

                foreach (var courseDog in courseDogs)
                {
                    courseDog.Status = 0;

                    await _unitOfWork.CourseDogs.Update(courseDog);
                }

                await _unitOfWork.SaveChanges();

                return new BaseResponseDTO<Course> { Success = true, Object = course };
            }
            catch (Exception ex)
            {
                return new BaseResponseDTO<Course> { Success = false, Message = "There has been an error: " + ex.Message };
            }
        }
    }
}