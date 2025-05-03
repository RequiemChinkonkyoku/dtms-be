using AutoMapper;
using Models.Constants;
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
        public async Task<BaseResponseDTO<LegalDocumentResponse>> GetLegalDocumentsByCustomerId(string customerId)
        {
            if (string.IsNullOrWhiteSpace(customerId))
            {
                return new BaseResponseDTO<LegalDocumentResponse>
                {
                    Success = false,
                    Message = "Customer ID is required."
                };
            }

            var customer = await _unitOfWork.Accounts.GetById(customerId);
            if (customer == null)
            {
                return new BaseResponseDTO<LegalDocumentResponse>
                {
                    Success = false,
                    Message = "Customer not found."
                };
            }

            var documents = await _unitOfWork.LegalDocuments.GetDocumentsByCustomerId(customerId);

            var response = _mapper.Map<List<LegalDocumentResponse>>(documents);

            return new BaseResponseDTO<LegalDocumentResponse>
            {
                Success = true,
                ObjectList = response
            };
        }

        public async Task<BaseResponseDTO<LegalDocumentResponse>> CreateLegalDocumentAsync(CreateLegalDocumentRequest createLegalDocumentRequest)
        {
            if (string.IsNullOrWhiteSpace(createLegalDocumentRequest.CustomerProfileId))
            {
                throw new ArgumentException("CustomerProfileId are required.");
            }

            var customerProfileId = await _unitOfWork.Accounts.GetById(createLegalDocumentRequest.CustomerProfileId);

            if (customerProfileId == null)
            {
                throw new KeyNotFoundException("CustomerProfileId is not valid.");
            }

            var customerRole = await _unitOfWork.Roles.GetById(customerProfileId.RoleId);
            if (customerRole == null)
            {
                throw new KeyNotFoundException("CustomerProfileId is not valid.");
            }
            if (customerRole.Name != "Customer_Individual" && customerRole.Name != "Customer_Organizational")
            {
                throw new ArgumentException("CustomerProfileId is not a customer.");
            }

            var legalDocument = _mapper.Map<LegalDocument>(createLegalDocumentRequest);

            legalDocument.UploadTime = DateTime.UtcNow;
            legalDocument.Status = (int)LegalDocumentStatusEnum.Pending;
            legalDocument.CustomerId = createLegalDocumentRequest.CustomerProfileId;

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

            var customerProfileId = await _unitOfWork.Accounts.GetById(request.CustomerProfileId);

            if (customerProfileId == null)
            {
                throw new KeyNotFoundException("CustomerProfileId is not valid.");
            }

            var customerRole = await _unitOfWork.Roles.GetById(customerProfileId.RoleId);
            if (customerRole == null)
            {
                throw new KeyNotFoundException("CustomerProfileId is not valid.");
            }
            if (customerRole.Name != "Customer_Individual" && customerRole.Name != "Customer_Organizational")
            {
                throw new ArgumentException("CustomerProfileId is not a customer.");
            }

            _mapper.Map(request, existingLegalDocument);

            existingLegalDocument.LastUpdatedTime = DateTime.UtcNow;
            existingLegalDocument.CustomerId = request.CustomerProfileId;

            _unitOfWork.LegalDocuments.Update(existingLegalDocument);
            await _unitOfWork.SaveChanges();

            var response = _mapper.Map<LegalDocumentResponse>(existingLegalDocument);
            return new BaseResponseDTO<LegalDocumentResponse> { Success = true, Object = response };
        }

        public async Task<BaseResponseDTO<LegalDocumentResponse>> LegalDocumentAprovalAsync(string id, UpdateLegalDocumentRequest request)
        {
            var existingLegalDocument = await _unitOfWork.LegalDocuments.GetById(id);

            if (existingLegalDocument == null)
            {
                return new BaseResponseDTO<LegalDocumentResponse>
                {
                    Success = false,
                    Message = $"Legal document with id {id} not found."
                };
            }

            existingLegalDocument.Description = request.Description;
            existingLegalDocument.Status = request.Status;
            existingLegalDocument.LastUpdatedTime = DateTime.UtcNow;

            _unitOfWork.LegalDocuments.Update(existingLegalDocument);
            await _unitOfWork.SaveChanges();

            var response = _mapper.Map<LegalDocumentResponse>(existingLegalDocument);
            return new BaseResponseDTO<LegalDocumentResponse>
            {
                Success = true,
                Object = response
            };
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
