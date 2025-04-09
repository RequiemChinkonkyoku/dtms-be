using AutoMapper;
using Microsoft.Extensions.Logging.EventSource;
using Microsoft.IdentityModel.Tokens;
using Microsoft.VisualBasic;
using Models.DTOs;
using Models.Entities;
using Repositories.Interface;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Services.Implement
{
    public class LessonService : ILessonService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public LessonService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<BaseResponseDTO<Lesson>> GetAllLessons()
        {
            var response = await _unitOfWork.Lessons.GetAll();

            return new BaseResponseDTO<Lesson> { Success = true, ObjectList = response };
        }

        public async Task<BaseResponseDTO<Lesson>> GetLessonById(string id)
        {
            var lesson = await _unitOfWork.Lessons.GetById(id);

            if (lesson == null)
            {
                return new BaseResponseDTO<Lesson> { Success = false, Message = "Unable to find lesson with id " + id };
            }

            return new BaseResponseDTO<Lesson> { Success = true, Object = lesson };
        }

        public async Task<BaseResponseDTO<Lesson>> CreateLesson(CreateLessonRequest request)
        {
            if (request.SkillId.IsNullOrEmpty())
            {
                return new BaseResponseDTO<Lesson> { Success = false, Message = "SkillId must be given." };
            }

            var skill = await _unitOfWork.Skills.GetById(request.SkillId);

            if (skill == null)
            {
                return new BaseResponseDTO<Lesson> { Success = false, Message = "Unable to find skill with id " + request.SkillId };
            }

            var lesson = new Lesson
            {
                LessonTitle = request.LessonTitle,
                Description = request.Description,
                Notes = request.Note,
                Environment = request.Environment,
                Duration = request.Duration,
                Objective = request.Objective,
                SkillId = skill.Id,
                CreatedTime = DateTime.Now,
                LastUpdatedTime = DateTime.Now,
            };

            await _unitOfWork.Lessons.Add(lesson);
            await _unitOfWork.SaveChanges();

            if (request.LessonEquipmentDTOs.Any())
            {
                foreach (var lessonEquipment in request.LessonEquipmentDTOs)
                {
                    var equip = await _unitOfWork.Equipments.GetById(lessonEquipment.EquipmentId);

                    if (equip == null)
                    {
                        return new BaseResponseDTO<Lesson>
                        {
                            Success = false,
                            Message = $"Unable to find equipment with id {lessonEquipment.EquipmentId}"
                        };
                    }

                    var lessonEquip = new LessonEquipment
                    {
                        LessonId = lesson.Id,
                        EquipmentId = equip.Id,
                        Quantity = lessonEquipment.Quantity
                    };

                    try
                    {
                        await _unitOfWork.LessonEquipments.Add(lessonEquip);
                        await _unitOfWork.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        return new BaseResponseDTO<Lesson>
                        {
                            Success = false,
                            Message = $"There has been an error creating lessonEquipment. Ex: {ex.Message}."
                        };
                    }
                }
            }

            await _unitOfWork.SaveChanges();

            return new BaseResponseDTO<Lesson> { Success = true, Object = lesson };
        }

        public async Task<BaseResponseDTO<Lesson>> UpdateLesson(UpdateLessonRequest request)
        {
            if (request.Id.IsNullOrEmpty())
            {
                return new BaseResponseDTO<Lesson> { Success = false, Message = "Id must be given." };
            }

            var lesson = await _unitOfWork.Lessons.GetById(request.Id);

            if (lesson == null)
            {
                return new BaseResponseDTO<Lesson> { Success = false, Message = "Unable to find lesson with id " + request.Id };
            }

            var skill = await _unitOfWork.Skills.GetById(request.SkillId);

            if (skill == null)
            {
                return new BaseResponseDTO<Lesson> { Success = false, Message = "Unable to find skill with id " + request.SkillId };
            }

            lesson.LessonTitle = request.LessonTitle;
            lesson.Description = request.Description;
            lesson.Notes = request.Note;
            lesson.Environment = request.Environment;
            lesson.Duration = request.Duration;
            lesson.Objective = request.Objective;
            lesson.SkillId = request.SkillId;
            lesson.Status = request.Status;
            lesson.LastUpdatedTime = DateTime.Now;

            await _unitOfWork.Lessons.Update(lesson);
            await _unitOfWork.SaveChanges();

            //var currentEquipmentIds = (await _unitOfWork.LessonEquipments.GetAll())
            //                                    .Where(le => le.LessonId == lesson.Id)
            //                                    .Select(le => le.EquipmentId)
            //                                    .ToList();

            //var equipmentIdsToAdd = request.EquipmentIds.Except(currentEquipmentIds).ToList();
            //var equipmentIdsToRemove = currentEquipmentIds.Except(request.EquipmentIds).ToList();

            var currentEquipments = (await _unitOfWork.LessonEquipments.GetAll())
                                                .Where(le => le.LessonId == lesson.Id)
                                                .ToList();

            var requestEquipments = request.LessonEquipmentDTOs.ToList();

            var currentEquipmentsDict = currentEquipments.ToDictionary(le => le.EquipmentId, le => le);
            var requestEquipmentsDict = requestEquipments.ToDictionary(le => le.EquipmentId, le => le);

            var equipmentToAdd = requestEquipments
                                    .Where(le => !currentEquipmentsDict.ContainsKey(le.EquipmentId))
                                    .ToList();

            var equipmentToRemove = currentEquipments
                                        .Where(le => !requestEquipmentsDict.ContainsKey(le.EquipmentId))
                                        .ToList();

            var equipmentToUpdate = currentEquipments
                                        .Where(le => requestEquipmentsDict.ContainsKey(le.EquipmentId) &&
                                                     le.Quantity != requestEquipmentsDict[le.EquipmentId].Quantity)
                                        .ToList();


            if (equipmentToAdd.Any())
            {
                foreach (var equipDto in equipmentToAdd)
                {
                    var newLessonEquip = new LessonEquipment
                    {
                        LessonId = lesson.Id,
                        EquipmentId = equipDto.EquipmentId,
                        Quantity = equipDto.Quantity,
                    };

                    await _unitOfWork.LessonEquipments.Add(newLessonEquip);
                }

                await _unitOfWork.SaveChanges();
            }

            if (equipmentToRemove.Any())
            {
                foreach (var equipDto in equipmentToRemove)
                {
                    await _unitOfWork.LessonEquipments.Delete(equipDto);
                }

                await _unitOfWork.SaveChanges();
            }

            if (equipmentToUpdate.Any())
            {
                foreach (var lessonEquip in equipmentToUpdate)
                {
                    lessonEquip.Quantity = requestEquipmentsDict[lessonEquip.EquipmentId].Quantity;

                    await _unitOfWork.LessonEquipments.Update(lessonEquip);
                }

                await _unitOfWork.SaveChanges();
            }

            return new BaseResponseDTO<Lesson> { Success = true, Object = lesson };
        }

        public async Task<BaseResponseDTO<Lesson>> DeleteLesson(string id)
        {
            var lesson = await _unitOfWork.Lessons.GetById(id);

            if (lesson == null)
            {
                return new BaseResponseDTO<Lesson> { Success = false, Message = "Unable to find lesson with id " + id };
            }

            lesson.Status = 0;
            lesson.LastUpdatedTime = DateTime.UtcNow;
            lesson.LastUpdatedTime = DateTime.UtcNow;

            await _unitOfWork.Lessons.Update(lesson);
            await _unitOfWork.SaveChanges();

            return new BaseResponseDTO<Lesson> { Success = true, Object = lesson };
        }
    }
}
