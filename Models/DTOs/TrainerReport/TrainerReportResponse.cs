using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs.TrainerReport
{
    public class TrainerReportResponse
    {
        public string Id {  get; set; }
        public int Rating { get; set; }
        public string Message { get; set; }
        public string TrainerId { get; set; }
        public string CustomerId { get; set; }
        public DateTimeOffset CreatedTime { get; set; }
        public DateTimeOffset LastUpdatedTime { get; set; }
    }
}
