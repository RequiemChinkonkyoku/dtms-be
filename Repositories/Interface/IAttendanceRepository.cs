using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interface
{
    public interface IAttendanceRepository : IRepositoryBase<Attendance>
    {
        Task<List<Attendance>> GetAllAttendancesAsync();
        Task<Attendance> GetAttendnceByIdAsync(string id);
    }
}
