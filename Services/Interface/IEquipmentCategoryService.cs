using Models.DTOs;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interface
{
    public interface IEquipmentCategoryService
    {
        Task<BaseResponseDTO<EquipmentCategory>> CreateEquipmentCategory(CreateEquipmentCategoryRequest request);
        Task<BaseResponseDTO<EquipmentCategory>> GetAllEquipmentCategories();
        Task<BaseResponseDTO<EquipmentCategory>> UpdateEquipmentCategory(UpdateEquipmentCategoryRequest request);
        Task<BaseResponseDTO<EquipmentCategory>> GetEquipmentCategoryById(string id);
    }
}
