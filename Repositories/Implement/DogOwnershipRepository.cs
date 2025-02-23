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
    }
}
