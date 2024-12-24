using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class LessonEquipment : BaseEntity
    {
        public string LessonId { get; set; }
        public Lesson Lesson { get; set; }

        public string EquipmentId { get; set; }
        public Equipment Equipment { get; set; }
    }
}
