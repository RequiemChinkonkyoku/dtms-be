using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs
{
    public class UpdateLessonRequest
    {
        public string Id { get; set; }
        public string LessonTitle { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public string Environment { get; set; }
        public int Duration { get; set; }
        public string Objective { get; set; }
        public string SkillId { get; set; }
        public List<string> EquipmentIds { get; set; }
    }
}
