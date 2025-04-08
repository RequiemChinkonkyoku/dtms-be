using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs.Response
{
    public class AttendanceResponse
    {
        public string Id { get; set; }
        public DateOnly Date { get; set; }
        public int Status { get; set; }
        public string SlotId { get; set; }
        public string DogId { get; set; }
        public string DogName { get; set; }
        public List<ProgressReportResponse> ProgressReports { get; set; }
    }
}
