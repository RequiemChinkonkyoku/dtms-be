using System.Reflection.Metadata;

namespace Models.Entities;

public class Lesson : BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string Notes { get; set; }
    
    public string SkillId { get; set; }
    public Skill Skill { get; set; }
    
    public ICollection<CourseLesson> CourseLessons { get; set; }
}