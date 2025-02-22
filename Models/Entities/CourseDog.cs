using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class CourseDog : BaseEntity
    {
        public int Status { get; set; }

        public string CourseId { get; set; }
        public Course Course { get; set; }

        public string DogBreedId { get; set; }
        public DogBreed DogBreed { get; set; }
    }
}
