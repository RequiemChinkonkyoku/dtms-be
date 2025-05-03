using AutoMapper;
using AutoMapper.Configuration.Annotations;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Server.HttpSys;
using Models.Constants;
using Models.DTOs;
using Models.DTOs.Cage;
using Models.DTOs.Cage.Request;
using Models.DTOs.Cage.Response;
using Models.Entities;
using Repositories.Interface;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Implement
{
    public class CageService : ICageService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CageService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<BaseResponseDTO<Cage>> GetAllCages()
        {
            var response = await _unitOfWork.Cages.GetAll();

            return new BaseResponseDTO<Cage> { Success = true, ObjectList = response };
        }

        public async Task<BaseResponseDTO<Cage>> GetCageById(string id)
        {
            var cage = await _unitOfWork.Cages.GetById(id);

            if (cage == null)
            {
                return new BaseResponseDTO<Cage>
                {
                    Success = false,
                    Message = $"Unable to find cage with id {id}."
                };
            }

            return new BaseResponseDTO<Cage> { Success = true, Object = cage };
        }

        public async Task<BaseResponseDTO<Cage>> CreateCage(CreateCageRequest request)
        {
            var cageCate = await _unitOfWork.CageCategories.GetById(request.CageCategoryId);

            if (cageCate == null)
            {
                return new BaseResponseDTO<Cage>
                {
                    Success = false,
                    Message = $"Unable to find cageCategory with id {request.CageCategoryId}."
                };
            }

            var maxNumber = (await _unitOfWork.Cages.GetAll())
                                        .Select(c => c.Number)
                                        .Max();

            var cage = new Cage
            {
                Number = ++maxNumber,
                Status = (int)CageStatusEnum.Available,
                Location = request.Location,
                CageCategoryId = request.CageCategoryId
            };

            await _unitOfWork.Cages.Add(cage);
            await _unitOfWork.SaveChanges();

            return new BaseResponseDTO<Cage> { Success = true, Object = cage };
        }

        public async Task<BaseResponseDTO<Cage>> UpdateCage(UpdateCageRequest request)
        {
            if (request.Id == null || request.CageCategoryId == null)
            {
                return new BaseResponseDTO<Cage>
                {
                    Success = false,
                    Message = "Ids must be given."
                };
            }

            var cage = await _unitOfWork.Cages.GetById(request.Id);

            if (cage == null)
            {
                return new BaseResponseDTO<Cage>
                {
                    Success = false,
                    Message = $"Unable to find cage with id {request.Id}."
                };
            }

            var cageCategory = await _unitOfWork.CageCategories.GetById(request.CageCategoryId);

            if (cageCategory == null)
            {
                return new BaseResponseDTO<Cage>
                {
                    Success = false,
                    Message = $"Unable to find cageCategory with id {request.CageCategoryId}"
                };
            }

            cage.Location = request.Location;
            cage.Status = request.Status;
            cage.CageCategoryId = request.CageCategoryId;
            try
            {
                await _unitOfWork.Cages.Update(cage);
                await _unitOfWork.SaveChanges();
            }
            catch (Exception ex)
            {
                return new BaseResponseDTO<Cage>
                {
                    Success = false,
                    Message = $"There has been an error updating the cage. Ex: {ex.Message}."
                };
            }

            return new BaseResponseDTO<Cage> { Success = true, Object = cage };
        }

        public async Task<BaseResponseDTO<Cage>> DeleteCage(string id)
        {
            var cage = await _unitOfWork.Cages.GetById(id);

            if (cage == null)
            {
                return new BaseResponseDTO<Cage>
                {
                    Success = false,
                    Message = $"Unable to find cage with id {id}."
                };
            }

            var activeEnrollment = (await _unitOfWork.Enrollments.GetAll())
                                                .Where(e => e.Status == (int)EnrollmentStatusEnum.Active ||
                                                            e.Status == (int)EnrollmentStatusEnum.Pending)
                                                .FirstOrDefault();

            if (activeEnrollment != null)
            {
                return new BaseResponseDTO<Cage>
                {
                    Success = false,
                    Message = $"There is a dog assigned to this cage."
                };
            }

            try
            {
                await _unitOfWork.Cages.Delete(cage);
                await _unitOfWork.SaveChanges();
            }
            catch (Exception ex)
            {
                return new BaseResponseDTO<Cage>
                {
                    Success = false,
                    Message = $"There has been an error deleting the cage. Ex: {ex.Message}."
                };
            }

            return new BaseResponseDTO<Cage> { Success = true };
        }

        public async Task<BaseResponseDTO<GetStaffCageResponse>> GetCageByStaffId(string id)
        {
            var staffAcc = await _unitOfWork.Accounts.GetById(id);

            if (staffAcc == null)
            {
                return new BaseResponseDTO<GetStaffCageResponse>
                {
                    Success = false,
                    Message = $"Unable to find staff with id {id}."
                };
            }

            var staffEnrollments = (await _unitOfWork.Enrollments.GetAll())
                                            .Where(e => e.StaffId == id &&
                                                        e.RequiredNightStay == true &&
                                                        e.Status == (int)EnrollmentStatusEnum.Active)
                                            .ToList();

            if (!staffEnrollments.Any())
            {
                return new BaseResponseDTO<GetStaffCageResponse>
                {
                    Success = false,
                    Message = $"The staff isn't assigned to any cage."
                };
            }

            var staffCageResponse = new List<GetStaffCageResponse>();
            var schedules = await _unitOfWork.Schedules.GetAll();
            var distinctCageIds = staffEnrollments.Where(e => e.CageId != null)
                                                   .Select(e => e.CageId)
                                                   .Distinct()
                                                   .ToList();

            foreach (var cageId in distinctCageIds)
            {
                var cageEnrollments = staffEnrollments.Where(e => e.CageId == cageId).ToList();
                var classIds = cageEnrollments.Select(e => e.ClassId).ToList();
                var classSlots = new List<Slot>();

                foreach (var classId in classIds)
                {
                    var slots = await _unitOfWork.Slots.GetClassSlots(classId);
                    classSlots.AddRange(slots);
                }

                var slotsByDate = classSlots
                                    .GroupBy(s => s.Date)
                                    .ToDictionary(i => i.Key, i => i.Select(s => s.ScheduleId).ToList());

                var cage = await _unitOfWork.Cages.GetCageById(cageId);
                var enrollment = cageEnrollments.First();
                var dog = await _unitOfWork.Dogs.GetDogById(enrollment.DogId);

                var cageSlots = new List<CageSlotDTO>();

                var slotDates = classSlots.Select(s => s.Date).Distinct().ToList();

                foreach (var date in slotDates)
                {
                    var occupiedSchedules = slotsByDate.ContainsKey(date) ? slotsByDate[date] : new List<string>();

                    var freeSchedules = schedules
                                            .Where(s => !occupiedSchedules.Contains(s.Id))
                                            .ToList();

                    foreach (var freeSchedule in freeSchedules)
                    {
                        cageSlots.Add(new CageSlotDTO
                        {
                            SlotDate = date,
                            StartTime = freeSchedule.StartTime,
                            EndTime = freeSchedule.EndTime
                        });
                    }
                }

                staffCageResponse.Add(new GetStaffCageResponse
                {
                    CageId = cage.Id,
                    Number = cage.Number,
                    Location = cage.Location,
                    CategoryId = cage.CageCategoryId,
                    CategoryName = cage.CageCategory.Name,
                    DogId = dog.Id,
                    DogName = dog.Name,
                    DogBreedId = dog.DogBreedId,
                    DogBreedName = dog.DogBreed.Name,
                    CageSlots = cageSlots
                });
            }

            return new BaseResponseDTO<GetStaffCageResponse> { Success = true, ObjectList = staffCageResponse };
        }
    }
}
