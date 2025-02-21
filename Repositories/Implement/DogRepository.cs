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
            var result = await _context.Dogs
                .AsSplitQuery()
                .Include(d => d.DogBreed)
                .Include(d => d.CustomerProfile)
                .ToListAsync();

            return result;
        }
        public async Task<Dog> GetDogById(string dogId)
        {
            return await _context.Dogs
                .AsSplitQuery()
                .Include(d => d.DogBreed)
                .Include(d => d.CustomerProfile)
                .FirstOrDefaultAsync(d => d.Id == dogId);
        }

    }
}
