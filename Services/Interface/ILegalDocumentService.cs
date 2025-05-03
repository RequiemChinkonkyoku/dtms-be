using Models.DTOs;
using Models.DTOs.LegalDocument;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interface
{
    public interface ILegalDocumentService
    {
        Task<BaseResponseDTO<LegalDocumentResponse>> GetAllLegalDocuments();
        Task<BaseResponseDTO<LegalDocumentResponse>> GetLegalDocumentById(string id);
        Task<BaseResponseDTO<LegalDocumentResponse>> GetLegalDocumentsByCustomerId(string customerId);
        Task<BaseResponseDTO<LegalDocumentResponse>> CreateLegalDocumentAsync(CreateLegalDocumentRequest createLegalDocumentRequest);
        Task<BaseResponseDTO<LegalDocumentResponse>> UpdateLegalDocumentAsync(string id, CreateLegalDocumentRequest request);
        Task<BaseResponseDTO<LegalDocumentResponse>> LegalDocumentAprovalAsync(string id, UpdateLegalDocumentRequest request);
        Task<bool> DeleteLegalDocumentAsync(string id);
    }
}
