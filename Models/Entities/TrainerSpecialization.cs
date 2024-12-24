using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class TrainerSpecialization : BaseEntity
    {
        public string TrainerProfileId { get; set; }
        public TrainerProfile TrainerProfile { get; set; }

        public string SpecializaionId { get; set; }
        public Specialization Specialization { get; set; }
    }
}
