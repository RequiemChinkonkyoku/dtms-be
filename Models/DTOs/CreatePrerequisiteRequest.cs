﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs
{
    public class CreatePrerequisiteRequest
    {
        public string CourseId { get; set; }
        public string PrerequisiteCourseId { get; set; }
    }
}
