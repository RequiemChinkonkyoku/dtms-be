using AutoMapper;
using Models.DTOs;
using Models.DTOs.Response;
using Models.Entities;
using Repositories.Implement;
using Repositories.Interface;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Implement
{
    public class ScheduleService : IScheduleService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public ScheduleService(IMapper mapper, IUnitOfWork unitOfWork )
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<List<ScheduleResponse>> GetAllSchedulesAsync()
        {
            var schedules = await _unitOfWork.Schedules.GetAllSchedulesAsync();
            return _mapper.Map<List<ScheduleResponse>>(schedules);
        }

        public async Task<ScheduleResponse> GetScheduleByIdAsync(string scheduleId)
        {
            var schedule = await _unitOfWork.Schedules.GetScheduleById(scheduleId);
            return _mapper.Map<ScheduleResponse>(schedule);
        }

        public async Task<string> CreateScheduleAsync(CreateScheduleRequest request)
        {
            if (request.StartTime >= request.EndTime)
            {
                throw new ArgumentException("End time must be later than start time.");
            }

            bool isOverlapping = await _unitOfWork.Schedules.IsScheduleOverlappingAsync(request.StartTime, request.EndTime);
            if (isOverlapping)
            {
                throw new ArgumentException("This schedule overlaps with an existing schedule.");
            }

            var newSchedule = new Schedule
            {
                Id = Guid.NewGuid().ToString(), 
                StartTime = request.StartTime,
                EndTime = request.EndTime,
            };

            await _unitOfWork.Schedules.Add(newSchedule);
            await _unitOfWork.SaveChanges();

            return "Schedule created successfully.";
        }

        public async Task<string> UpdateScheduleAsync(string scheduleId, UpdateScheduleRequest request)
        {
            if (request.StartTime >= request.EndTime)
            {
                throw new ArgumentException("End time must be later than start time.");
            }

            bool isOverlapping = await _unitOfWork.Schedules.IsScheduleOverlappingAsync(request.StartTime, request.EndTime);
            if (isOverlapping)
            {
                throw new ArgumentException("This schedule overlaps with an existing schedule.");
            }

            if (isOverlapping)
            {
                throw new ArgumentException("This schedule overlaps with an existing schedule.");
            }

            var schedule = await _unitOfWork.Schedules.GetById(scheduleId);
            if (schedule == null)
            {
                throw new KeyNotFoundException($"Schedule with ID {scheduleId} not found.");
            }

            schedule.StartTime = request.StartTime;
            schedule.EndTime = request.EndTime;
            schedule.LastUpdatedTime = DateTimeOffset.UtcNow;

            await _unitOfWork.Schedules.Update(schedule);
            await _unitOfWork.SaveChanges();

            return "Schedule updated successfully.";

        }

        //public async Task<string> DeleteScheduleAsync(string scheduleId)
        //{
           
        //        var schedule = await _unitOfWork.Schedules.GetById(scheduleId);
        //        if (schedule == null)
        //        {
        //            return $"Schedule with ID {scheduleId} not found.";
        //        }
        //        await _unitOfWork.Schedules.Delete(schedule);
        //        await _unitOfWork.SaveChanges();

        //        return "Schedule deleted successfully";
        //}
    }
}
