using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs
{
    public class CreateAttendanceRequest
    {
        public DateOnly Date { get; set; }

        public string SlotId { get; set; }


        public string DogId { get; set; }
    }
}
