using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class Slot : BaseEntity
    {
        public DateOnly Date { get; set; }

        public string ClassId { get; set; }
        public Class Class { get; set; }

        public string ScheduleId { get; set; }
        public Schedule Schedule { get; set; }
        public ICollection<SlotEquipment> SlotEquipments { get; set; }
    }
}
