using Microsoft.AspNetCore.Components.RenderTree;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class SlotEquipment : BaseEntity
    {
        public bool Status { get; set; }

        public string CourseEquipmentId { get; set; }
        public CourseEquipment CourseEquipment { get; set; }

        public string SlotId { get; set; }
        public Slot Slot { get; set; }
    }
}
