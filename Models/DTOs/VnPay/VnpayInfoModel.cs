using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs.VnPay
{
    public class VnpayInfoModel
    {
        public string OrderType { get; set; }
        public double Amount { get; set; }
        public string EnrollmentId { get; set; }
        public string CustomerID { get; set; }
    }
}
