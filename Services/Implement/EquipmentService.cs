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
    public class EquipmentService : IEquipmentService
    {
        private readonly IUnitOfWork _unitOfWork;

        public EquipmentService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<BaseResponseDTO<Equipment>> GetAllEquipments()
        {
            var result = await _unitOfWork.Equipments.GetAll();

            return new BaseResponseDTO<Equipment> { Success = true, ObjectList = result };
        }

        public async Task<BaseResponseDTO<Equipment>> CreateEquipment(CreateEquipmentRequest request)
        {
            if (request.EquipmentCategoryId.IsNullOrEmpty())
            {
                return new BaseResponseDTO<Equipment> { Success = false, Message = "CategoryId cannot be empty." };
            }

            var equipmentCategory = await _unitOfWork.EquipmentCategories.GetById(request.EquipmentCategoryId);

            if (equipmentCategory == null)
            {
                return new BaseResponseDTO<Equipment>
                {
                    Success = false,
                    Message = "Unable to find equipmentCategory with id " + request.EquipmentCategoryId
                };
            }

            var equipment = new Equipment()
            {
                Name = request.Name,
                Description = request.Description,
                Status = 1,
                EquipmentCategoryId = request.EquipmentCategoryId
            };

            await _unitOfWork.Equipments.Add(equipment);
            await _unitOfWork.SaveChanges();

            return new BaseResponseDTO<Equipment> { Success = true, Object = equipment };
        }

        public async Task<BaseResponseDTO<Equipment>> UpdateEquipment(UpdateEquipmentRequest request)
        {
            if (request.Id.IsNullOrEmpty())
            {
                return new BaseResponseDTO<Equipment> { Success = false, Message = "Id must be provided." };
            }

            var equipmentCategory = await _unitOfWork.EquipmentCategories.GetById(request.EquipmentCategoryId);

            if (equipmentCategory == null)
            {
                return new BaseResponseDTO<Equipment>
                {
                    Success = false,
                    Message = "Unable to find equipmentCategory with id " + request.EquipmentCategoryId
                };
            }

            var equipment = await _unitOfWork.Equipments.GetById(request.Id);

            if (equipment == null)
            {
                return new BaseResponseDTO<Equipment> { Success = false, Message = "No equipment with id " + request.Id };
            }

            equipment.Name = request.Name;
            equipment.Description = request.Description;
            equipment.Status = request.Status;
            equipment.EquipmentCategoryId = request.EquipmentCategoryId;
            equipment.LastUpdatedTime = DateTime.Now;

            return new BaseResponseDTO<Equipment> { Success = true, Object = equipment };
        }
    }
}
