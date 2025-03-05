using Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs.Class
{
    public class CreateClassRequest
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public DateOnly StartingDate { get; set; }
        [Required]
        public string CourseId { get; set; }
        [Required]
        public List<string> TrainerProfileIds { get; set; }
        [Required]
        public List<SlotData> SlotDatas { get; set; }

        public class SlotData
        {
            [Required]
            public DayOfWeek DayOfWeek { get; set; }
            [Required]
            public string ScheduleId { get; set; }
        }
    }
}
