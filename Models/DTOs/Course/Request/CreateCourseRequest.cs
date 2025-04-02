using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs.Course.Request
{
    public class CreateCourseRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }
        public string ImageUrl { get; set; }
        public int DurationInWeeks { get; set; }
        public int DaysPerWeek { get; set; }
        public int SlotsPerDay { get; set; }
        public decimal Price { get; set; }
        public int MinDogs { get; set; }
        public int MaxDogs { get; set; }
        public int MinTrainers { get; set; }
        public int MaxTrainers { get; set; }
        public int Complexity { get; set; }

        public string CreatedTrainerId { get; set; }

        public string CategoryId { get; set; }

        public List<string> LessonIds { get; set; }

        public List<string> DogBreedIds { get; set; }
    }
}
