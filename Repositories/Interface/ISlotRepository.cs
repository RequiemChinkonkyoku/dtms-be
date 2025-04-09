using Models.DTOs.Slot.Response;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interface
{
    public interface ISlotRepository : IRepositoryBase<Slot>
    {
        Task<List<GetSlotByClassResponse>> GetSlotsByClassAndDog(string classId, string dogId);
        Task<Slot> GetSlotByIdAsync(string id);
    }
}
