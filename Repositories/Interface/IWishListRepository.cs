﻿using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interface
{
    public interface IWishListRepository : IRepositoryBase<WishList>
    {
        Task<List<WishList>> GetAllWishLists();
        Task<WishList> GetWishListById(string id);
    }
}
