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
    public class DogDocumentRepository : RepositoryBase<DogDocument>, IDogDocumentRepository
    {
        public async Task<DogDocument> GetDocumentById(string id)
        {
            var result = await _context.DogDocuments
                .AsSplitQuery()
                .Include(x => x.DogDocumentType)
                .Include(x => x.Dog)
                .ThenInclude(o => o.DogOwnerships)
                .FirstOrDefaultAsync(x => x.Id == id);
            return result;
        }

        public async Task<List<DogDocument>> GetAllDocument()
        {
            var result = await _context.DogDocuments
                .AsSplitQuery()
                .Include (x => x.DogDocumentType)
                .Include(x => x.Dog)
                .ThenInclude(o => o.DogOwnerships)
                .ToListAsync();
            return result;
        }

        public async Task<List<DogDocument>> GetDocumentsByDogId(string dogId)
        {
            var result = await _context.DogDocuments
                .AsSplitQuery()
                .Include(x => x.DogDocumentType)
                .Include(x => x.Dog)
                    .ThenInclude(o => o.DogOwnerships)
                .Where(x => x.DogId == dogId)
                .ToListAsync();

            return result;
        }

    }
}
