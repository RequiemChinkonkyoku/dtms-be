using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.DTOs.Response;

namespace Services.Interface
{
    public interface ICustomerProfileService
    {
        Task<CustomerProfileResponse> GetCustomerProfile(string accountId);
    }
}
