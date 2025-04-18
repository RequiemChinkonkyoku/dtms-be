using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.SeedingData
{
    public class Lesson
    {
        public static readonly string BasicLessonId = "a1b2c3d4e5f67890a1b2c3d4e5f67890";
        public static readonly string AgilityLessonId = "b2c3d4e5f67890a1b2c3d4e5f67890a1";
        public static readonly string BehavioralCorrectionLessonId = "c3d4e5f67890a1b2c3d4e5f67890a1b2";
        public static readonly string SocializationLessonId = "d4e5f67890a1b2c3d4e5f67890a1b2c3";
        public static readonly string ProtectionTrainingLessonId = "e5f67890a1b2c3d4e5f67890a1b2c3d4";
        public static readonly string RevisionLessonId = "f67890a1b2c3d4e5f67890a1b2c3d4e5";

        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Entities.Lesson>().HasData(
                new Models.Entities.Lesson
                {
                    Id = BasicLessonId,
                    LessonTitle = "Basic Training",
                    Description = "Obedience basics",
                    Difficulty = 1,
                    Notes = "Sit, stay, come",
                    Environment = "Indoor",
                    Duration = 1,
                    Objective = "Good behavior",
                    Status = 1,
                    SkillId = "1a2b3c4d5e6f78901a2b3c4d5e6f7890",
                    CreatedTime = new DateTimeOffset(new DateTime(2023, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 1, 1))
                },
                new Models.Entities.Lesson
                {
                    Id = AgilityLessonId,
                    LessonTitle = "Agility",
                    Description = "Speed & coordination",
                    Difficulty = 2,
                    Notes = "Jumping, weaving",
                    Environment = "Outdoor",
                    Duration = 2,
                    Objective = "Improve agility",
                    Status = 1,
                    SkillId = "2b3c4d5e6f78901a2b3c4d5e6f78901a",
                    CreatedTime = new DateTimeOffset(new DateTime(2023, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 1, 1))
                },
                new Models.Entities.Lesson
                {
                    Id = BehavioralCorrectionLessonId,
                    LessonTitle = "Behavioral Fixes",
                    Description = "Correct bad habits",
                    Difficulty = 3,
                    Notes = "Reduce aggression",
                    Environment = "Indoor",
                    Duration = 3,
                    Objective = "Better discipline",
                    Status = 1,
                    SkillId = "3c4d5e6f78901a2b3c4d5e6f78901a2b",
                    CreatedTime = new DateTimeOffset(new DateTime(2023, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 1, 1))
                },
                new Models.Entities.Lesson
                {
                    Id = SocializationLessonId,
                    LessonTitle = "Socialization",
                    Description = "Interact with dogs",
                    Difficulty = 4,
                    Notes = "Playgroups, exposure",
                    Environment = "Outdoor",
                    Duration = 2,
                    Objective = "Friendly behavior",
                    Status = 1,
                    SkillId = "4d5e6f78901a2b3c4d5e6f78901a2b3c",
                    CreatedTime = new DateTimeOffset(new DateTime(2023, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 1, 1))
                },
                new Models.Entities.Lesson
                {
                    Id = ProtectionTrainingLessonId,
                    LessonTitle = "Protection Training",
                    Description = "Guard dog skills",
                    Difficulty = 5,
                    Notes = "Barking, alerting",
                    Environment = "Outdoor",
                    Duration = 3,
                    Objective = "Security readiness",
                    Status = 1,
                    SkillId = "5e6f78901a2b3c4d5e6f78901a2b3c4d",
                    CreatedTime = new DateTimeOffset(new DateTime(2023, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 1, 1))
                },
                new Models.Entities.Lesson
                {
                    Id = RevisionLessonId,
                    LessonTitle = "Revision",
                    Description = "Review previously lesson",
                    Difficulty = 10,
                    Notes = "Flexible content depending on class performance",
                    Environment = "Indoor",
                    Duration = 1,
                    Objective = "Reinforce learning",
                    Status = 1,
                    SkillId = "6f78901a2b3c4d5e6f78901a2b3c4d5e",
                    CreatedTime = new DateTimeOffset(new DateTime(2023, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 1, 1))
                }
            );
        }
    }
}
