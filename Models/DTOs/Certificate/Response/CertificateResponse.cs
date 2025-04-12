using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs.Certificate.Response
{
    public class CertificateResponse
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }

        // Course Information
        public string? CourseId { get; set; }
        public string? CourseName { get; set; }
        public string? CourseDescription { get; set; }

    }
}
