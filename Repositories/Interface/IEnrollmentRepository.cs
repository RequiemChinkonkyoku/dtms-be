using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interface
{
    public interface IEnrollmentRepository : IRepositoryBase<Enrollment>
    {
        Task<Enrollment> GetEnrolmentById(string id);
        Task<int> GetActiveCageCountByStaffId(string staffId);
        Task<List<Enrollment>> GetEnrollmentsByClassId(string classId);
        Task<Enrollment> GetEnrollmentByDogAndClass(string dogId, string classId);
        Task<List<Enrollment>> GetEnrollmentsByDogAndCourse(string dogId, string courseId);
    }
}
