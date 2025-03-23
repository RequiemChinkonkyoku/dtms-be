using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class TrainerSpecialization : BaseEntity
    {
        public string TrainerId { get; set; }
        public Account Trainer { get; set; }

        public string SpecializaionId { get; set; }
        public Specialization Specialization { get; set; }
    }
}
