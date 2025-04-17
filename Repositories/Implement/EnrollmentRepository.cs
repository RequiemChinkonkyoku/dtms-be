using Microsoft.EntityFrameworkCore;
using Models.Constants;
using Models.Entities;
using Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Implement
{
    public class EnrollmentRepository : RepositoryBase<Enrollment>, IEnrollmentRepository
    {
        public async Task<int> GetActiveCageCountByStaffId(string staffId)
        {
            return await _context.Enrollments
                            .Where(e => e.StaffId == staffId &&
                                        e.Status == (int)EnrollmentStatusEnum.Active &&
                                        e.RequiredNightStay == true)
                            .CountAsync();
        }
    }
}
