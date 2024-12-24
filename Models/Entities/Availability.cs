using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class Availability : BaseEntity
    {
        public bool Status { get; set; }

        public string TrainerProfileId { get; set; }
        public TrainerProfile TrainerProfile { get; set; }

        public string ScheduleId { get; set; }
        public Schedule Schedule { get; set; }
    }
}
