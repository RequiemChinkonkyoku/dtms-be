using AutoMapper;
using Azure.Core;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Microsoft.VisualBasic;
using Models.Constants;
using Models.DTOs;
using Models.DTOs.Class.Request;
using Models.DTOs.Class.Response;
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
using static Models.DTOs.Class.Request.CreateClassRequest;

namespace Services.Implement
{
    public class ClassService : IClassService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ClassService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<BaseResponseDTO<GetClassResponse>> GetAllClasses()
        {
            var response = await _unitOfWork.Classes.GetAllClassesAsync();

            var mappedResponse = _mapper.Map<List<GetClassResponse>>(response);

            return new BaseResponseDTO<GetClassResponse> { Success = true, ObjectList = mappedResponse };
        }

        public async Task<BaseResponseDTO<GetClassResponse>> GetClassById(string id)
        {
            var response = await _unitOfWork.Classes.GetClassByIdAsync(id);

            if (response == null)
            {
                return new BaseResponseDTO<GetClassResponse> { Success = false, Message = "Unable to find class with id " + id };
            }

            var mappedResponse = _mapper.Map<GetClassResponse>(response);

            return new BaseResponseDTO<GetClassResponse> { Success = true, Object = mappedResponse };
        }

        public async Task<BaseResponseDTO<Class>> CreateClass(CreateClassRequest request)
        {
            if (request.StartingDate == default ||
                request.StartingDate < DateOnly.FromDateTime(DateTime.Today))
            {
                return new BaseResponseDTO<Class>
                {
                    Success = false,
                    Message = "Starting date cannot be default or in the past."
                };
            }

            if (request.StartingDate < DateOnly.FromDateTime(DateTime.Today))
            {
                return new BaseResponseDTO<Class>
                {
                    Success = false,
                    Message = "Class startingDate must be one month away."
                };
            }

            if (request.CourseId == null ||
                request.TrainerIds.Count <= 0)
            {
                return new BaseResponseDTO<Class> { Success = false, Message = "Ids must be given." };
            }

            if (request.SlotDatas == null || request.SlotDatas.Count <= 0)
            {
                return new BaseResponseDTO<Class> { Success = false, Message = "SlotData must be given." };
            }

            var course = await _unitOfWork.Courses.GetById(request.CourseId);

            if (course == null)
            {
                return new BaseResponseDTO<Class> { Success = false, Message = "Unable to find course with id " + request.CourseId };
            }

            var uniqueDays = request.SlotDatas.Select(sd => sd.DayOfWeek).Distinct().Count();

            if (uniqueDays != course.DaysPerWeek)
            {
                return new BaseResponseDTO<Class>
                {
                    Success = false,
                    Message = $"The number of unique days in SlotDatas must be exactly {course.DaysPerWeek}, but got {uniqueDays}."
                };
            }

            var slotsPerDay = request.SlotDatas.GroupBy(sd => sd.DayOfWeek)
                                               .Select(group => new { Day = group.Key, Count = group.Count() });

            foreach (var day in slotsPerDay)
            {
                if (day.Count != course.SlotsPerDay)
                {
                    return new BaseResponseDTO<Class>
                    {
                        Success = false,
                        Message = $"Day {day.Day} must have exactly {course.SlotsPerDay} slots, but got {day.Count}."
                    };
                }
            }

            if (request.SlotDatas.Count != course.DaysPerWeek * course.SlotsPerDay)
            {
                return new BaseResponseDTO<Class>
                {
                    Success = false,
                    Message = $"Total number of slots must be exactly {course.DaysPerWeek * course.SlotsPerDay}, but got {request.SlotDatas.Count}."
                };
            }

            var trainerIds = new List<string>();

            foreach (var id in request.TrainerIds)
            {
                var trainerAccount = await _unitOfWork.Accounts.GetById(id);

                if (trainerAccount == null)
                {
                    return new BaseResponseDTO<Class> { Success = false, Message = "Unable to find trainer with id " + id };
                }

                trainerIds.Add(id);
            }

            foreach (var slotData in request.SlotDatas)
            {
                if (!Enum.IsDefined(typeof(DayOfWeek), slotData.DayOfWeek))
                {
                    return new BaseResponseDTO<Class>
                    {
                        Success = false,
                        Message = "DayOfWeek must be between 0 (Sunday) and 6 (Saturday)."
                    };
                }

                var schedule = await _unitOfWork.Schedules.GetById(slotData.ScheduleId);

                if (schedule == null)
                {
                    return new BaseResponseDTO<Class>
                    {
                        Success = false,
                        Message = "Unable to find schedule with id " + slotData.ScheduleId
                    };
                }
            }

            var newClass = new Class
            {
                Name = request.Name,
                EnrolledDogCount = 0,
                AssignedTrainerCount = request.TrainerIds.Count(),
                Status = 1,
                StartingDate = request.StartingDate,
                CourseId = request.CourseId,
                CreatedTime = DateTime.UtcNow,
                LastUpdatedTime = DateTime.UtcNow
            };

            await _unitOfWork.Classes.Add(newClass);
            await _unitOfWork.SaveChanges();

            foreach (var trainerId in trainerIds)
            {
                var trainerAssignment = new TrainerAssignment
                {
                    TrainerId = trainerId,
                    ClassId = newClass.Id,
                };

                await _unitOfWork.TrainerAssignments.Add(trainerAssignment);
            }

            await _unitOfWork.SaveChanges();

            //var slotList = new List<Slot>();
            var endDate = request.StartingDate.AddDays(course.DurationInWeeks * 7);

            for (var date = request.StartingDate; date < endDate; date = date.AddDays(1))
            {
                var dayOfWeekSlot = request.SlotDatas.Where(sd => sd.DayOfWeek == date.DayOfWeek).ToList();

                foreach (var slot in dayOfWeekSlot)
                {
                    var newSlot = new Slot
                    {
                        ClassId = newClass.Id,
                        ScheduleId = slot.ScheduleId,
                        Date = date,
                    };

                    //slotList.Add(newSlot);
                    await _unitOfWork.Slots.Add(newSlot);
                }
            }

            try
            {
                await _unitOfWork.SaveChanges();

                return new BaseResponseDTO<Class> { Success = true, Object = newClass };
            }
            catch (Exception ex)
            {
                return new BaseResponseDTO<Class> { Success = false, Message = "There has been an error: " + ex.Message };
            }
        }

