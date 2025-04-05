using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs.Slot.Response
{
    public class GetTrainerSlotResponse
    {
        public string Id { get; set; }

        public string ClassId { get; set; }
        public string ClassName { get; set; }

        public string ScheduleId { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }

        public string LessonId { get; set; }
        public string LessonName { get; set; }
    }
}
