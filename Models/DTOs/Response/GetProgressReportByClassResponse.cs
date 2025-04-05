using Models.DTOs.Slot.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs.Response
{
    public class GetProgressReportByClassResponse
    {
        public string Id { get; set; }
        public DateOnly Date { get; set; }
        public ClassScheduleResponse Schedule { get; set; }
        public ClassLessonResponse Lesson { get; set; }
        public ClassAttendanceResponse Attendance { get; set; }

    }
}
