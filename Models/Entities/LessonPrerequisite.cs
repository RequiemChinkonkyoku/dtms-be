using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class LessonPrerequisite
    {
        public string LessonId { get; set; }
        public Lesson Lesson { get; set; }

        public string PrerequisiteLessonId { get; set; }
        public Lesson PrerequisiteLesson { get; set; }
    }
}
