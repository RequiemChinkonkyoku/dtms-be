using Models.DTOs;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interface
{
    public interface ISkillService
    {
        Task<BaseResponseDTO<Skill>> CreateSkill(CreateSkillRequest request);
        Task<BaseResponseDTO<Skill>> GetAllSkills();
        Task<BaseResponseDTO<Skill>> UpdateSkill(UpdateSkillRequest request);
    }
}
