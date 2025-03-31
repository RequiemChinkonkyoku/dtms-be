using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs.Pretest.Response
{
    public class GetPretestResponse
    {
        public string Id { get; set; }

        public DateOnly TestDate { get; set; }
        public int Status { get; set; }

        public string DogId { get; set; }
        public string DogName { get; set; }

        public string ClassId { get; set; }
        public string ClassName { get; set; }
    }
}
