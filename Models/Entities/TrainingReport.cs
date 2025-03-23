using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class TrainingReport : BaseEntity
    {
        public string BehaviorType { get; set; }
        public int Intensity { get; set; }
        public int ReactionToCommands { get; set; }
        public int Socialization { get; set; }
        public int StressLevel { get; set; }
        public string Notes { get; set; }

        public string? EnrollmentId { get; set; }
        public Enrollment Enrollment { get; set; }

        public string TrainerId { get; set; }
        public Account Trainer { get; set; }
    }
}
