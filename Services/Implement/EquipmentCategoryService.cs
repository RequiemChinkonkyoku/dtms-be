using Microsoft.IdentityModel.Tokens;
using Models.DTOs;
using Models.Entities;
using Repositories.Interface;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Implement
{
    public class EquipmentCategoryService : IEquipmentCategoryService
    {
        private readonly IUnitOfWork _unitOfWork;

        public EquipmentCategoryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<BaseResponseDTO<EquipmentCategory>> GetAllEquipmentCategories()
        {
            var result = await _unitOfWork.EquipmentCategories.GetAll();

            return new BaseResponseDTO<EquipmentCategory> { Success = true, ObjectList = result };
        }

        public async Task<BaseResponseDTO<EquipmentCategory>> CreateEquipmentCategory(CreateEquipmentCategoryRequest request)
        {
            var equipmentCategory = new EquipmentCategory
            {
                Name = request.Name,
                Description = request.Description,
                Status = 1,
                CreatedTime = DateTime.Now,
                LastUpdatedTime = DateTime.Now,
            };

            await _unitOfWork.EquipmentCategories.Add(equipmentCategory);
            await _unitOfWork.SaveChanges();

            return new BaseResponseDTO<EquipmentCategory> { Success = true, Object = equipmentCategory };
        }

        public async Task<BaseResponseDTO<EquipmentCategory>> UpdateEquipmentCategory(UpdateEquipmentCategoryRequest request)
        {
            if (request.Id.IsNullOrEmpty())
            {
                return new BaseResponseDTO<EquipmentCategory> { Success = false, Message = "Id must be provided." };
            }

            var equipmentCategory = await _unitOfWork.EquipmentCategories.GetById(request.Id);

            if (equipmentCategory == null)
            {
                return new BaseResponseDTO<EquipmentCategory> { Success = false, Message = "No object with id " + request.Id };
            }

            equipmentCategory.Name = request.Name;
            equipmentCategory.Description = request.Description;
            equipmentCategory.Status = request.Status.Value;
            equipmentCategory.LastUpdatedTime = DateTime.Now;

            await _unitOfWork.EquipmentCategories.Update(equipmentCategory);
            await _unitOfWork.SaveChanges();

            return new BaseResponseDTO<EquipmentCategory> { Success = true, Object = equipmentCategory };
        }
        
        public async Task<BaseResponseDTO<EquipmentCategory>> GetEquipmentCategoryById(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                return new BaseResponseDTO<EquipmentCategory> { Success = false, Message = "Id must be provided." };
            }

            var equipmentCategory = await _unitOfWork.EquipmentCategories.GetById(id);

            if (equipmentCategory == null)
            {
                return new BaseResponseDTO<EquipmentCategory> { Success = false, Message = "No equipment category found with id " + id };
            }

            return new BaseResponseDTO<EquipmentCategory> { Success = true, Object = equipmentCategory };
        }
    }
}
