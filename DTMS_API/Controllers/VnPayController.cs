﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Models.DTOs.VnPay;
using Services.Interface;

namespace DTMS_API.Controllers
{
    [ApiController]
    [Route("api/vnpay")]
    public class VnPayController : ControllerBase
    {
        private readonly IVnPayService _vpnPayService;

        public VnPayController(IVnPayService vnPayService)
        {
            _vpnPayService = vnPayService;
        }

        [HttpPost]
        public async Task<IActionResult> CreatePaymentUrl([FromBody] VnpayInfoModel request)
        {
            var url = await _vpnPayService.CreatePaymentUrl(request, HttpContext);

            if (!url.IsNullOrEmpty())
            {
                return Ok(url);
            }
            else
            {
                return BadRequest("There has been a problem creating payment url.");
            }
        }

        [HttpGet("payment-callback")]
        public async Task<IActionResult> PaymentCallBack()
        {
            var query = Request.Query;

            if (query == null || query.IsNullOrEmpty())
            {
                return BadRequest("The response query is empty.");
            }

            var response = await _vpnPayService.PaymentExecute(query);

            if (response.Success)
            {
                return Ok(response);
            }
            else
            {
                return BadRequest(response);
            }
        }
    }
}
