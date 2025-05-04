using Microsoft.EntityFrameworkCore;
using Models.Constants;
using Models.Entities;
using Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Implement
{
    public class EnrollmentRepository : RepositoryBase<Enrollment>, IEnrollmentRepository
    {
        public async Task<List<Enrollment>> GetAllEnrollments()
        {
            return await _context.Enrollments
                            .AsSplitQuery()
                            .Include(e => e.Class)
                                .ThenInclude(c => c.Course)
                            .Include(e => e.Dog)
                                .ThenInclude(d => d.DogBreed)
                            .Include(e => e.Cage)
                                .ThenInclude(c => c.CageCategory)
                            .Include(e => e.Staff)
                            .ToListAsync();
        }

        public async Task<Enrollment> GetEnrolmentById(string id)
        {
            return await _context.Enrollments
                            .AsSplitQuery()
                            .Include(e => e.Class)
                                .ThenInclude(c => c.Course)
                            .Include(e => e.Dog)
                                .ThenInclude(d => d.DogBreed)
                            .Include(e => e.Cage)
                                .ThenInclude(c => c.CageCategory)
                            .Include(e => e.Staff)
                            .FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<int> GetActiveCageCountByStaffId(string staffId)
        {
            return await _context.Enrollments
                            .Where(e => e.StaffId == staffId &&
                                        e.Status == (int)EnrollmentStatusEnum.Active &&
                                        e.RequiredNightStay == true)
                            .CountAsync();
        }

        public async Task<List<Enrollment>> GetEnrollmentsByClassId(string classId)
        {
            return await _context.Enrollments
                            .AsSplitQuery()
                            .Include(e => e.Cage)
                            .Where(e => e.ClassId == classId)
                            .ToListAsync();
        }

        public async Task<Enrollment> GetEnrollmentByDogAndClass(string dogId, string classId)
        {
            return await _context.Enrollments
                            .Where(e => e.DogId == dogId &&
                                        e.ClassId == classId &&
                                        e.Status == (int)EnrollmentStatusEnum.Pending)
                            .FirstOrDefaultAsync();
        }

        public async Task<List<Enrollment>> GetEnrollmentsByDog(string dogId)
        {
            return await _context.Enrollments
                            .AsSplitQuery()
                            .Include(e => e.Class)
                                .ThenInclude(c => c.Course)
                            .Include(e => e.Dog)
                                .ThenInclude(d => d.DogBreed)
                            .Include(e => e.Cage)
                                .ThenInclude(c => c.CageCategory)
                            .Include(e => e.Staff)
                            .Where(e => e.DogId == dogId)
                            .ToListAsync();
        }
    }
}
