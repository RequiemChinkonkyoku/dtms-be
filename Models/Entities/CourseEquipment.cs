using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class CourseEquipment : BaseEntity
    {
        public string CourseId { get; set; }
        public Course Course { get; set; }

        public string EquipmentId { get; set; }
        public Equipment Equipment { get; set; }

        public ICollection<SlotEquipment> SlotEquipments { get; set; }
    }
}
