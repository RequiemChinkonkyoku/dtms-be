using Microsoft.AspNetCore.Http;
using Models.DTOs;
using Models.DTOs.VnPay;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interface
{
    public interface IVnPayService
    {
        public Task<string> CreatePaymentUrl(VnpayInfoModel request, HttpContext context);

        public Task<BaseResponseDTO<VnpayResponseModel>> PaymentExecute(IQueryCollection collections);
    }
}
