using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs.Class.Response
{
    public class EnrollClassResponse
    {
        public string ClassId { get; set; }
        public string ClassName { get; set; }
        public DateOnly StartingDate { get; set; }

        public string CourseId { get; set; }
        public string CourseName { get; set; }

        public List<AssignedTrainerDTO> TrainerAssignments { get; set; }

        public DateOnly TestDate { get; set; }
    }
}
