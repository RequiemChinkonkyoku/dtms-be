﻿using Models.DTOs;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interface
{
    public interface IPrerequisiteService
    {
        Task<BaseResponseDTO<Prerequisite>> CreatePrerequisite(CreatePrerequisiteRequest request);
        Task<BaseResponseDTO<Prerequisite>> DeletePrerequisite(List<string> request);
        Task<BaseResponseDTO<Prerequisite>> GetAllPrerequisites();
        Task<BaseResponseDTO<Prerequisite>> GetPrerequisitesByCourseId(string id);
        Task<BaseResponseDTO<Prerequisite>> UpdatePrerequisite(string id, UpdatePrerequisiteRequest request);
    }
}
