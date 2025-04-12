using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs.DogCertificate.Response
{
    public
        class DogCertificateResponse
    {
        public string Id { get; set; }
        public string DogId { get; set; }
        public string DogName { get; set; }
        public string CertificateId { get; set; }
        public string CertificateName { get; set; }

    }
}
