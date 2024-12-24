namespace Models.Entities;

public class SlotLesson : BaseEntity
{
    public string Note { get; set; }

    public string SlotId { get; set; }
    public Slot Slot { get; set; }

    public string LessonId { get; set; }
    public Lesson Lesson { get; set; }
}