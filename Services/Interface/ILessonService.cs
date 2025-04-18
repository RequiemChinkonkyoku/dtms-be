﻿using Models.DTOs;
using Models.DTOs.Lesson.Request;
using Models.DTOs.Lesson.Response;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interface
{
    public interface ILessonService
    {
        Task<BaseResponseDTO<Lesson>> CreateLesson(CreateLessonRequest request);
        Task<BaseResponseDTO<Lesson>> DeleteLesson(string id);
        Task<BaseResponseDTO<Lesson>> GetAllLessons();
        Task<BaseResponseDTO<GetLessonResponse>> GetLessonById(string id);
        Task<BaseResponseDTO<Lesson>> UpdateLesson(UpdateLessonRequest request);
    }
}