        public async Task<BaseResponseDTO<Class>> DeleteClass(string id)
        {
            var existingClass = await _unitOfWork.Classes.GetById(id);

            if (existingClass == null)
            {
                return new BaseResponseDTO<Class> { Success = false, Message = "Unable to find class with id " + id };
            }

            existingClass.Status = 0;

            await _unitOfWork.Classes.Update(existingClass);
            await _unitOfWork.SaveChanges();

            try
            {
                var classTrainers = (await _unitOfWork.TrainerAssignments.GetAll())
                                                .Where(t => t.ClassId == existingClass.Id)
                                                .ToList();

                if (classTrainers.Any())
                {
                    foreach (var trainer in classTrainers)
                    {
                        await _unitOfWork.TrainerAssignments.Delete(trainer);
                    }
                }

                await _unitOfWork.SaveChanges();
            }
            catch (Exception ex)
            {
                return new BaseResponseDTO<Class> { Success = false, Message = "Trainer removal unsuccessful: " + ex.Message };
            }

            try
            {
                var classSlots = (await _unitOfWork.Slots.GetAll())
                                            .Where(s => s.ClassId == existingClass.Id)
                                            .ToList();

                if (classSlots.Any())
                {
                    foreach (var classSlot in classSlots)
                    {
                        await _unitOfWork.Slots.Delete(classSlot);
                    }
                }

                await _unitOfWork.SaveChanges();

                return new BaseResponseDTO<Class> { Success = true, Object = existingClass };
            }
            catch (Exception ex)
            {
                return new BaseResponseDTO<Class> { Success = false, Message = "Slot removal unsuccessful: " + ex.Message };
            }
        }

        public async Task<BaseResponseDTO<Class>> GetClassSlots(string id)
        {
            var existingClass = await _unitOfWork.Classes.GetById(id);

            if (existingClass == null)
            {
                return new BaseResponseDTO<Class> { Success = false, Message = "Unable to find class with id " + id };
            }

            if (existingClass.Status == 0)
            {
                return new BaseResponseDTO<Class> { Success = false, Message = "This class is closed." };
            }

            var classSlots = (await _unitOfWork.Slots.GetAll())
                                        .Where(s => s.ClassId == existingClass.Id)
                                        .OrderBy(s => s.Date)
                                        .ToList();

            if (!classSlots.Any())
            {
                return new BaseResponseDTO<Class> { Success = false, Message = "There are no slots for this class." };
            }

            existingClass.Slots = classSlots;

            return new BaseResponseDTO<Class> { Success = true, Object = existingClass };
        }

