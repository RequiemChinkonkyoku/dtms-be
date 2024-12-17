namespace Models.Entities;

public class Prerequisite : BaseEntity
{
    public string CourseId { get; set; }
    public Course Course { get; set; }
    
    public string PrerequisiteCourseId { get; set; }
    public Course PrerequisiteCourse { get; set; }
}