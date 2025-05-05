using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.SeedingData
{
    public class Class
    {
        public static readonly string ClassId1 = "1";
        public static readonly string ClassId2 = "2";

        public static readonly string QuickLearnerCourseId = "e75s896fa1b2c3d4e5f67890f1a2b3c4";

        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Entities.Class>().HasData(
                new Models.Entities.Class
                {
                    Id = ClassId1,
                    Name = "Quick Learner Class1",
                    EnrolledDogCount = 0,
                    Status = 1,
                    StartingDate = new DateOnly(2025, 5, 11),
                    CourseId = QuickLearnerCourseId,
                    CreatedTime = new DateTimeOffset(new DateTime(2023, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 1, 1))
                },
                new Models.Entities.Class
                {
                    Id = ClassId2,
                    Name = "Quick Learner Class2",
                    EnrolledDogCount = 0,
                    Status = 1,
                    StartingDate = new DateOnly(2025, 5, 4),
                    CourseId = QuickLearnerCourseId,
                    CreatedTime = new DateTimeOffset(new DateTime(2023, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 1, 1))
                }
            );
        }
    }
}
