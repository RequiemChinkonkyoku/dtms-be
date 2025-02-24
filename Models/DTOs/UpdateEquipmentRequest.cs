using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs
{
    public class UpdateEquipmentRequest
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }

        public string EquipmentCategoryId { get; set; }
    }
}
