using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class Equipment : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }

        public string EquipmentCategoryId { get; set; }
        public EquipmentCategory EquipmentCategory { get; set; }

        public ICollection<LessonEquipment> LessonEquipments { get; set; }
    }
}
