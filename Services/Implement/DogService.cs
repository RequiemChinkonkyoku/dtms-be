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
    public class DogService : IDogService
    {
        private readonly IUnitOfWork _unitOfWork;

        public DogService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<Dog>> GetAllDogs()
        {
            var result = await _unitOfWork.Dogs.GetAll();
            return result;
        }

        public async Task<Dog> GetDogById(string id)
        {
            var result = await _unitOfWork.Dogs.GetById(id);
            return result;
        }

    }
}
