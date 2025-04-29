using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using Models.DTOs;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interface
{
    public interface IEquipmentService
    {
        Task<BaseResponseDTO<Equipment>> CreateEquipment(CreateEquipmentRequest request);
        Task<BaseResponseDTO<Equipment>> GetAllEquipments();
        Task<BaseResponseDTO<Equipment>> UpdateEquipment(UpdateEquipmentRequest request);
        Task<BaseResponseDTO<Equipment>> GetEquipmentById(string id);
    }
}
