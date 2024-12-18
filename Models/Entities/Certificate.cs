using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class Certificate : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public string CourseId { get; set; }
        public Course Course { get; set; }

        public ICollection<DogCertificate> DogCertificates { get; set; }
    }
}
