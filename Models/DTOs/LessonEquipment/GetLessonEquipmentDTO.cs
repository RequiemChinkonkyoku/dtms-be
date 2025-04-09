using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs.LessonEquipment
{
    public class GetLessonEquipmentDTO
    {
        public string Id { get; set; }

        public string LessonId { get; set; }
        public string LessonTitle { get; set; }

        public string EquipmentId { get; set; }
        public string EquipmentName { get; set; }
        public int Quantity { get; set; }
    }
}
