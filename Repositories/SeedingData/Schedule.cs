using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.SeedingData
{
    public class Schedule
    {
        public static readonly string Slot1Id = "1a2b3c4d5e6f7890a1b2c3d4e5f6a7b8";
        public static readonly string Slot2Id = "2b3c4d5e6f7a8b9c0d1e2f3a4b5c6d7e";
        public static readonly string Slot3Id = "3c4d5e6f7a8b9c0d1e2f3a4b5c6d7e8f";
        public static readonly string Slot4Id = "4d5e6f7a8b9c0d1e2f3a4b5c6d7e8f9a";

        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Entities.Schedule>().HasData(
                new Models.Entities.Schedule
                {
                    Id = Slot1Id,
                    StartTime = new TimeOnly(8, 0),
                    EndTime = new TimeOnly(10, 0),
                    CreatedTime = new DateTimeOffset(new DateTime(2023, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 1, 1))
                },
                new Models.Entities.Schedule
                {
                    Id = Slot2Id,
                    StartTime = new TimeOnly(10, 0),
                    EndTime = new TimeOnly(12, 0),
                    CreatedTime = new DateTimeOffset(new DateTime(2023, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 1, 1))
                },
                new Models.Entities.Schedule
                {
                    Id = Slot3Id,
                    StartTime = new TimeOnly(13, 0),
                    EndTime = new TimeOnly(15, 0),
                    CreatedTime = new DateTimeOffset(new DateTime(2023, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 1, 1))
                },
                new Models.Entities.Schedule
                {
                    Id = Slot4Id,
                    StartTime = new TimeOnly(15, 0),
                    EndTime = new TimeOnly(17, 0),
                    CreatedTime = new DateTimeOffset(new DateTime(2023, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 1, 1))
                }
            );
        }
    }
}