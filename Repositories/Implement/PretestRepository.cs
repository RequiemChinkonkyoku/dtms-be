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
    public class PretestRepository : RepositoryBase<PreTest>, IPretestRepository
    {
        public async Task<List<PreTest>> GetAllPretestsAsync()
        {
            return await _context.PreTests
                            .AsSplitQuery()
                            .Include(p => p.Dog)
                            .Include(p => p.Class)
                            .ToListAsync();
        }
        public async Task<PreTest> GetPretestByIdAsync(string id)
        {
            return await _context.PreTests
                            .AsSplitQuery()
                            .Include(p => p.Dog)
                            .Include(p => p.Class)
                            .Where(p => p.Id == id)
                            .FirstOrDefaultAsync();
        }
    }
}
