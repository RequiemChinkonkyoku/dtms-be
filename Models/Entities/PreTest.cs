using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class PreTest : BaseEntity
    {
        public DateOnly TestDate { get; set; }
        public int Status { get; set; }

        public string DogId { get; set; }
        public Dog Dog { get; set; }

        public string ClassId { get; set; }
        public Class Class { get; set; }
    }
}
