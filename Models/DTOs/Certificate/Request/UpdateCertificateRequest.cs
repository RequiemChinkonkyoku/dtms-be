using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs.Certificate.Request
{
    public class UpdateCertificateRequest
    {
        [MaxLength(100)]
        public string? Name { get; set; }

        [MaxLength(500)]
        public string? Description { get; set; }

        public int? Status { get; set; }

        public string? CourseId { get; set; }

        public bool IsValid() => Name != null || Description != null || Status != null || CourseId != null;

    }
}
