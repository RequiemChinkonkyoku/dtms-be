using Microsoft.EntityFrameworkCore;
using Models.DTOs.DogCertificate.Response;
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
    public class DogCertificateRepository : RepositoryBase<DogCertificate>, IDogCertificateRepository
    {
        public async Task<List<DogCertificate>> GetAllWithDetailsAsync()
        {
            return await _context.DogCertificates
                .AsSplitQuery()
                .Include(dc => dc.Dog)
                .Include(dc => dc.Certificate)
                .ToListAsync();
        }
        public async Task<DogCertificate> GetByIdWithDetailAsync(string id)
        {
            return await _context.DogCertificates
                .AsSplitQuery()
                .Include(dc => dc.Dog)
                .Include(dc => dc.Certificate)
                .FirstOrDefaultAsync(dc => dc.Id == id);
        }

        public async Task<DogCertificate> AddAsync(DogCertificate dogCertificate)
        {
            await _context.DogCertificates.AddAsync(dogCertificate);
            return dogCertificate;
        }

        public async Task<bool> AnyAsync(Expression<Func<DogCertificate, bool>> predicate)
        {
            return await _context.DogCertificates.AnyAsync(predicate);
        }

    }
}
