using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class TrainerAssignment : BaseEntity
    {
        public string ClassId { get; set; }
        public Class Class { get; set; }

        public string TrainerProfileId { get; set; }
        public TrainerProfile TrainerProfile { get; set; }
    }
}
