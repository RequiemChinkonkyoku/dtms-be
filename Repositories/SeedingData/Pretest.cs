using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.SeedingData
{
    public class Pretest
    {
        public static readonly string PretestId1 = "1";
        public static readonly string PretestId2 = "2";
        public static readonly string PretestId3 = "3";

        public static readonly string ClassId1 = "1";
        public static readonly string ClassId2 = "2";

        public static readonly string Dog3Id = "4e763c98bfd940168bfcc8bbcaa36f92";
        public static readonly string Dog6Id = "dc8c01d14f87485e910eb153d90d432c";
        public static readonly string Dog7Id = "e28448d9b78a4098a300783838d4bc15";

        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Entities.PreTest>().HasData(
                new Models.Entities.PreTest
                {
                    Id = PretestId1,
                    TestDate = new DateOnly(2025, 5, 4),
                    Status = 0, 
                    Note = "None",
                    DogId = Dog3Id,
                    ClassId = ClassId1,
                    CreatedTime = new DateTimeOffset(new DateTime(2023, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 1, 1))
                },
                new Models.Entities.PreTest
                {
                    Id = PretestId2,
                    TestDate = new DateOnly(2025, 5, 4),
                    Status = 0,
                    Note = "None",
                    DogId = Dog6Id,
                    ClassId = ClassId1,
                    CreatedTime = new DateTimeOffset(new DateTime(2023, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 1, 1))
                },
                new Models.Entities.PreTest
                {
                    Id = PretestId3,
                    TestDate = new DateOnly(2025, 5, 4),
                    Status = 0,
                    Note = "None",
                    DogId = Dog7Id,
                    ClassId = ClassId1,
                    CreatedTime = new DateTimeOffset(new DateTime(2023, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 1, 1))
                }
            );
        }
    }
}
