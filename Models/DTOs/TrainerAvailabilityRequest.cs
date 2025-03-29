using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs
{
    public class TrainerAvailabilityRequest
    {
        public DateOnly StartingDate { get; set; }
        public int DurationInWeeks { get; set; }
        public List<SlotRequirement> SlotData { get; set; } = new();
    }

    public class SlotRequirement
    {
        public DayOfWeek DayOfWeek { get; set; }
        public string ScheduleId { get; set; }
    }
}
