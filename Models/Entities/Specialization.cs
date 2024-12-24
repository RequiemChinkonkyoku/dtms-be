using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class Specialization : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<TrainerSpecialization> TrainerSpecializations{ get; set; }
    }
}
