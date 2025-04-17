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
        Task<int> GetActiveCageCountByStaffId(string staffId);
    }
}
