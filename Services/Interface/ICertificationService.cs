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
        Task<List<CertificationResponse>> GetAllCertifications();
        Task<CertificationResponse> GetCertificationsById(string id);
        Task<List<CertificationResponse>> GetCertificationsByName(string name);
        Task<CertificationResponse> CreateCertificationsAsync(CreateCertificationRequest createCertificationRequest);
        Task<CertificationResponse> UpdateCertificationsAsync(string id, CreateCertificationRequest request);
        Task<bool> DeleteCertificationsAsync(string id);
    }
}
