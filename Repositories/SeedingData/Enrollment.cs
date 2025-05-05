using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.SeedingData
{
    public class Enrollment
    {
        public static readonly string EnrollId1 = "a13448d9b78a4098a300783838d4bc15";
        public static readonly string EnrollId2 = "b56448d9b78a4098a300783838d4bc15";
        public static readonly string EnrollId3 = "c78448d9b78a4098a300783838d4bc15";
        public static readonly string EnrollId4 = "d84448d9b78a4098a300783838d4bc15";
        public static readonly string EnrollId5 = "e14448d9b78a4098a300783838d4bc15";
        public static readonly string EnrollId6 = "f95448d9b78a4098a300783838d4bc15";

        public static readonly string ClassId1 = "1";
        public static readonly string ClassId2 = "2";

        public static readonly string Dog3Id = "4e763c98bfd940168bfcc8bbcaa36f92";
        public static readonly string Dog6Id = "dc8c01d14f87485e910eb153d90d432c";
        public static readonly string Dog7Id = "e28448d9b78a4098a300783838d4bc15";

        public static readonly string CageId = "-1";

        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Entities.Enrollment>().HasData(
                new Models.Entities.Enrollment
                {
                    Id = EnrollId1,
                    Status = 2,
                    RequiredNightStay = false,
                    ClassId = ClassId1,
                    DogId = Dog3Id,
                    CageId = CageId,
                    CreatedTime = new DateTimeOffset(new DateTime(2023, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 1, 1))
                },
                new Models.Entities.Enrollment
                {
                    Id = EnrollId2,
                    Status = 2,
                    RequiredNightStay = false,
                    ClassId = ClassId1,
                    DogId = Dog6Id,
                    CageId = CageId,
                    CreatedTime = new DateTimeOffset(new DateTime(2023, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 1, 1))
                },
                new Models.Entities.Enrollment
                {
                    Id = EnrollId3,
                    Status = 2,
                    RequiredNightStay = false,
                    ClassId = ClassId1,
                    DogId = Dog7Id,
                    CageId = CageId,
                    CreatedTime = new DateTimeOffset(new DateTime(2023, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 1, 1))
                },
                new Models.Entities.Enrollment
                {
                    Id = EnrollId4,
                    Status = 1,
                    RequiredNightStay = false,
                    ClassId = ClassId2,
                    DogId = Dog3Id,
                    CageId = CageId,
                    CreatedTime = new DateTimeOffset(new DateTime(2023, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 1, 1))
                },
                new Models.Entities.Enrollment
                {
                    Id = EnrollId5,
                    Status = 1,
                    RequiredNightStay = false,
                    ClassId = ClassId2,
                    DogId = Dog6Id,
                    CageId = CageId,
                    CreatedTime = new DateTimeOffset(new DateTime(2023, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 1, 1))
                },
                new Models.Entities.Enrollment
                {
                    Id = EnrollId6,
                    Status = 1,
                    RequiredNightStay = false,
                    ClassId = ClassId2,
                    DogId = Dog7Id,
                    CageId = CageId,
                    CreatedTime = new DateTimeOffset(new DateTime(2023, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 1, 1))
                }
            );
        }
    }
}
