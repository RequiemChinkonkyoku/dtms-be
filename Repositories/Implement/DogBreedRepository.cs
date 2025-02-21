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
    public class DogBreedRepository : RepositoryBase<DogBreed>, IDogBreedRepository
    {
        public async Task<List<DogBreed>> GetAllDogBreeds()
        {
            return await _context.DogBreeds
                .AsSplitQuery()
                .Include(b => b.Dogs) 
                .ToListAsync();
        }

        public async Task<DogBreed> GetDogBreedById(string dogBreedId)
        {
            return await _context.DogBreeds
                .AsSplitQuery()
                .Include(b => b.Dogs) 
                .FirstOrDefaultAsync(b => b.Id == dogBreedId);
        }

    }
}
