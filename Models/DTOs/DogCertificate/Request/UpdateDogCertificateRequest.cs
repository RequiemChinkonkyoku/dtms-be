using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs.DogCertificate.Request
{
    public class UpdateDogCertificateRequest
    {
        [Required]
        public string DogId { get; set; }

        [Required]
        public string CertificateId { get; set; }
    }
}
