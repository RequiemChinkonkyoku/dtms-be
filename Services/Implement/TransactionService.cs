using AutoMapper;
using Models.DTOs;
using Models.DTOs.Transaction.Response;
using Repositories.Interface;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Implement
{
    public class TransactionService : ITransactionService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public TransactionService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<TransactionResponse>> GetTransactionByEnrollmentId(string enrollmentId)
        {
            var transactions = await _unitOfWork.Transactions.GetTransactionByEnrollmentId(enrollmentId);
            return _mapper.Map<List<TransactionResponse>>(transactions);
        }


        public async Task<List<TransactionResponse>> GetTransactionByAccountId(string accountId)
        {
            var transactions = await _unitOfWork.Transactions.GetTransactionByAccountId(accountId);
            return _mapper.Map<List<TransactionResponse>>(transactions);
        }

        public async Task<BaseResponseDTO<TransactionResponse>> GetAllTransactions()
        {
            var transactions = await _unitOfWork.Transaction.GetAllTransaction();

            var mappedResponse = _mapper.Map<List<TransactionResponse>>(transactions);

            return new BaseResponseDTO<TransactionResponse> { Success = true, ObjectList = mappedResponse };
        }
    }
}
