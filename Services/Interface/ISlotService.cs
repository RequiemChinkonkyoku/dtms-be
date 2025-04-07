using Models.DTOs;
using Models.DTOs.Slot.Response;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interface
{
    public interface ISlotService
    {
        Task<List<GetSlotByClassResponse>> GetSlotsByClassAndDog(string classId, string dogId);
        Task<BaseResponseDTO<Slot>> CheckinSlot(string id);
        Task<BaseResponseDTO<GetTrainerSlotResponse>> GetTrainerSlots(string id);
    }
}
