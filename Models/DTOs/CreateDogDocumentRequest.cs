using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs
{
    public class CreateDogDocumentRequest
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }
        public string IssuingAuthority { get; set; }
        public DateOnly IssueDate { get; set; }
        public string DogId { get; set; }
        public string DogDocumentTypeId { get; set; }
    }

}
