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
    public class DogDocumentTypeService : IDogDocumentTypeService
    {
        private readonly IUnitOfWork _unitOfWork ;
        public DogDocumentTypeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork ;
        }

        public async Task<List<DogDocumentType>> GetAllDocumentType()
        {
            var result = await _unitOfWork.DogDocumentTypes.GetAll();
            return result;
        }
    }
}
