﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs
{
    public class CreateCertificateRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string CourseId { get; set; }
    }
}
