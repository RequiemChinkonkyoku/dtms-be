using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class CourseLesson : BaseEntity
    {
        public int Status { get; set; }

        public string CourseId { get; set; }
        public Course Course { get; set; }

        public string LessonId { get; set; }
        public Lesson Lesson { get; set; }
    }
}
