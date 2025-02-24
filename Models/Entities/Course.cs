using System.Reflection.Metadata;

namespace Models.Entities;

public class Course : BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Status { get; set; }
    public int DurationInWeeks { get; set; }
    public int DaysPerWeek { get; set; }
    public int SlotsPerDay { get; set; }
    public decimal Price { get; set; }
    public int MinDogs { get; set; }
    public int MaxDogs { get; set; }
    public int MinTrainers { get; set; }
    public int MaxTrainers { get; set; }
    public int Complexity { get; set; }

    public string CreatedTrainerId { get; set; }
    public TrainerProfile CreatedTrainerProfile { get; set; }

    public string CategoryId { get; set; }
    public Category Category { get; set; }

    public Certificate Certificate { get; set; }

    public ICollection<Prerequisite> Prerequisites { get; set; } // Prerequisites for this course

    public ICollection<CourseLesson> CourseLessons { get; set; }

    public ICollection<CourseDog> CourseDogs { get; set; }

    public ICollection<Class> Classes { get; set; }

    public ICollection<WishList> WishLists { get; set; }
}