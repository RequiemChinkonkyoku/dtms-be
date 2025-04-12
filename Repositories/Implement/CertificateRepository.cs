using Microsoft.EntityFrameworkCore;
using Models.Entities;
using Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Implement
{
    public class CertificateRepository : RepositoryBase<Certificate> , ICertificateRepository
    {
        public async Task<Certificate> GetByIdWithDetailsAsync(string id)
        {
            return await _context.Certificates
                .AsSplitQuery()
                .Include(c => c.Course)  
                .Include(c => c.DogCertificates) 
                .FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<bool> CourseHasCertificate(string courseId)
        {
            return await _context.Certificates
                .FirstOrDefaultAsync(c => c.CourseId == courseId) != null;
        }

        public async Task<Certificate?> GetCertificateByCourseId(string courseId)
        {
            return await _context.Certificates
                .FirstOrDefaultAsync(c => c.CourseId == courseId);
        }

    }
}
