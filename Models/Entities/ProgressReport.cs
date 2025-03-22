using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class ProgressReport : BaseEntity
    {
        public string Feedback { get; set; }
        public string HealthObservation { get; set; }
        public string BehaviorObservation { get; set; }
        public string PerformanceObservation { get; set; }
        public int Status { get; set; }

        public string AttendanceId { get; set; }
        public Attendance Attendance { get; set; }

        public string TrainerId { get; set; }
        public Account Account { get; set; }
    }
}
