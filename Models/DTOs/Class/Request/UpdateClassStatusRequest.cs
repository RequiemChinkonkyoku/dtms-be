using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs.Class.Request
{
    public class UpdateClassStatusRequest
    {
        public string ClassId { get; set; }
        public int Status { get; set; }
    }
}
