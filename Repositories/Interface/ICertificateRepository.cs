using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interface
{
    public interface ICertificateRepository : IRepositoryBase<Certificate>
    {
        Task<Certificate> GetByIdWithDetailsAsync(string id);
        Task<bool> CourseHasCertificate(string courseId);

        Task<Certificate?> GetCertificateByCourseId(string courseId);

        Task<List<Certificate>> GetCertificatesByDogIdAsync(string dogId);
    }
}
