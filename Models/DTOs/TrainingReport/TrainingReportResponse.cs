﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs.TrainingReport
{
    public class TrainingReportResponse
    {
        public string Id { get; set; }
        public string BehaviorType { get; set; }
        public int Intensity { get; set; }
        public int ReactionToCommands { get; set; }
        public int Socialization { get; set; }
        public int StressLevel { get; set; }
        public string Notes { get; set; }
        public string DogId { get; set; }
        public string TrainerProfileId { get; set; }
        public DateTimeOffset CreatedTime { get; set; }
        public DateTimeOffset LastUpdatedTime { get; set; }
    }
}