using AutoMapper;
using Models.DTOs.DogCertificate.Request;
using Models.DTOs.DogCertificate.Response;
using Models.Entities;
using Repositories.Implement;
using Repositories.Interface;
using Repositories.SeedingData;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Implement
{
    public class DogCertificateService : IDogCertificateService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DogCertificateService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<DogCertificateResponse>> GetAllDogCertificates()
        {
            var dogCertificates = await _unitOfWork.DogCertificates.GetAllWithDetailsAsync();
            return _mapper.Map<List<DogCertificateResponse>>(dogCertificates);
        }

        public async Task<DogCertificateResponse> GetByIdWithDetailAsync(string id)
        {
            var dogCertificate = await _unitOfWork.DogCertificates.GetByIdWithDetailAsync(id);

            if (dogCertificate == null)
            {
                throw new KeyNotFoundException($"DogCertificate with ID {id} not found.");
            }

            return _mapper.Map<DogCertificateResponse>(dogCertificate);
        }

        public async Task<string> CreateDogCertificateAsync(CreateDogCertificateRequest request)
        {
            var dog = await _unitOfWork.Dogs.GetById(request.DogId);
            if (dog == null)
                throw new KeyNotFoundException($"Dog with ID {request.DogId} not found");

            var certificate = await _unitOfWork.Certificates.GetById(request.CertificateId);
            if (certificate == null)
                throw new KeyNotFoundException($"Certificate with ID {request.CertificateId} not found");

            var exists = await _unitOfWork.DogCertificates.AnyAsync(dc =>
                dc.DogId == request.DogId &&
                dc.CertificateId == request.CertificateId);
            if (exists)
                throw new InvalidOperationException("This dog already has this certificate");


            if (exists)
                throw new InvalidOperationException("This dog already has this certificate");

            var newDogCertificate = new DogCertificate
            {
                Id = Guid.NewGuid().ToString(),
                DogId = request.DogId,
                CertificateId = request.CertificateId,
                CreatedTime = DateTime.UtcNow,
                LastUpdatedTime = DateTime.UtcNow
            };

            await _unitOfWork.DogCertificates.Add(newDogCertificate);
            await _unitOfWork.SaveChanges();

            return $"Successfully assigned certificate '{certificate.Name}' to dog '{dog.Name}'";
        }

        public async Task<string> UpdateDogCertificateAsync(string dogCertificateId, UpdateDogCertificateRequest request)
        {
            var existing = await _unitOfWork.DogCertificates
                .GetByIdWithDetailAsync(dogCertificateId);

            if (existing == null)
                throw new KeyNotFoundException("Dog-Certificate assignment not found");

            var certificate = await _unitOfWork.Certificates.GetById(request.CertificateId);
            if (certificate == null)
                throw new KeyNotFoundException($"Certificate with ID {request.CertificateId} not found");

            var alreadyExists = await _unitOfWork.DogCertificates
                .AnyAsync(dc => dc.DogId == existing.DogId &&
                                dc.CertificateId == request.CertificateId &&
                                dc.Id != dogCertificateId); 

            if (alreadyExists)
                throw new InvalidOperationException("This dog already has the new certificate");

            existing.DogId = request.DogId;
            existing.CertificateId = request.CertificateId;
            existing.LastUpdatedTime = DateTime.UtcNow;

            await _unitOfWork.DogCertificates.Update(existing);
            await _unitOfWork.SaveChanges();

            var dog = await _unitOfWork.Dogs.GetById(existing.DogId);
            return $"Successfully updated certificate" ;
        }

    }
}
