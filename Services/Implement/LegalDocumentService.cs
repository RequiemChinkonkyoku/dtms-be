using AutoMapper;
using Models.DTOs;
using Models.DTOs.Certification;
using Models.DTOs.LegalDocument;
using Models.DTOs.TrainerReport;
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
    public class LegalDocumentService : ILegalDocumentService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public LegalDocumentService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<BaseResponseDTO<LegalDocumentResponse>> GetAllLegalDocuments()
        {
            var result = await _unitOfWork.LegalDocuments.GetAll();
            var response = _mapper.Map<List<LegalDocumentResponse>>(result);
            return new BaseResponseDTO<LegalDocumentResponse> { Success = true, ObjectList = response };
        }

        public async Task<BaseResponseDTO<LegalDocumentResponse>> GetLegalDocumentById(string id)
        {
            var result = await _unitOfWork.LegalDocuments.GetById(id);

            if (result == null)
            {
                return new BaseResponseDTO<LegalDocumentResponse> { Success = false, Message = "Unable to find legal document with id " + id };
            }

            var response = _mapper.Map<LegalDocumentResponse>(result);
            return new BaseResponseDTO<LegalDocumentResponse> { Success = true, Object = response };

        }

        public async Task<BaseResponseDTO<LegalDocumentResponse>> CreateLegalDocumentAsync(CreateLegalDocumentRequest createLegalDocumentRequest)
        {
            if (string.IsNullOrWhiteSpace(createLegalDocumentRequest.CustomerProfileId))
            {
                throw new ArgumentException("CustomerProfileId are required.");
            }

            var customerProfileId = await _unitOfWork.CustomerProfiles.GetById(createLegalDocumentRequest.CustomerProfileId);

            if (customerProfileId == null)
            {
                throw new KeyNotFoundException("CustomerProfileId is not valid.");
            }

            var legalDocument = _mapper.Map<LegalDocument>(createLegalDocumentRequest);

            legalDocument.UploadTime = DateTime.UtcNow;
            legalDocument.Status = 1;

            await _unitOfWork.LegalDocuments.Add(legalDocument);
            await _unitOfWork.SaveChanges();

            var response = _mapper.Map<LegalDocumentResponse>(legalDocument);
            return new BaseResponseDTO<LegalDocumentResponse> { Success = true, Object = response };
        }

        public async Task<BaseResponseDTO<LegalDocumentResponse>> UpdateLegalDocumentAsync(string id, CreateLegalDocumentRequest request)
        {
            var existingLegalDocument = await _unitOfWork.LegalDocuments.GetById(id);

            if (existingLegalDocument == null)
            {
                throw new KeyNotFoundException($"LegalDocument not found.");
            }

            if (string.IsNullOrWhiteSpace(request.CustomerProfileId))
            {
                throw new ArgumentException("CustomerProfileId are required.");
            }

            var customerProfileId = await _unitOfWork.CustomerProfiles.GetById(request.CustomerProfileId);

            if (customerProfileId == null)
            {
                throw new KeyNotFoundException("CustomerProfileId is not valid.");
            }

            _mapper.Map(request, existingLegalDocument);

            existingLegalDocument.LastUpdatedTime = DateTime.UtcNow;

            _unitOfWork.LegalDocuments.Update(existingLegalDocument);
            await _unitOfWork.SaveChanges();

            var response = _mapper.Map<LegalDocumentResponse>(existingLegalDocument);
            return new BaseResponseDTO<LegalDocumentResponse> { Success = true, Object = response };
        }

        public async Task<bool> DeleteLegalDocumentAsync(string id)
        {
            var existingLegalDocument = await _unitOfWork.LegalDocuments.GetById(id);

            if (existingLegalDocument == null)
            {
                throw new KeyNotFoundException($"LegalDocument not found.");
            }

            _unitOfWork.LegalDocuments.Delete(existingLegalDocument);
            await _unitOfWork.SaveChanges();

            return true;
        }
    }
}
