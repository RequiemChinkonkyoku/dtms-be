using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs.Pretest.Request
{
    public class GetPretestRequest
    {
        [Required]
        public string ClassId { get; set; }
        public string? DogId { get; set; }
    }
}
