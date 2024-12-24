using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class TrainerReport : BaseEntity
    {
        public int Rating { get; set; }
        public string Message { get; set; }

        public string TrainerProfileId { get; set; }
        public TrainerProfile TrainerProfile { get; set; }

        public string CustomerProfileId { get; set; }
        public CustomerProfile CustomerProfile { get; set; }
    }
}
