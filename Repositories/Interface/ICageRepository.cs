﻿using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interface
{
    public interface ICageRepository : IRepositoryBase<Cage>
    {
        Task<List<Cage>> GetAllCages();
        Task<Cage> GetCageById(string id);
    }
}
