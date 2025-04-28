using Models.Constants;
using Models.DTOs.Slot.Response;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interface
{
    public interface ISlotRepository : IRepositoryBase<Slot>
    {
        Task<List<GetSlotByClassResponse>> GetSlotsByClassAndDog(string classId, string dogId);
        Task<Slot> GetSlotByIdAsync(string id);
        Task<List<Slot>> GetClassSlots(string classId);
        Task<List<Slot>> GetSlotsByDogAndDate(string dogId, DateOnly date);
    }
}
