using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class Schedule : BaseEntity
    {
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }

        public ICollection<Slot> Slots { get; set; }

        public ICollection<Availability> Availabilities { get; set; }
    }
}
