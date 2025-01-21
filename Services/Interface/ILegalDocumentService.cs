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
        Task<List<LegalDocumentResponse>> GetAllLegalDocuments();
        Task<LegalDocumentResponse> GetLegalDocumentById(string id);
        Task<LegalDocumentResponse> CreateLegalDocumentAsync(CreateLegalDocumentRequest createLegalDocumentRequest);
        Task<LegalDocumentResponse> UpdateLegalDocumentAsync(string id, CreateLegalDocumentRequest request);
        Task<bool> DeleteLegalDocumentAsync(string id);
    }
}
