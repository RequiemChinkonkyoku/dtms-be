using AutoMapper;
using Azure.Core;
using CloudinaryDotNet.Actions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Microsoft.VisualBasic;
using Models.Constants;
using Models.DTOs;
using Models.DTOs.Class.Request;
using Models.DTOs.Class.Response;
using Models.DTOs.Slot.Response;
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

            try
            {
                await _unitOfWork.Classes.Add(newClass);
                await _unitOfWork.SaveChanges();
            }
            catch (Exception ex)
            {
                return new BaseResponseDTO<Class>
                {
                    Success = false,
                    Message = $"There has been a problem adding the class. Ex: {ex.Message}."
                };
            }

            try
            {
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
            }
            catch (Exception ex)
            {
                return new BaseResponseDTO<Class>
                {
                    Success = false,
                    Message = $"There has been a problem adding trainerAssignment. Ex: {ex.Message}."
                };
            }

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

                    await _unitOfWork.Slots.Add(newSlot);
                }
            }

            var courseLesson = (await _unitOfWork.CourseLessons.GetCourseLessonsByCourseId(request.CourseId))
                                            .Select(cl => cl.Lesson)
                                            .OrderBy(l => l.Difficulty)
                                            .ToList();

            if (!courseLesson.Any())
            {
                return new BaseResponseDTO<Class> { Success = false, Message = $"There are no lesssons for the course." };
            }

            var classSlots = (await _unitOfWork.Slots.GetClassSlots(newClass.Id))
                                        .OrderBy(s => s.Date)
                                        .ToList();

            if (!classSlots.Any())
            {
                return new BaseResponseDTO<Class> { Success = false, Message = $"There are no slot for the class." };
            }

            var slotIndex = 0;

            foreach (var lesson in courseLesson)
            {
                for (var i = 0; i < lesson.Duration; i++)
                {
                    if (slotIndex >= classSlots.Count)
                    {
                        return new BaseResponseDTO<Class>
                        {
                            Success = false,
                            Message = $"There aren't enough slots for all lessson."
                        };
                    }

                    var slot = classSlots[slotIndex];
                    slot.LessonId = lesson.Id;

                    await _unitOfWork.Slots.Update(slot);
                    slotIndex++;
                }
            }

            while (slotIndex < classSlots.Count)
            {
                var revisionLesson = (await _unitOfWork.Lessons.GetAllLessons())
                                                .Where(l => String.Equals(l.LessonTitle, "Revision", StringComparison.OrdinalIgnoreCase))
                                                .FirstOrDefault();

                classSlots[slotIndex].LessonId = (revisionLesson != null) ? revisionLesson.Id : null;
                slotIndex++;
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

            var existingClass = await _unitOfWork.Classes.GetClassByIdAsync(request.ClassId);

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

            var dog = await _unitOfWork.Dogs.GetDogById(request.DogId);

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

            var courseCert = await _unitOfWork.Certificates.GetCertificateByCourseId(existingClass.CourseId);

            if (courseCert == null)
            {
                return new BaseResponseDTO<Class> { Success = false, Message = $"Unable to find certificate for the course." };
            }

            var existingDogCert = (await _unitOfWork.DogCertificates.GetAll())
                                            .Where(dc => dc.DogId == request.DogId &&
                                                         dc.CertificateId == courseCert.Id)
                                            .FirstOrDefault();
            if (existingDogCert != null)
            {
                return new BaseResponseDTO<Class> { Success = false, Message = "The dog has already completed the course." };
            }

            var existingEnrollment = (await _unitOfWork.Enrollments.GetAll())
                                                .Where(e => e.DogId == request.DogId &&
                                                            e.ClassId == request.ClassId &&
                                                           (e.Status == (int)EnrollmentStatusEnum.Active ||
                                                            e.Status == (int)EnrollmentStatusEnum.Pending))
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

            var preCourseIds = (await _unitOfWork.Prerequisites.GetAll())
                                            .Where(p => p.CourseId == course.Id)
                                            .Select(p => p.PrerequisiteCourseId)
                                            .ToList();

            if (preCourseIds.Any())
            {
                var certificateList = new List<Certificate>();

                foreach (var preCourseId in preCourseIds)
                {
                    var certificate = (await _unitOfWork.Certificates.GetAll())
                                                    .Where(c => c.CourseId == preCourseId)
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
            string assignedStaffId = null;

            if (request.IsBoarding)
            {
                var existingCageId = (await _unitOfWork.Enrollments.GetAll())
                                                .Where(e => e.Status == (int)EnrollmentStatusEnum.Active &&
                                                            e.RequiredNightStay == true &&
                                                            e.DogId == request.DogId)
                                                .Select(e => e.CageId)
                                                .FirstOrDefault();

                if (existingCageId != null)
                {
                    cageId = existingCageId;
                }
                else
                {
                    var availableCageList = (await _unitOfWork.Cages.GetAllCages())
                                                    .Where(c => c.Status == (int)CageStatusEnum.Available &&
                                                                c.Id != "-1")
                                                    .ToList();

                    if (availableCageList.IsNullOrEmpty())
                    {
                        return new BaseResponseDTO<Class> { Success = false, Message = "All cages are unavailable." };
                    }

                    var suitableCage = availableCageList.FirstOrDefault(c => c.CageCategory.DogTypeId == dog.DogBreed.DogTypeId &&
                                                                             c.Id != "-1");

                    if (suitableCage == null)
                    {
                        return new BaseResponseDTO<Class> { Success = false, Message = "There are no suitable cage for the dogType." };
                    }

                    cageId = suitableCage.Id;
                }

                if (cageId == null)
                {
                    return new BaseResponseDTO<Class> { Success = false, Message = "Unable to assign cage." };
                }

                var staffList = await _unitOfWork.Accounts.GetStaffAccountsAsync();

                foreach (var staff in staffList)
                {
                    var activeCageCount = await _unitOfWork.Enrollments.GetActiveCageCountByStaffId(staff.Id);

                    if (activeCageCount < 5)
                    {
                        assignedStaffId = staff.Id;
                        break;
                    }
                }

                if (assignedStaffId.IsNullOrEmpty())
                {
                    return new BaseResponseDTO<Class>
                    {
                        Success = false,
                        Message = $"There are no available staff to attend the cage (Max 5 per staff)."
                    };
                }
            }

            var enrollment = new Enrollment
            {
                Status = (int)EnrollmentStatusEnum.Pending,
                RequiredNightStay = request.IsBoarding,
                ClassId = request.ClassId,
                DogId = request.DogId,
                CageId = cageId,
                StaffId = assignedStaffId
            };

            await _unitOfWork.Enrollments.Add(enrollment);
            await _unitOfWork.SaveChanges();

            existingClass.EnrolledDogCount += 1;

            await _unitOfWork.Classes.Update(existingClass);
            await _unitOfWork.SaveChanges();

            var assignedCage = await _unitOfWork.Cages.GetById(cageId);
            assignedCage.Status = (int)CageStatusEnum.Unavailable;

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

            try
            {
                switch (request.Status)
                {
                    case (int)ClassStatusEnum.Ongoing:
                        {
                            var pendingEnrollments = (await _unitOfWork.Enrollments.GetEnrollmentsByClassId(existingClass.Id))
                                                                .Where(e => e.Status == (int)EnrollmentStatusEnum.Pending)
                                                                .ToList();

                            if (pendingEnrollments.Any())
                            {
                                foreach (var enrollment in pendingEnrollments)
                                {
                                    enrollment.Status = (int)EnrollmentStatusEnum.Inactive;

                                    await _unitOfWork.Enrollments.Update(enrollment);

                                    if (enrollment.RequiredNightStay)
                                    {
                                        var cage = await _unitOfWork.Cages.GetById(enrollment.CageId);

                                        if (cage == null)
                                        {
                                            return new BaseResponseDTO<Class> { Success = false, Message = "Unable to find cage" };
                                        }

                                        cage.Status = (int)CageStatusEnum.Available;

                                        await _unitOfWork.Cages.Update(cage);
                                    }
                                }

                                await _unitOfWork.SaveChanges();
                            }
                            break;
                        }

                    case (int)ClassStatusEnum.Closed:
                        {
                            var classEnrollments = await _unitOfWork.Enrollments.GetEnrollmentsByClassId(existingClass.Id);

                            if (classEnrollments.Any())
                            {
                                foreach (var enrollment in classEnrollments)
                                {
                                    enrollment.Status = (int)EnrollmentStatusEnum.Inactive;

                                    await _unitOfWork.Enrollments.Update(enrollment);

                                    if (enrollment.RequiredNightStay)
                                    {
                                        var cage = enrollment.Cage;
                                        cage.Status = (int)CageStatusEnum.Available;

                                        await _unitOfWork.Cages.Update(cage);
                                    }
                                }

                                await _unitOfWork.SaveChanges();
                            }

                            break;
                        }

                    case (int)ClassStatusEnum.Completed:
                        {
                            var classEnrollments = await _unitOfWork.Enrollments.GetEnrollmentsByClassId(existingClass.Id);

                            if (classEnrollments.Any())
                            {
                                foreach (var enrollment in classEnrollments)
                                {
                                    enrollment.Status = (int)EnrollmentStatusEnum.Concluded;

                                    await _unitOfWork.Enrollments.Update(enrollment);

                                    if (enrollment.RequiredNightStay)
                                    {
                                        var cage = enrollment.Cage;
                                        cage.Status = (int)CageStatusEnum.Available;

                                        await _unitOfWork.Cages.Update(cage);
                                    }
                                }

                                await _unitOfWork.SaveChanges();
                            }

                            break;
                        }
                }

                existingClass.Status = request.Status;

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
                    Message = $"There has been an error updating class status. Ex: {ex.Message}."
                };
            }
        }
    }
}