using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs.Response
{
    public class DogBreedResponse
    {
       
            public string Name { get; set; }
            public string Description { get; set; }
            public int Status { get; set; }
            public List<string> DogNames { get; set; } 
            public string Id { get; set; }
            public string CreatedTime { get; set; }
            public string LastUpdatedTime { get; set; }

    }
}
