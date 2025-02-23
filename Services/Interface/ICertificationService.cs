using Models.DTOs;
using Models.DTOs.Certification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interface
{
    public interface ICertificationService
    {
        Task<BaseResponseDTO<CertificationResponse>> GetAllCertifications();
        Task<BaseResponseDTO<CertificationResponse>> GetCertificationsById(string id);
        Task<BaseResponseDTO<CertificationResponse>> GetCertificationsByName(string name);
        Task<BaseResponseDTO<CertificationResponse>> CreateCertificationsAsync(CreateCertificationRequest createCertificationRequest);
        Task<BaseResponseDTO<CertificationResponse>> UpdateCertificationsAsync(string id, CreateCertificationRequest request);
        Task<bool> DeleteCertificationsAsync(string id);
    }
}
