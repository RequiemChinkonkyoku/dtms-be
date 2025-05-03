using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using Models.DTOs.Class;
using Models.DTOs.TrainingReport;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs.Enrollment.Response
{
    public class GetEnrollmentResponse
    {
        public string Id { get; set; }
        public int Status { get; set; }
        public bool RequiredNightStay { get; set; }

        public string ClassId { get; set; }
        public string ClassName { get; set; }

        public string DogId { get; set; }
        public string DogName { get; set; }

        public string? CageId { get; set; }
        public string CageNumber { get; set; }

        public string? StaffId { get; set; }
        public string StaffName { get; set; }
    }
}
