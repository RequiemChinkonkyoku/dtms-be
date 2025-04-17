using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs.Cage.Response
{
    public class GetStaffCageResponse
    {
        public string CageId { get; set; }
        public int Number { get; set; }
        public string Location { get; set; }

        public string CategoryId { get; set; }
        public string CategoryName { get; set; }

        public string DogId { get; set; }
        public string DogName { get; set; }

        public string DogBreedId { get; set; }
        public string DogBreedName { get; set; }

        public List<CageSlotDTO> CageSlots { get; set; }
    }
}
