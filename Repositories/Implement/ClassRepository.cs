﻿using Microsoft.EntityFrameworkCore;
using Models.Entities;
using Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Implement
{
    public class ClassRepository : RepositoryBase<Class>, IClassRepository
    {
        public async Task<List<Class>> GetAllClassesAsync()
        {
            return await _context.Classes
                            .AsSplitQuery()
                            .Include(c => c.Course)
                            .Include(c => c.TrainerAssignments)
                                .ThenInclude(ta => ta.Trainer)
                            .Include(c => c.Enrollments)
                                .ThenInclude(e => e.Dog)
                            .Include(c => c.Enrollments)
                                .ThenInclude(e => e.Cage)
                            .ToListAsync();
        }

        public async Task<Class> GetClassByIdAsync(string id)
        {
            return await _context.Classes
                            .AsSplitQuery()
                            .Include(c => c.Course)
                            .Include(c => c.TrainerAssignments)
                                .ThenInclude(ta => ta.Trainer)
                            .Include(c => c.Slots)
                                .ThenInclude(s => s.Schedule)
                            .Include(c => c.Slots)
                                .ThenInclude(s => s.Lesson)
                            .Include(c => c.Enrollments)
                                .ThenInclude(e => e.Dog)
                            .Include(c => c.Enrollments)
                                .ThenInclude(e => e.Cage)
                            .FirstOrDefaultAsync(c => c.Id == id);
        }
    }
}
