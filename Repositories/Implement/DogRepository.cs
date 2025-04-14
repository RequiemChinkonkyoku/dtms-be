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
                    .ThenInclude(o => o.Customer)
                .ToListAsync();
        }
        public async Task<Dog> GetDogById(string dogId)
        {
            return await _context.Dogs
                .AsSplitQuery()
                .Include(d => d.DogBreed)
                    .ThenInclude(db => db.DogType)
                .Include(d => d.DogOwnerships)
                    .ThenInclude(o => o.Customer)
                .FirstOrDefaultAsync(d => d.Id == dogId);
        }

        public async Task<List<Dog>> GetCustomerDog(string customerId)
        {
            var dogs = await _context.Dogs
                .AsSplitQuery()
                .Include(d => d.DogBreed)
                .Include(d => d.DogOwnerships)
                .ThenInclude(o => o.Customer)
                .Where(d => d.DogOwnerships
                    .Any(o => o.CustomerId == customerId && o.ToDate == null))
                .ToListAsync();

            return dogs;
        }
    }
}
