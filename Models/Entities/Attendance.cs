using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class Attendance : BaseEntity
    {
        public string ClassId { get; set; }
        public Class Class { get; set; }

        public string DogId { get; set; }
        public Dog Dog { get; set; }

        public ICollection<ProgressReport> ProgressReports { get; set; }
    }
}