        public async Task<BaseResponseDTO<Class>> UpdateClass(UpdateClassRequest request)
        {
            if (request.Id == null)
            {
                return new BaseResponseDTO<Class> { Success = false, Message = "ClassId must be given." };
            }

            var existingClass = await _unitOfWork.Classes.GetById(request.Id);

            if (existingClass == null)
            {
                return new BaseResponseDTO<Class> { Success = false, Message = "Unable to find class with id " + request.Id };
            }

            if (existingClass.Status == (int)ClassStatusEnum.Ongoing)
            {
                return new BaseResponseDTO<Class> { Success = false, Message = "Ongoing classes cannot be updated." };
            }

            if (existingClass.Name.CompareTo(request.Name) != 0)
            {
                if (request.Name.IsNullOrEmpty())
                {
                    return new BaseResponseDTO<Class> { Success = false, Message = "New name cannot be empty." };
                }
                existingClass.Name = request.Name;
            }

            if (!Enum.IsDefined(typeof(ClassStatusEnum), request.Status))
            {
                return new BaseResponseDTO<Class>
                {
                    Success = false,
                    Message = "Invalid class status " + request.Status
                };
            }

            if (existingClass.Status != request.Status)
            {
                existingClass.Status = request.Status;
            }

            if (existingClass.StartingDate != request.StartingDate)
            {
                if (request.StartingDate.CompareTo(DateOnly.FromDateTime(DateTime.Today)) < 0)
                {
                    return new BaseResponseDTO<Class> { Success = false, Message = "StartingDate cannot be in the past." };
                }

                existingClass.StartingDate = request.StartingDate;
            }

            if (existingClass.CourseId != request.CourseId)
            {
                var course = await _unitOfWork.Courses.GetById(request.CourseId);

                if (course == null)
                {
                    return new BaseResponseDTO<Class> { Success = false, Message = "Unable to find course with id " + request.CourseId };
                }

                existingClass.CourseId = request.CourseId;
            }

            foreach (var trainerId in request.TrainerIds)
            {
                var trainer = await _unitOfWork.TrainerProfiles.GetById(trainerId);

                if (trainer == null)
                {
                    return new BaseResponseDTO<Class> { Success = false, Message = "Unable to find trainer with id " + trainerId };
                }
            }

            var classTrainerIds = (await _unitOfWork.TrainerAssignments.GetAll())
                                                .Where(ta => ta.ClassId == existingClass.Id)
                                                .Select(ta => ta.TrainerId)
                                                .ToList();

            var trainerIdsToAdd = request.TrainerIds.Except(classTrainerIds).ToList();
            var trainerIdsToRemove = classTrainerIds.Except(request.TrainerIds).ToList();

            if (trainerIdsToAdd.Any())
            {
                var trainers = (await _unitOfWork.TrainerProfiles.GetAll())
                                            .Where(tp => trainerIdsToAdd.Contains(tp.Id))
                                            .ToList();

                foreach (var trainer in trainers)
                {
                    var newTrainerAssignment = new TrainerAssignment { ClassId = existingClass.Id, TrainerId = trainer.Id };

                    await _unitOfWork.TrainerAssignments.Add(newTrainerAssignment);
                }

                await _unitOfWork.SaveChanges();
            }

            if (trainerIdsToRemove.Any())
            {
                var trainers = (await _unitOfWork.TrainerAssignments.GetAll())
                                            .Where(ta => trainerIdsToRemove.Contains(ta.TrainerId))
                                            .ToList();

                foreach (var trainer in trainers)
                {
                    await _unitOfWork.TrainerAssignments.Delete(trainer);
                }

                await _unitOfWork.SaveChanges();
            }

            await _unitOfWork.Classes.Update(existingClass);
            await _unitOfWork.SaveChanges();

            return new BaseResponseDTO<Class> { Success = true, Object = existingClass };
        }

