using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs.Class.Response
{
    public class GetClassResponse
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int EnrolledDogCount { get; set; }
        public int AssignedTrainerCount { get; set; }
        public int Status { get; set; }
        public DateOnly StartingDate { get; set; }
        public DateTimeOffset CreatedTime { get; set; }
        public DateTimeOffset LastUpdatedTime { get; set; }

        public string CourseId { get; set; }
        public string CourseName { get; set; }

        public List<AssignedTrainer> AssignedTrainers { get; set; }
        public List<ClassSlot> ClassSlots { get; set; }
    }
}
