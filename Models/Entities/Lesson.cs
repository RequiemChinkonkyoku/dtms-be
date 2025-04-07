using System.Reflection.Metadata;

namespace Models.Entities;

public class Lesson : BaseEntity
{
    public string LessonTitle { get; set; }
    public string Description { get; set; }
    public string Notes { get; set; }
    public string Environment { get; set; }
    public int Duration { get; set; }
    public string Objective { get; set; }
    public int Status { get; set; }

    public string SkillId { get; set; }
    public Skill Skill { get; set; }

    public ICollection<LessonEquipment> LessonEquipments { get; set; }
    public ICollection<CourseLesson> CourseLessons { get; set; }
    public ICollection<LessonPrerequisite> LessonPrerequisites { get; set; }
}