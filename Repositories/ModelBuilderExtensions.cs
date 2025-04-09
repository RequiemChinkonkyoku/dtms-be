using CloudinaryDotNet;
using Microsoft.EntityFrameworkCore;
using Repositories.SeedingData;
using Account = Repositories.SeedingData.Account;

namespace Repositories;

public static class ModelBuilderExtensions
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        Account.Seed(modelBuilder);
        Blog.Seed(modelBuilder);
        Category.Seed(modelBuilder);
        Dog.Seed(modelBuilder);
        DogBreed.Seed(modelBuilder);
        DogOwnership.Seed(modelBuilder);
        DogType.Seed(modelBuilder);
        Equipment.Seed(modelBuilder);
        EquipmentCategory.Seed(modelBuilder);
        Membership.Seed(modelBuilder);
        Role.Seed(modelBuilder);
        Skill.Seed(modelBuilder);
        Specialization.Seed(modelBuilder);
        TrainerSkill.Seed(modelBuilder);
        TrainerSpecialization.Seed(modelBuilder);
        DogDocument.Seed(modelBuilder);
        DogDocumentType.Seed(modelBuilder);
        Lesson.Seed(modelBuilder);
        Course.Seed(modelBuilder);
        CourseLesson.Seed(modelBuilder);
        CourseDog.Seed(modelBuilder);
        Certificate.Seed(modelBuilder);
        Schedule.Seed(modelBuilder);
        PaymentMethod.Seed(modelBuilder);
        Cage.Seed(modelBuilder);
        CageCategory.Seed(modelBuilder);
        LessonEquipment.Seed(modelBuilder);
    }
}