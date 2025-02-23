using AutoMapper;
using Models.DTOs.Response;
using Repositories.Interface;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Implement
{
    public class DogOwnershipsService : IDogOwnershipsService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DogOwnershipsService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<DogOwnershipResponse>> GetAllDogOwnerships()
        {
            var result = await _unitOfWork.DogOwnerships.GetAllDogOwnerships();
            return _mapper.Map<List<DogOwnershipResponse>>(result);
        }
    }
}
