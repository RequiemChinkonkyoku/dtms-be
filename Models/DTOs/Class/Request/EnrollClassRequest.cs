using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs.Class.Request
{
    public class EnrollClassRequest
    {
        public string CustomerProfileId { get; set; }
        public string ClassId { get; set; }
        public string DogId { get; set; }
        public bool IsBoarding { get; set; }
    }
}
