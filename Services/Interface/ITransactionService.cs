using Models.DTOs;
using Models.DTOs.Transaction.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interface
{
    public interface ITransactionService
    {
        Task<List<TransactionResponse>> GetTransactionByEnrollmentId(string enrollmentId);
        Task<List<TransactionResponse>> GetTransactionByAccountId(string accountId);
        Task<BaseResponseDTO<TransactionResponse>> GetAllTransactions();
    }
}
