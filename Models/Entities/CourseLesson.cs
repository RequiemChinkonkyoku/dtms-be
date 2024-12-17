namespace Models.Entities;

public class CourseLesson : BaseEntity
{
    public string Notes { get; set; }
    
    public string CourseId { get; set; }
    public Course Course { get; set; }
    
    public string LessonId { get; set; }
    public Lesson Lesson { get; set; }
}