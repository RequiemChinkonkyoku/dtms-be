using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.SeedingData
{
    public class CourseLesson
    {
        public static readonly string CLId1 = "e1f2a3b4c5d67890a1b2c3d4e5f67890";
        public static readonly string CLId2 = "f2a3b4c5d67890a1b2c3d4e5f67890e1";
        public static readonly string CLId3 = "a3b4c5d67890a1b2c3d4e5f67890e1f2";
        public static readonly string CLId4 = "b4c5d67890a1b2c3d4e5f67890e1f2a3";
        public static readonly string CLId5 = "c5d67890a1b2c3d4e5f67890e1f2a3b4";
        public static readonly string CLId6 = "g6d67890a1b2c3d4e5f67890e1f2a3b4";

        public static readonly string BasicCourseId = "f1a2b3c4d5e67890a1b2c3d4e5f67890";
        public static readonly string AgilityCourseId = "a2b3c4d5e67890a1b2c3d4e5f67890f1";
        public static readonly string BehavioralCorrectionCourseId = "b3c4d5e67890a1b2c3d4e5f67890f1a2";
        public static readonly string SocializationCourseId = "c4d5e67890a1b2c3d4e5f67890f1a2b3";
        public static readonly string ProtectionTrainingCourseId = "d5e67890a1b2c3d4e5f67890f1a2b3c4";
        public static readonly string QuickLearnerCourseId = "e75s896fa1b2c3d4e5f67890f1a2b3c4";

        public static readonly string BasicLessonId = "a1b2c3d4e5f67890a1b2c3d4e5f67890";
        public static readonly string AgilityLessonId = "b2c3d4e5f67890a1b2c3d4e5f67890a1";
        public static readonly string BehavioralCorrectionLessonId = "c3d4e5f67890a1b2c3d4e5f67890a1b2";
        public static readonly string SocializationLessonId = "d4e5f67890a1b2c3d4e5f67890a1b2c3";
        public static readonly string ProtectionTrainingLessonId = "e5f67890a1b2c3d4e5f67890a1b2c3d4";

        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Entities.CourseLesson>().HasData(
                new Models.Entities.CourseLesson
                {
                    Id = CLId1,
                    Status = 1,
                    CourseId = BasicCourseId,
                    LessonId = BasicLessonId,
                    CreatedTime = new DateTimeOffset(new DateTime(2023, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 1, 1))
                },
                new Models.Entities.CourseLesson
                {
                    Id = CLId2,
                    Status = 1,
                    CourseId = AgilityCourseId,
                    LessonId = AgilityLessonId,
                    CreatedTime = new DateTimeOffset(new DateTime(2023, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 1, 1))
                },
                new Models.Entities.CourseLesson
                {
                    Id = CLId3,
                    Status = 1,
                    CourseId = BehavioralCorrectionCourseId,
                    LessonId = BehavioralCorrectionLessonId,
                    CreatedTime = new DateTimeOffset(new DateTime(2023, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 1, 1))
                },
                new Models.Entities.CourseLesson
                {
                    Id = CLId4,
                    Status = 1,
                    CourseId = SocializationCourseId,
                    LessonId = SocializationLessonId,
                    CreatedTime = new DateTimeOffset(new DateTime(2023, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 1, 1))
                },
                new Models.Entities.CourseLesson
                {
                    Id = CLId5,
                    Status = 1,
                    CourseId = ProtectionTrainingCourseId,
                    LessonId = ProtectionTrainingLessonId,
                    CreatedTime = new DateTimeOffset(new DateTime(2023, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 1, 1))
                },
                new Models.Entities.CourseLesson
                {
                    Id = CLId6,
                    Status = 1,
                    CourseId = QuickLearnerCourseId,
                    LessonId = BasicLessonId,
                    CreatedTime = new DateTimeOffset(new DateTime(2023, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 1, 1))
                }
            );
        }
    }
}
