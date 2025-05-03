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
    public class WishListRepository : RepositoryBase<WishList>, IWishListRepository
    {
        public async Task<List<WishList>> GetAllWishLists()
        {
            return await _context.WishLists
                            .AsSplitQuery()
                            .Include(w => w.Customer)
                                .ThenInclude(c => c.Role)
                            .Include(w => w.Course)
                            .ToListAsync();
        }

        public async Task<WishList> GetWishListById(string id)
        {
            return await _context.WishLists
                            .AsSplitQuery()
                            .Include(w => w.Customer)
                                .ThenInclude(c => c.Role)
                            .Include(w => w.Course)
                            .FirstOrDefaultAsync(w => w.Id == id);
        }
    }
}
