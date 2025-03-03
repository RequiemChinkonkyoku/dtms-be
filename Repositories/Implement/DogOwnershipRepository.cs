using Microsoft.EntityFrameworkCore;
using Models.DTOs.Response;
using Models.Entities;
using Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Implement
{
    public class DogOwnershipRepository : RepositoryBase<DogOwnership>, IDogOwnershipRepository
    {

        public async Task<List<DogOwnership>> GetAllDogOwnerships()
        {
            var ownerships = await _context.DogOwnerships
                .AsSplitQuery()  
                .Include(o => o.Dog)  
                    .ThenInclude(d => d.DogBreed) 
                .Include(o => o.CustomerProfile)  
                .ToListAsync();

            return ownerships;
        }

        public async Task<DogOwnership> GetDogOwnershipByIdAsync(string id)
        {
            return await _context.DogOwnerships
                .AsSplitQuery()
                .Include(o => o.Dog)
                    .ThenInclude(d => d.DogBreed)
                .Include(o => o.CustomerProfile)
                .FirstOrDefaultAsync(o => o.Id == id);
        }

        public async Task AddDogOwnershipAsync(DogOwnership dogOwnership)
        {
            await _context.DogOwnerships.AddAsync(dogOwnership);
        }

        public async Task UpdateDogOwnershipAsync(DogOwnership dogOwnership)
        {
            _context.DogOwnerships.Update(dogOwnership);
        }

    }
}
