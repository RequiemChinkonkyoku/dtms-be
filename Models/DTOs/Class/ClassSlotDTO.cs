using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs.Class
{
    public class ClassSlotDTO
    {
        public int Status { get; set; }
        public string SlotId { get; set; }
        public DateOnly SlotDate { get; set; }
        public string ScheduleId { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
        public string LessonId { get; set; }
        public string LessonName { get; set; }
    }
}
