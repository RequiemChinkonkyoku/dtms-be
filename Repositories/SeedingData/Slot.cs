using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.SeedingData
{
    public class Slot
    {
        public static readonly string SlotId1 = "1";
        public static readonly string SlotId2 = "2";

        public static readonly string ClassId1 = "1";
        public static readonly string ClassId2 = "2";

        public static readonly string Slot1Id = "1a2b3c4d5e6f7890a1b2c3d4e5f6a7b8";
        public static readonly string Slot2Id = "2b3c4d5e6f7a8b9c0d1e2f3a4b5c6d7e";
        public static readonly string Slot3Id = "3c4d5e6f7a8b9c0d1e2f3a4b5c6d7e8f";
        public static readonly string Slot4Id = "4d5e6f7a8b9c0d1e2f3a4b5c6d7e8f9a";

        public static readonly string BasicLessonId = "a1b2c3d4e5f67890a1b2c3d4e5f67890";

        public static readonly string QuickLearnerCourseId = "e75s896fa1b2c3d4e5f67890f1a2b3c4";

        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Entities.Slot>().HasData(
                new Models.Entities.Slot
                {
                    Date = new DateOnly(2025, 5, 11),
                    Id = SlotId1,
                    ClassId = ClassId1,
                    Status = 1,
                    ScheduleId = Slot1Id,
                    LessonId = BasicLessonId,
                    CreatedTime = new DateTimeOffset(new DateTime(2023, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 1, 1))
                },
                new Models.Entities.Slot
                {
                    Date = new DateOnly(2025, 5, 4),
                    Id = SlotId2,
                    ClassId = ClassId2,
                    Status = 1,
                    ScheduleId = Slot2Id,
                    LessonId = BasicLessonId,
                    CreatedTime = new DateTimeOffset(new DateTime(2023, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 1, 1))
                }
            );
        }
    }
}
