using Models.DTOs;
using Models.DTOs.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interface
{
    public interface IScheduleService
    {
        Task<List<ScheduleResponse>> GetAllSchedulesAsync();

        Task<ScheduleResponse> GetScheduleByIdAsync(string scheduleId);

        Task<string> CreateScheduleAsync(CreateScheduleRequest request);

        Task<string> UpdateScheduleAsync(string scheduleId, UpdateScheduleRequest request);

        //Task<string> DeleteScheduleAsync(string scheduleId);
    }
}
