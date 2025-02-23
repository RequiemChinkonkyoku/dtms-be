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
    public class DogRepository : RepositoryBase<Dog>, IDogRepository
    {
        public async Task<List<Dog>> GetAllDogs()
        {
            return await _context.Dogs
                .AsSplitQuery()
                .Include(d => d.DogBreed)
                .Include(d => d.DogOwnerships)
                    .ThenInclude(o => o.CustomerProfile)
                .ToListAsync();
        }
        public async Task<Dog> GetDogById(string dogId)
        {
            return await _context.Dogs
                .AsSplitQuery()
                .Include(d => d.DogBreed)
                .Include(d => d.DogOwnerships)
                    .ThenInclude(o => o.CustomerProfile)
                .FirstOrDefaultAsync(d => d.Id == dogId);
        }
    }
}
