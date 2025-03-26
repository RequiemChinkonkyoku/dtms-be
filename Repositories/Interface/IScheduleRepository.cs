using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interface
{
    public interface IScheduleRepository : IRepositoryBase<Schedule>
    {
        Task<List<Schedule>> GetAllSchedulesAsync();
        Task<Schedule> GetScheduleById(string scheduleId);

        Task<bool> IsScheduleOverlappingAsync(TimeOnly startTime, TimeOnly endTime);
    }
}
