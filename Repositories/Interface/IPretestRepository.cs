using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interface
{
    public interface IPretestRepository : IRepositoryBase<PreTest>
    {
        Task<List<PreTest>> GetAllPretestsAsync();
        Task<PreTest> GetPretestByIdAsync(string id);
    }
}
