using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs.Response
{
    public class GetSlotByClassResponse
    {
        public string Id { get; set; }
        public DateOnly Date { get; set; }
        public ClassScheduleResponse Schedule { get; set; }
        public ClassLessonResponse? Lesson { get; set; }
        public ClassAttendanceResponse Attendance { get; set; }

    }
    public class ClassScheduleResponse
    {
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
    }

    public class ClassLessonResponse
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }

    public class ClassAttendanceResponse
    {
        public string Id { get; set; }
        public DateTime Date { get; set; }
        public string DogId { get; set; }
    }

}
