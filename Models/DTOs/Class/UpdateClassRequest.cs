using Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs.Class
{
    public class UpdateClassRequest
    {
        [Required]
        public string Id { get; set; }
        public string Name { get; set; }
        public int Status { get; set; }
        public DateOnly StartingDate { get; set; }

        public string CourseId { get; set; }

        public List<string> TrainerIds { get; set; }
    }
}
