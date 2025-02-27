using AutoMapper;
using Azure.Core;
using Microsoft.IdentityModel.Tokens;
using Microsoft.VisualBasic;
using Models.DTOs;
using Models.DTOs.Class;
using Models.Entities;
using Repositories.Interface;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

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

        public async Task<BaseResponseDTO<Class>> GetAllClasses()
        {
            var response = await _unitOfWork.Classes.GetAll();

            return new BaseResponseDTO<Class> { Success = true, ObjectList = response };
        }

        public async Task<BaseResponseDTO<Class>> GetClassById(string id)
        {
            var response = await _unitOfWork.Classes.GetById(id);

            if (response == null)
            {
                return new BaseResponseDTO<Class> { Success = false, Message = "Unable to find class with id " + id };
            }

            return new BaseResponseDTO<Class> { Success = true, Object = response };
        }

        private bool ValidateStartingDate(DateOnly startingDate)
        {
            var today = DateOnly.FromDateTime(DateTime.Today);
            var daysUntilSunday = (int)DayOfWeek.Sunday - (int)today.DayOfWeek;

            if (daysUntilSunday < 0)
            {
                daysUntilSunday += 7;
            }

            var endOfWeek = today.AddDays(daysUntilSunday);
            var minStartDate = endOfWeek.AddMonths(1);

            return startingDate >= minStartDate;
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

            //if (!ValidateStartingDate(request.StartingDate))
            //{
            //    return new BaseResponseDTO<Class>
            //    {
            //        Success = false,
            //        Message = "Class startingDate must be one month away."
            //    };
            //}

            if (request.StartingDate < DateOnly.FromDateTime(DateTime.Today))
            {
                return new BaseResponseDTO<Class>
                {
                    Success = false,
                    Message = "Class startingDate must be one month away."
                };
            }

            if (request.CourseId == null ||
                request.TrainerProfileIds.Count <= 0)
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

            var trainerIds = new List<string>();

            foreach (var id in request.TrainerProfileIds)
            {
                var trainerProfile = await _unitOfWork.TrainerProfiles.GetById(id);

                if (trainerProfile == null)
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
                AssignedTrainerCount = request.TrainerProfileIds.Count(),
                Status = 0,
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
                    TrainerProfileId = trainerId,
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
    }
}
