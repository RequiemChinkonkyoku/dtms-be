using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class Attendance : BaseEntity
    {
        public DateOnly Date { get; set; }

        public string SlotId { get; set; }
        public Slot Slot { get; set; }

        public string DogId { get; set; }
        public Dog Dog { get; set; }

        public ICollection<ProgressReport> ProgressReports { get; set; }
    }
}
