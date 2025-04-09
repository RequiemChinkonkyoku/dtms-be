using Models.DTOs.Course;
using Models.DTOs.LessonEquipment;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs.Lesson.Response
{
    public class GetLessonResponse
    {
        public string Id { get; set; }
        public string LessonTitle { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        public string Environment { get; set; }
        public int Duration { get; set; }
        public string Objective { get; set; }
        public int Status { get; set; }

        public string SkillId { get; set; }
        public string SkillName { get; set; }

        public List<GetLessonEquipmentDTO> LessonEquipments { get; set; }
        public List<CourseLessonDTO> CourseList { get; set; }
        public List<CoursePrerequisiteDTO> LessonPrerequisites { get; set; }
    }
}
