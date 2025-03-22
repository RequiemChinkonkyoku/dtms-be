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

        public string TrainerId { get; set; }
        public Account Trainer { get; set; }

        public string CustomerId { get; set; }
        public Account Customer { get; set; }
    }
}
