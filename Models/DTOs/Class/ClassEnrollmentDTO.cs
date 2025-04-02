using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs.Class
{
    public class ClassEnrollmentDTO
    {
        public int Status { get; set; }
        public bool RequiredNightStay { get; set; }

        public string EnrollmentId { get; set; }

        public string DogId { get; set; }
        public string DogName { get; set; }

        public string CageId { get; set; }
        public string Location { get; set; }
    }
}
