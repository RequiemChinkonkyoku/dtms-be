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
    public class SlotService : ISlotService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public SlotService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<List<GetSlotByClassResponse>> GetSlotsByClassAndDog(string classId, string dogId)
        {
            var classExists = await _unitOfWork.Classes.GetById(classId);
            if (classExists == null)
            {
                throw new KeyNotFoundException($"Class with ID {classId} not found.");
            }

            var dogExists = await _unitOfWork.Dogs.GetById(dogId);
            if (dogExists == null)
            {
                throw new KeyNotFoundException($"Dog with ID {dogId} not found.");
            }

            var result = await _unitOfWork.Slots.GetSlotsByClassAndDog(classId, dogId);
            return _mapper.Map<List<GetSlotByClassResponse>>(result);
        }

    }
}
