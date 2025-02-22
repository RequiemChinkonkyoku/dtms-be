using Azure.Core;
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
    public class SkillService : ISkillService
    {
        private readonly IUnitOfWork _unitOfWork;

        public SkillService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<BaseResponseDTO<Skill>> GetAllSkills()
        {
            var response = await _unitOfWork.Skills.GetAll();

            return new BaseResponseDTO<Skill> { Success = true, ObjectList = response };
        }

        public async Task<BaseResponseDTO<Skill>> GetSkillById(string id)
        {
            var skill = await _unitOfWork.Skills.GetById(id);

            if (skill == null)
            {
                return new BaseResponseDTO<Skill> { Success = false, Message = "Unable to find skill with id " + id };
            }

            return new BaseResponseDTO<Skill> { Success = true, Object = skill };
        }

        public async Task<BaseResponseDTO<Skill>> CreateSkill(CreateSkillRequest request)
        {
            var skill = new Skill()
            {
                Name = request.Name,
                Description = request.Description,
                CreatedTime = DateTime.Now,
                LastUpdatedTime = DateTime.Now
            };

            await _unitOfWork.Skills.Add(skill);
            await _unitOfWork.SaveChanges();

            return new BaseResponseDTO<Skill> { Success = true, Object = skill };
        }

        public async Task<BaseResponseDTO<Skill>> UpdateSkill(UpdateSkillRequest request)
        {
            if (request.Id.IsNullOrEmpty())
            {
                return new BaseResponseDTO<Skill> { Success = false, Message = "Id must be given." };
            }

            var skill = await _unitOfWork.Skills.GetById(request.Id);

            if (skill == null)
            {
                return new BaseResponseDTO<Skill> { Success = false, Message = "Unable to find skill with id " + request.Id };
            }

            skill.Name = request.Name;
            skill.Description = request.Description;
            skill.Status = request.Status;
            skill.LastUpdatedTime = DateTime.Now;

            await _unitOfWork.Skills.Update(skill);
            await _unitOfWork.SaveChanges();

            return new BaseResponseDTO<Skill> { Success = true, Object = skill };
        }

        public async Task<BaseResponseDTO<Skill>> DeleteSkill(string id)
        {
            var skill = await _unitOfWork.Skills.GetById(id);

            if (skill == null)
            {
                return new BaseResponseDTO<Skill> { Success = false, Message = "Unable to find skill with id " + id };
            }

            skill.Status = 0;

            await _unitOfWork.Skills.Update(skill);
            await _unitOfWork.SaveChanges();

            return new BaseResponseDTO<Skill> { Success = false, Object = skill };
        }
    }
}