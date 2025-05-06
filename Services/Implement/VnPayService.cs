using Azure;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Identity.Client;
using Models.Constants;
using Models.DTOs;
using Models.DTOs.VnPay;
using Models.Entities;
using Repositories.Interface;
using Repositories.Library;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Implement
{
    public class VnPayService : IVnPayService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IConfiguration _configuration;
        private readonly IMembershipService _membershipService;

        public VnPayService(IUnitOfWork unitOfWork, IConfiguration configuration, IMembershipService membershipService)
        {
            _unitOfWork = unitOfWork;
            _configuration = configuration;
            _membershipService = membershipService;
        }

        public async Task<string> CreatePaymentUrl(VnpayInfoModel model, HttpContext context)
        {
            var timeZoneById = TimeZoneInfo.FindSystemTimeZoneById(_configuration["Vnpay:TimeZoneId"]);
            var timeNow = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, timeZoneById);
            var tick = DateTime.Now.Ticks.ToString();
            var pay = new VnPayLibrary();
            var urlCallBack = _configuration["Vnpay:ReturnUrl"];

            var existingEnrollment = await _unitOfWork.Enrollments.GetEnrolmentById(model.EnrollmentId);
            var courseId = existingEnrollment.Class.CourseId;
            var dogId = existingEnrollment.DogId;

            model.Amount = (double)existingEnrollment.Class.Course.Price;

            var coursePreviousEnrollments = (await _unitOfWork.Enrollments.GetEnrollmentsByDog(dogId))
                                                        .Where(e => e.Status == (int)EnrollmentStatusEnum.Concluded &&
                                                                    e.Class.CourseId == courseId);

            if (coursePreviousEnrollments.Any())
            {
                model.Amount *= 0.5;
            }

            if (existingEnrollment.RequiredNightStay)
            {
                var classSlots = (await _unitOfWork.Slots.GetAll())
                                            .Where(s => s.ClassId == existingEnrollment.ClassId)
                                            .ToList();

                var numberOfDays = (classSlots.Last().Date.DayNumber - classSlots.First().Date.DayNumber) + 1;

                model.Amount += 100000 * numberOfDays;
            }

            var user = await _unitOfWork.Accounts.GetById(model.CustomerID);
            var membership = await _unitOfWork.Memberships.GetById(user.MembershipId);

            if (membership.DiscountAmount > 0)
            {
                model.Amount *= (1 - (double)membership.DiscountAmount / 100);
            }

            pay.AddRequestData("vnp_Version", _configuration["Vnpay:Version"]);
            pay.AddRequestData("vnp_Command", _configuration["Vnpay:Command"]);
            pay.AddRequestData("vnp_TmnCode", _configuration["Vnpay:TmnCode"]);
            pay.AddRequestData("vnp_Amount", (model.Amount * 100).ToString());
            pay.AddRequestData("vnp_CreateDate", timeNow.ToString("yyyyMMddHHmmss"));
            pay.AddRequestData("vnp_CurrCode", _configuration["Vnpay:CurrCode"]);
            pay.AddRequestData("vnp_IpAddr", pay.GetIpAddress(context));
            pay.AddRequestData("vnp_Locale", _configuration["Vnpay:Locale"]);
            pay.AddRequestData("vnp_OrderInfo", $"Name: {user.FullName}, Amount: {model.Amount}, EnrollmentId: {model.EnrollmentId} ");
            pay.AddRequestData("vnp_OrderType", model.OrderType);
            pay.AddRequestData("vnp_ReturnUrl", urlCallBack);
            pay.AddRequestData("vnp_TxnRef", tick);

            var paymentUrl =
                pay.CreateRequestUrl(_configuration["Vnpay:BaseUrl"], _configuration["Vnpay:HashSecret"]);

            return paymentUrl;
        }

        public async Task<BaseResponseDTO<VnpayResponseModel>> PaymentExecute(IQueryCollection collections)
        {
            var pay = new VnPayLibrary();

            var vnpResponse = pay.GetFullResponseData(collections, _configuration["Vnpay:HashSecret"]);

            if (!vnpResponse.Success)
            {
                return new BaseResponseDTO<VnpayResponseModel>
                {
                    Success = false,
                    Message = $"Payment unsuccessful. Response code: {vnpResponse.VnPayResponseCode}"
                };
            }

            if (vnpResponse.VnPayResponseCode.Equals("24"))
            {
                return new BaseResponseDTO<VnpayResponseModel>
                {
                    Success = false,
                    Message = $"Payment cancelled. Response code: {vnpResponse.VnPayResponseCode}"
                };
            }

            var orderDescriptionParts = vnpResponse.OrderDescription.Split(", ");

            var enrollmentId = "";

            var amount = "";

            foreach (var part in orderDescriptionParts)
            {
                if (part.StartsWith("EnrollmentId:"))
                {
                    enrollmentId = part.Replace("EnrollmentId: ", "").Trim();
                }

                if (part.StartsWith("Amount:"))
                {
                    amount = part.Replace("Amount: ", "").Trim();
                }
            }

            vnpResponse.EnrollmentId = enrollmentId;
            vnpResponse.Amount = amount;

            var enrollment = await _unitOfWork.Enrollments.GetById(enrollmentId);

            if (enrollment.Status == 1)
            {
                return new BaseResponseDTO<VnpayResponseModel>
                {
                    Success = false,
                    Message = "Payment can only be done for Pending enrollment."
                };
            }

            enrollment.Status = (int)EnrollmentStatusEnum.Active;

            try
            {
                await _unitOfWork.Enrollments.Update(enrollment);
                await _unitOfWork.SaveChanges();
            }
            catch (Exception ex)
            {
                return new BaseResponseDTO<VnpayResponseModel>
                {
                    Success = false,
                    Message = $"There has been an error updating enrollment status. {ex.Message}"
                };
            }

            var customerId = (await _unitOfWork.DogOwnerships.GetAll())
                                        .Where(dow => dow.DogId == enrollment.DogId && dow.ToDate == null)
                                        .Select(dow => dow.CustomerId)
                                        .FirstOrDefault();

            if (customerId == null)
            {
                return new BaseResponseDTO<VnpayResponseModel>
                {
                    Success = false,
                    Message = $"Unable to find customerId for enrollmentId {enrollmentId}"
                };
            }

            var transaction = new Transaction
            {
                OrderId = vnpResponse.OrderId,
                PaymentId = vnpResponse.PaymentId,
                PaymentTime = DateTime.UtcNow,
                TotalAmount = Int32.Parse(amount),
                Status = vnpResponse.Success ? 1 : 0,
                PaymentMethodId = "1",
                EnrollmentId = enrollmentId,
                CustomerId = customerId
            };

            try
            {
                await _unitOfWork.Transactions.Add(transaction);
                await _unitOfWork.SaveChanges();
            }
            catch (Exception ex)
            {
                return new BaseResponseDTO<VnpayResponseModel>
                {
                    Success = false,
                    Message = $"There has been an error adding transaction. {ex.Message}"
                };
            }

            var customerAcc = await _unitOfWork.Accounts.GetById(customerId);
            var pointGained = (int)Math.Floor(Int32.Parse(amount) / 1000.0);
            customerAcc.MembershipPoints += pointGained;

            while (true)
            {
                var membershipProgress = await _membershipService.GetMembershipProgress(customerId);

                if (!membershipProgress.Success)
                {
                    return new BaseResponseDTO<VnpayResponseModel>
                    {
                        Success = false,
                        Message = $"Unable to get membership progress for customerId {customerId}. {membershipProgress.Message}"
                    };
                }

                var nextMembership = membershipProgress.Object.NextMembership;

                if (nextMembership != null && customerAcc.MembershipPoints >= nextMembership.RequiredPoints)
                {
                    customerAcc.MembershipId = nextMembership.Id;
                }
                else
                {
                    break;
                }
            }

            try
            {
                await _unitOfWork.Accounts.Update(customerAcc);
                await _unitOfWork.SaveChanges();
            }
            catch (Exception ex)
            {
                return new BaseResponseDTO<VnpayResponseModel>
                {
                    Success = false,
                    Message = "Unable to update user membership point."
                };
            }

            return new BaseResponseDTO<VnpayResponseModel> { Success = true, Object = vnpResponse };
        }
    }
}
