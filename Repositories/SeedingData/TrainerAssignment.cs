using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.SeedingData
{
    public class TrainerAssignment
    {
        public static readonly string TrainerAssignId1 = "1";
        public static readonly string TrainerAssignId2 = "2";

        public static readonly string ClassId1 = "1";
        public static readonly string ClassId2 = "2";

        public static readonly string TrainerMember5Id = "e5f648a9b0c1d2e3f4a5b6c7d8e9f0a1";

        public static readonly string QuickLearnerCourseId = "e75s896fa1b2c3d4e5f67890f1a2b3c4";

        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Entities.TrainerAssignment>().HasData(
                new Models.Entities.TrainerAssignment
                {
                    Id = TrainerAssignId1,
                    ClassId = ClassId1,
                    TrainerId = TrainerMember5Id,
                    CreatedTime = new DateTimeOffset(new DateTime(2023, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 1, 1))
                },
                new Models.Entities.TrainerAssignment
                {
                    Id = TrainerAssignId2,
                    ClassId = ClassId2,
                    TrainerId = TrainerMember5Id,
                    CreatedTime = new DateTimeOffset(new DateTime(2023, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 1, 1))
                }
            );
        }
    }
}