        public async Task<BaseResponseDTO<Class>> EnrollClass(EnrollClassRequest request)
        {
            if (request.ClassId == null ||
                request.CustomerProfileId == null ||
                request.DogId == null)
            {
                return new BaseResponseDTO<Class> { Success = false, Message = "Ids must be given." };
            }

            var existingClass = await _unitOfWork.Classes.GetById(request.ClassId);

            if (existingClass == null)
            {
                return new BaseResponseDTO<Class> { Success = false, Message = "Unable to find class with id " + request.ClassId };
            }

            var customerProfile = await _unitOfWork.Accounts.GetById(request.CustomerProfileId);

            if (customerProfile == null)
            {
                return new BaseResponseDTO<Class> { Success = false, Message = "Unable to find accounts with id " + request.CustomerProfileId };
            }

            var customerRole = await _unitOfWork.Roles.GetById(customerProfile.RoleId);
            if (customerRole == null)
            {
                throw new KeyNotFoundException("CustomerRole is not valid.");
            }
            if (customerRole.Name != "Customer_Individual" && customerRole.Name != "Customer_Organizational")
            {
                throw new ArgumentException("User is not a customer.");
            }

            var dog = await _unitOfWork.Dogs.GetById(request.DogId);

            if (dog == null)
            {
                return new BaseResponseDTO<Class> { Success = false, Message = "Unable to find dog with id " + request.DogId };
            }

            var dogOwnership = (await _unitOfWork.DogOwnerships.GetAll())
                                            .Where(d => d.CustomerId == request.CustomerProfileId &&
                                                        d.DogId == request.DogId &&
                                                        d.ToDate == null)
                                            .FirstOrDefault();

            if (dogOwnership == null)
            {
                return new BaseResponseDTO<Class> { Success = false, Message = "The dog doesn't belong to this customer." };
            }

            var existingEnrollment = (await _unitOfWork.Enrollments.GetAll())
                                                .Where(e => e.DogId == request.DogId &&
                                                            e.ClassId == request.ClassId &&
                                                            e.Status != 0)
                                                .FirstOrDefault();

            if (existingEnrollment != null)
            {
                return new BaseResponseDTO<Class> { Success = false, Message = "The dog is already enrolled into this class." };
            }

            var courseDog = (await _unitOfWork.CourseDogs.GetAll())
                                        .Where(c => c.CourseId == existingClass.CourseId)
                                        .Select(cd => cd.DogBreedId)
                                        .ToList();

            if (!courseDog.Contains(dog.DogBreedId))
            {
                return new BaseResponseDTO<Class> { Success = false, Message = "The course doesn't support this dog breed." };
            }

            var course = await _unitOfWork.Courses.GetById(existingClass.CourseId);

            if (existingClass.EnrolledDogCount == course.MaxDogs)
            {
                return new BaseResponseDTO<Class> { Success = false, Message = "This class dog enrollment limit is reached." };
            }

            var prerequisites = (await _unitOfWork.Prerequisites.GetAll())
                                            .Where(p => p.CourseId == course.Id)
                                            .Select(p => p.PrerequisiteCourseId)
                                            .ToList();

            if (prerequisites.Any())
            {
                var certificateList = new List<Certificate>();

                foreach (var courseId in prerequisites)
                {
                    var certificate = (await _unitOfWork.Certificates.GetAll())
                                                    .Where(c => c.CourseId == course.Id)
                                                    .FirstOrDefault();

                    certificateList.Add(certificate);
                }

                foreach (var certificate in certificateList)
                {
                    var dogCertificate = (await _unitOfWork.DogCertificates.GetAll())
                                                        .Where(dc => dc.DogId == request.DogId &&
                                                                     dc.CertificateId == certificate.Id)
                                                        .FirstOrDefault();

                    if (dogCertificate == null)
                    {
                        var missingCourse = await _unitOfWork.Courses.GetById(certificate.CourseId);

                        return new BaseResponseDTO<Class>
                        {
                            Success = false,
                            Message = $"The dog doesn't a certificate for the course {missingCourse.Name}."
                        };
                    }
                }
            }

            var cageId = "-1";

            if (request.IsBoarding)
            {
                var availableCage = (await _unitOfWork.Cages.GetAll())
                                                .Where(c => c.Status == 1)
                                                .FirstOrDefault();

                if (availableCage == null)
                {
                    return new BaseResponseDTO<Class> { Success = false, Message = "All cages are unavailable." };
                }

                cageId = availableCage.Id;
            }

            var enrollment = new Enrollment
            {
                Status = (int)EnrollmentStatusEnum.Pending,
                RequiedNightStay = request.IsBoarding,
                ClassId = request.ClassId,
                DogId = request.DogId,
                CageId = cageId
            };

            await _unitOfWork.Enrollments.Add(enrollment);
            await _unitOfWork.SaveChanges();

            existingClass.EnrolledDogCount += 1;

            await _unitOfWork.Classes.Update(existingClass);
            await _unitOfWork.SaveChanges();

            var assignedCage = await _unitOfWork.Cages.GetById(cageId);
            assignedCage.Status = 0;

            await _unitOfWork.Cages.Update(assignedCage);
            await _unitOfWork.SaveChanges();

            var pretest = new PreTest
            {
                TestDate = existingClass.StartingDate.AddDays(-7),
                Status = (int)PretestStatusEnum.Pending,
                DogId = request.DogId,
                ClassId = request.ClassId
            };

            await _unitOfWork.Pretests.Add(pretest);
            await _unitOfWork.SaveChanges();

            existingClass.Enrollments = new List<Enrollment>();
            existingClass.PreTests = new List<PreTest>();
            existingClass.Enrollments.Add(enrollment);
            existingClass.PreTests.Add(pretest);

            return new BaseResponseDTO<Class> { Success = true, Object = existingClass };
        }

