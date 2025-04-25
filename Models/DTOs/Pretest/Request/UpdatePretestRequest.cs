using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs.Pretest.Request
{
    public class UpdatePretestRequest
    {
        public int Status { get; set; }
        public string Note { get; set; }
    }
}
