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
    public class LegalDocumentRepository : RepositoryBase<LegalDocument>, ILegalDocumentRepository
    {
        public async Task<List<LegalDocument>> GetDocumentsByCustomerId(string customerId)
        {
            return await _context.LegalDocuments
                .Where(d => d.CustomerId == customerId)
                .ToListAsync();
        }

    }
}
