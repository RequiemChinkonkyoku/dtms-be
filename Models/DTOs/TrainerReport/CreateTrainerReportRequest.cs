﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs.TrainerReport
{
    public class CreateTrainerReportRequest
    {
        public int Rating { get; set; }
        public string Message { get; set; }
        public string TrainerProfileId { get; set; }
        public string CustomerProfileId { get; set; }
    }
}
