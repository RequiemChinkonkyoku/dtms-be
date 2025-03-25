using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs.Response
{
    public class ProgressReportResponse
    {
        public string Id { get; set; }
        public string Feedback { get; set; }
        public string HealthObservation { get; set; }
        public string BehaviorObservation { get; set; }
        public string PerformanceObservation { get; set; }
        public int Status { get; set; }
        public string AttendanceId { get; set; }
        public DateTime AttendanceDate { get; set; }
        public string TrainerName { get; set; }  
        public string DogId { get; set; }        


    }
}
