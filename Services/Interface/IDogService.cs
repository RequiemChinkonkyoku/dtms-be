﻿using Models.DTOs;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interface
{
    public interface IDogService
    {
        Task<List<Dog>> GetAllDogs();
        Task<Dog> GetDogById(string id);
        Task<Dog> CreateDogAsync(CreateDogRequest createDogRequest);
        Task<Dog> UpdateDogAsync(string id, UpdateDogRequest request);
        Task<Dog> DeleteDogAsync(string id);
    }
}
