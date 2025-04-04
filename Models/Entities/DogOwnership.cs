﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class DogOwnership : BaseEntity
    {
        public DateOnly FromDate { get; set; }
        public DateOnly? ToDate { get; set; }

        public string CustomerId { get; set; }
        public Account Customer { get; set; }

        public string DogId { get; set; }
        public Dog Dog { get; set; }
    }
}
