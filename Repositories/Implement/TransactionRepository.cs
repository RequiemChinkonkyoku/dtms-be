using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Models.DTOs.Transaction.Response;
using Models.Entities;
using Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Implement
{
    public class TransactionRepository : RepositoryBase<Transaction>, ITransactionRepository
    {
        public async Task<List<Transaction>> GetTransactionByEnrollmentId(string enrollmentId)
        {
            return await _context.Transactions
                .AsSplitQuery()
                .Include(t => t.Enrollment)
                    .ThenInclude(e => e.Dog)
                .Include(t => t.Enrollment)
                    .ThenInclude(e => e.Class)
                    .ThenInclude(c => c.Course)
                .Where(t => t.EnrollmentId == enrollmentId)
                .ToListAsync();
        }

        public async Task<List<Transaction>> GetTransactionByAccountId(string accountId)
        {
            return await _context.Transactions
                .AsSplitQuery()
                .Include(t => t.Enrollment)
                    .ThenInclude(e => e.Dog)
                .Include(t => t.Enrollment)
                    .ThenInclude(e => e.Class)
                    .ThenInclude(c => c.Course)
                .Where(t => t.CustomerId == accountId)
                .ToListAsync();
        }

        public async Task<List<Transaction>> GetAllTransaction()
        {
            return await _context.Transactions
                            .AsSplitQuery()
                            .Include(t => t.Enrollment)
                                .ThenInclude(e => e.Dog)
                            .Include(t => t.Enrollment)
                                .ThenInclude(e => e.Class)
                                    .ThenInclude(c => c.Course)
                            .ToListAsync();
        }
    }
}
