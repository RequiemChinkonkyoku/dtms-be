using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class Class : BaseEntity
    {
        public string Name { get; set; }
        public int EnrolledDogCount { get; set; }
        public int AssignedTrainerCount { get; set; }
        public int Status { get; set; }
        public DateOnly StartingDate { get; set; }

        public string CourseId { get; set; }
        public Course Course { get; set; }

        public ICollection<TrainerAssignment> TrainerAssignments { get; set; }

        public ICollection<Slot> Slots { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }

        public ICollection<Attendance> Attendances { get; set; }

        public ICollection<PreTest> PreTests { get; set; }
    }
}
