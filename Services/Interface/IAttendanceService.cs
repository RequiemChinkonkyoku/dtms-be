using Models.DTOs;
using Models.DTOs.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interface
{
    public interface IAttendanceService
    {
        Task<List<AttendanceResponse>> GetAllAttendanceAsync();
        Task<AttendanceResponse> GetAttendanceByIdAsync(string id);
        Task<string> CreateAttendanceAsync(CreateAttendanceRequest request);
        Task<string> UpdateAttendanceAsync(string id, UpdateAttendanceRequest request);
    }
}
