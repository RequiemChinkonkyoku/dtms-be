using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class DogType : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }

        public ICollection<DogBreed> DogBreeds { get; set; }
        public ICollection<CageCategory> CageCategories { get; set; }
    }
}
