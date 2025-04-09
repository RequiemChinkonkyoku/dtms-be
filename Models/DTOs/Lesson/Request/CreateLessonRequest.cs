using Models.DTOs.LessonEquipment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs.Lesson.Request
{
    public class CreateLessonRequest
    {
        public string LessonTitle { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public string Environment { get; set; }
        public int Duration { get; set; }
        public string Objective { get; set; }
        public string SkillId { get; set; }
        public List<LessonEquipmentDTO> LessonEquipmentDTOs { get; set; }
    }
}
