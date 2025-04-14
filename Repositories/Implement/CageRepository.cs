using Microsoft.EntityFrameworkCore;
using Models.Entities;
using Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Implement
{
    public class CageRepository : RepositoryBase<Cage>, ICageRepository
    {
        public async Task<List<Cage>> GetAllCages()
        {
            return await _context.Cages
                            .AsSplitQuery()
                            .Include(c => c.CageCategory)
                                .ThenInclude(ct => ct.DogType)
                            .ToListAsync();
        }

        public async Task<Cage> GetCageById(string id)
        {
            return await _context.Cages
                            .AsSplitQuery()
                            .Include(c => c.CageCategory)
                                .ThenInclude(ct => ct.DogType)
                            .FirstOrDefaultAsync(c => c.Id == id);
        }
    }
}
