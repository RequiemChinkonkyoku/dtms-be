using Microsoft.EntityFrameworkCore.Metadata.Conventions;
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
    public class CertificateService : ICertificateService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CertificateService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<BaseResponseDTO<Certificate>> GetAllCertificates()
        {
            var response = await _unitOfWork.Certificates.GetAll();

            return new BaseResponseDTO<Certificate> { Success = true, ObjectList = response };
        }
    }
}