        public async Task<BaseResponseDTO<Class>> GetClassByCourseId(string id)
        {
            var course = await _unitOfWork.Courses.GetById(id);

            if (course == null)
            {
                return new BaseResponseDTO<Class> { Success = false, Message = "Unable to find course with id " + id };
            }

            var courseClasses = (await _unitOfWork.Classes.GetAll())
                                            .Where(c => c.CourseId == id && c.Status == (int)ClassStatusEnum.Active)
                                            .ToList();

            if (!courseClasses.Any())
            {
                return new BaseResponseDTO<Class> { Success = false, Message = "There are no active classes for the course." };
            }

            var result = new List<Class>();

            foreach (var currentClass in courseClasses)
            {
                var classSlots = (await _unitOfWork.Slots.GetAll())
                                            .Where(s => s.ClassId == currentClass.Id)
                                            .ToList();

                if (!classSlots.Any())
                {
                    return new BaseResponseDTO<Class> { Success = false, Message = "There are no slots for the class " + currentClass.Id };
                }

                currentClass.Slots = classSlots;

                result.Add(currentClass);
            }

            return new BaseResponseDTO<Class> { Success = true, ObjectList = result };
        }

        public async Task<BaseResponseDTO<Class>> GetDogEnrolledClasses(string id)
        {
            var dog = await _unitOfWork.Dogs.GetDogById(id);

            if (dog == null)
            {
                return new BaseResponseDTO<Class> { Success = false, Message = "Unable to find dog with id " + id };
            }

            var dogEnrollemnts = (await _unitOfWork.Enrollments.GetAll())
                                            .Where(e => e.DogId == id)
                                            .OrderByDescending(e => e.CreatedTime)
                                            .ToList();

            if (!dogEnrollemnts.Any())
            {
                return new BaseResponseDTO<Class> { Success = false, Message = "The dog hasn't enroll into any class." };
            }

            var result = new List<Class>();

            foreach (var enrollment in dogEnrollemnts)
            {
                var currentClass = await _unitOfWork.Classes.GetById(enrollment.ClassId);

                if (currentClass == null)
                {
                    return new BaseResponseDTO<Class> { Success = false, Message = "Unable to find class with id " + enrollment.ClassId };
                }

                result.Add(currentClass);
            }

            return new BaseResponseDTO<Class> { Success = true, ObjectList = result };
        }

        public async Task<BaseResponseDTO<Class>> UpdateClassStatus(UpdateClassStatusRequest request)
        {
            var existingClass = await _unitOfWork.Classes.GetById(request.ClassId);

            if (existingClass == null)
            {
                return new BaseResponseDTO<Class>
                {
                    Success = false,
                    Message = "Unable to find class with id " + request.ClassId
                };
            }

            if (!Enum.IsDefined(typeof(ClassStatusEnum), request.Status))
            {
                return new BaseResponseDTO<Class>
                {
                    Success = false,
                    Message = "Invalid class status " + request.Status
                };
            }

            existingClass.Status = request.Status;

            try
            {
                await _unitOfWork.Classes.Update(existingClass);
                await _unitOfWork.SaveChanges();

                return new BaseResponseDTO<Class>
                {
                    Success = true,
                    Object = existingClass
                };
            }
            catch (Exception ex)
            {
                return new BaseResponseDTO<Class>
                {
                    Success = false,
                    Message = "There has been an error updating class status."
                };
            }
        }
    }
}