using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs.Class
{
    public class ClassSlotDTO
    {
        public string SlotId { get; set; }
        public DateOnly SlotDate { get; set; }
        public string ScheduleId { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
    }
}
