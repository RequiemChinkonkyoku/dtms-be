using AutoMapper;
using Models.Constants;
using Models.DTOs;
using Models.DTOs.Response;
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
    public class AttendanceService : IAttendanceService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public AttendanceService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<AttendanceResponse>> GetAllAttendanceAsync()
        {
            var attendances = await _unitOfWork.Attendances.GetAllAttendancesAsync();
            return _mapper.Map<List<AttendanceResponse>>(attendances);
        }

        public async Task<AttendanceResponse> GetAttendanceByIdAsync(string id)
        {
            var attendance = await _unitOfWork.Attendances.GetAttendnceByIdAsync(id);

            if (attendance == null)
            {
                return null;
            }

            return _mapper.Map<AttendanceResponse>(attendance);
        }

        public async Task<string> CreateAttendanceAsync(CreateAttendanceRequest request)
        {
            var slot = await _unitOfWork.Slots.GetById(request.SlotId);
            if (slot == null)
            {
                throw new ArgumentException($"Slot with ID {request.SlotId} not found.");
            }

            var dog = await _unitOfWork.Dogs.GetById(request.DogId);
            if (dog == null)
            {
                throw new ArgumentException($"Dog with ID {request.DogId} not found.");
            }

            var newAttendance = new Attendance
            {
                Id = Guid.NewGuid().ToString(),
                Date = request.Date,
                Status = (int)AttendanceStatusEnum.CheckedIn,
                SlotId = request.SlotId,
                DogId = request.DogId,
                CreatedTime = DateTime.UtcNow,
                LastUpdatedTime = DateTime.UtcNow
            };

            try
            {
                await _unitOfWork.Attendances.Add(newAttendance);
                await _unitOfWork.SaveChanges();
            }
            catch (Exception ex)
            {
                return $"There has been an error creating attendance. Ex: {ex.Message}.";
            }

            return "Attendance created successfully.";
        }

        public async Task<string> UpdateAttendanceAsync(string id, UpdateAttendanceRequest request)
        {
            var attendance = await _unitOfWork.Attendances.GetById(id);
            if (attendance == null)
            {
                throw new ArgumentException($"Attendance with ID {id} not found.");
            }

            attendance.Date = request.Date;
            attendance.SlotId = request.SlotId;
            attendance.DogId = request.DogId;

            attendance.LastUpdatedTime = DateTime.UtcNow;
            _unitOfWork.Attendances.Update(attendance);
            await _unitOfWork.SaveChanges();

            return "Attendance updated successfully.";
        }

        public async Task<BaseResponseDTO<Attendance>> CheckoutAttendance(string id)
        {
            var attendance = await _unitOfWork.Attendances.GetById(id);

            if (attendance == null)
            {
                return new BaseResponseDTO<Attendance>
                {
                    Success = false,
                    Message = $"Unable to find attendance with id {id}."
                };
            }

            if (attendance.Status != (int)AttendanceStatusEnum.CheckedIn)
            {
                return new BaseResponseDTO<Attendance>
                {
                    Success = false,
                    Message = $"Invalid attendance status."
                };
            }

            attendance.Status = (int)AttendanceStatusEnum.CheckedOut;

            try
            {
                await _unitOfWork.Attendances.Update(attendance);
                await _unitOfWork.SaveChanges();
            }
            catch (Exception ex)
            {
                return new BaseResponseDTO<Attendance>
                {
                    Success = false,
                    Message = $"There has been an error updating attendance."
                };
            }

            return new BaseResponseDTO<Attendance> { Success = true, Object = attendance };
        }
    }
}
