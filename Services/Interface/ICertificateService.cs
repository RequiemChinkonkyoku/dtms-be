using Models.DTOs;
using Models.DTOs.Certificate.Request;
using Models.DTOs.Certificate.Response;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interface
{
    public interface ICertificateService
    {
        Task<BaseResponseDTO<Certificate>> GetAllCertificates();
        Task<CertificateResponse> GetCertificateById(string id);

        Task<string> CreateCertificateAsync(CreateCertificateRequest request);

        Task<string> UpdateCertificateAsync(string certificateId, UpdateCertificateRequest request);
    }
}
