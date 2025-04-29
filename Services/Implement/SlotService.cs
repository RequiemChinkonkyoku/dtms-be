using AutoMapper;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Models.Constants;
using Models.DTOs;
using Models.DTOs.Slot.Response;
using Models.Entities;
using Repositories.Interface;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Implement
{
    public class SlotService : ISlotService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public SlotService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<List<GetSlotByClassResponse>> GetSlotsByClassAndDog(string classId, string dogId)
        {
            var classExists = await _unitOfWork.Classes.GetById(classId);
            if (classExists == null)
            {
                throw new KeyNotFoundException($"Class with ID {classId} not found.");
            }

            var dogExists = await _unitOfWork.Dogs.GetById(dogId);
            if (dogExists == null)
            {
                throw new KeyNotFoundException($"Dog with ID {dogId} not found.");
            }

            var result = await _unitOfWork.Slots.GetSlotsByClassAndDog(classId, dogId);
            return _mapper.Map<List<GetSlotByClassResponse>>(result);
        }

        public async Task<BaseResponseDTO<GetTrainerSlotResponse>> GetTrainerSlots(string id)
        {
            var trainerAcc = _unitOfWork.Accounts.GetById(id);

            if (trainerAcc == null)
            {
                return new BaseResponseDTO<GetTrainerSlotResponse>
                {
                    Success = false,
                    Message = "Unable to find trainer account with id " + id
                };
            }

            var trainerClassIds = (await _unitOfWork.TrainerAssignments.GetAll())
                                                .Where(ta => ta.TrainerId == id)
                                                .Select(ta => ta.ClassId)
                                                .ToList();

            if (!trainerClassIds.Any())
            {
                return new BaseResponseDTO<GetTrainerSlotResponse>
                {
                    Success = false,
                    Message = "The trainer is not in any class."
                };
            }

            var trainerSlot = new List<Slot>();

            foreach (var classId in trainerClassIds)
            {
                var existingClass = await _unitOfWork.Classes.GetClassByIdAsync(classId);

                if (existingClass == null)
                {
                    return new BaseResponseDTO<GetTrainerSlotResponse>
                    {
                        Success = false,
                        Message = $"Unable to find class with id {classId}."
                    };
                }

                if (existingClass.Status == (int)ClassStatusEnum.Ongoing ||
                    existingClass.Status == (int)ClassStatusEnum.Active)
                {
                    trainerSlot.AddRange(existingClass.Slots);
                }
            }

            if (trainerSlot.Count == 0)
            {
                return new BaseResponseDTO<GetTrainerSlotResponse>
                {
                    Success = false,
                    Message = "The trainer has no slot."
                };
            }

            trainerSlot.OrderBy(s => s.Date);

            var mappedResponse = _mapper.Map<List<GetTrainerSlotResponse>>(trainerSlot);

            return new BaseResponseDTO<GetTrainerSlotResponse> { Success = true, ObjectList = mappedResponse };
        }

        public async Task<BaseResponseDTO<Slot>> CheckinSlot(string id)
        {
            var slot = await _unitOfWork.Slots.GetById(id);

            if (slot == null)
            {
                return new BaseResponseDTO<Slot>
                {
                    Success = false,
                    Message = "Unable to find slot."
                };
            }

            if (slot.Date != DateOnly.FromDateTime(DateTime.UtcNow))
            {
                return new BaseResponseDTO<Slot>
                {
                    Success = false,
                    Message = "Today is not the correct day for checkin."
                };
            }

            if (slot.Status != (int)SlotStatusEnum.NotYet)
            {
                return new BaseResponseDTO<Slot>
                {
                    Success = false,
                    Message = "Invalid slot status for checkin."
                };
            }

            slot.Status = (int)SlotStatusEnum.CheckedIn;

            try
            {
                await _unitOfWork.Slots.Update(slot);
                await _unitOfWork.SaveChanges();
            }
            catch (Exception ex)
            {
                return new BaseResponseDTO<Slot>
                {
                    Success = false,
                    Message = $"There has been an error updating the slot.EX: {ex.Message}"
                };
            }

            return new BaseResponseDTO<Slot> { Success = true, Object = slot };
        }

        public async Task<BaseResponseDTO<Slot>> ConcludeSlot(string id)
        {
            var slot = await _unitOfWork.Slots.GetById(id);

            if (slot == null)
            {
                return new BaseResponseDTO<Slot>
                {
                    Success = false,
                    Message = "Unable to find slot."
                };
            }

            if (slot.Date != DateOnly.FromDateTime(DateTime.UtcNow))
            {
                return new BaseResponseDTO<Slot>
                {
                    Success = false,
                    Message = "Today is not the correct day to conclude."
                };
            }

            if (slot.Status != (int)SlotStatusEnum.CheckedIn)
            {
                return new BaseResponseDTO<Slot>
                {
                    Success = false,
                    Message = "Invalid slot status for checkin."
                };
            }

            slot.Status = (int)SlotStatusEnum.Concluded;

            try
            {
                await _unitOfWork.Slots.Update(slot);
                await _unitOfWork.SaveChanges();
            }
            catch (Exception ex)
            {
                return new BaseResponseDTO<Slot>
                {
                    Success = false,
                    Message = $"There has been an error updating the slot.EX: {ex.Message}"
                };
            }

            return new BaseResponseDTO<Slot> { Success = true, Object = slot };
        }
    }
}
