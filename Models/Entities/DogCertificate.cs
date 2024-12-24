using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class DogCertificate : BaseEntity
    {
        public string DogId { get; set; }
        public Dog Dog { get; set; }

        public string CertificateId { get; set; }
        public Certificate Certificate { get; set; }
    }
}
