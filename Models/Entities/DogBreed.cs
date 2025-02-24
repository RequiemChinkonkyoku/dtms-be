using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class DogBreed : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }

        public ICollection<Dog> Dogs { get; set; }
        public ICollection<CourseDog> CourseDogs { get; set; }
    }
}
