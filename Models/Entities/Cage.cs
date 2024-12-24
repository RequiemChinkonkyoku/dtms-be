using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class Cage : BaseEntity
    {
        public int Number { get; set; }
        public int Status { get; set; }
        public string Location { get; set; }

        public string CageCategoryId { get; set; }
        public CageCategory CageCategory { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
