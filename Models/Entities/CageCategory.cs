using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class CageCategory : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Size { get; set; }
        public int Status { get; set; }

        public ICollection<Cage> Cages { get; set; }
    }
}
