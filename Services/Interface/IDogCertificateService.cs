using Models.DTOs.DogCertificate.Request;
using Models.DTOs.DogCertificate.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interface
{
    public interface IDogCertificateService
    {
        Task<List<DogCertificateResponse>> GetAllDogCertificates();
        Task<DogCertificateResponse> GetByIdWithDetailAsync(string id);
        Task<string> CreateDogCertificateAsync(CreateDogCertificateRequest request);

        Task<string> UpdateDogCertificateAsync(string dogCertificateId, UpdateDogCertificateRequest request);
    }
}
