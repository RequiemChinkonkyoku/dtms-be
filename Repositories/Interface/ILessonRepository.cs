﻿using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interface
{
    public interface ILessonRepository : IRepositoryBase<Lesson>
    {
        Task<List<Lesson>> GetAllLessons();
        Task<Lesson> GetLessonByIdAsync(string id);
    }
}
