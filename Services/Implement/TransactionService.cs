using AutoMapper;
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

        public async Task<TransactionResponse> GetTransactionByEnrollmentId(string enrollmentId)
        {
            var transaction = await _unitOfWork.Transactions.GetSingle(
                t => t.EnrollmentId == enrollmentId,
                t => t.Enrollment,
                t => t.Enrollment.Dog,
                t => t.Enrollment.Class,
                t => t.Enrollment.Class.Course
            );

            if (transaction == null)
            {
                throw new KeyNotFoundException($"Transaction not found for EnrollmentId {enrollmentId}");
            }

            var transactionResponse = _mapper.Map<TransactionResponse>(transaction);

            return transactionResponse;
        }

    }
}
