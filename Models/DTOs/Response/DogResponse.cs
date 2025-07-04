﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs.Response
{
    public class DogResponse
    {
        public string Id { get; set; }
        public string DogCode { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string DateOfBirth { get; set; }
        public int Gender { get; set; }
        public int Status { get; set; }
        public DateTimeOffset RegistrationTime { get; set; }
        public string DogBreedName { get; set; }
        public string CustomerProfileId { get; set; }
        public string OwnerName { get; set; } 

    }
}
