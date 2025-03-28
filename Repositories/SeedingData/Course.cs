using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.SeedingData
{
    public class Course
    {
        public static readonly string BasicCourseId = "f1a2b3c4d5e67890a1b2c3d4e5f67890";
        public static readonly string AgilityCourseId = "a2b3c4d5e67890a1b2c3d4e5f67890f1";
        public static readonly string BehavioralCorrectionCourseId = "b3c4d5e67890a1b2c3d4e5f67890f1a2";
        public static readonly string SocializationCourseId = "c4d5e67890a1b2c3d4e5f67890f1a2b3";
        public static readonly string ProtectionTrainingCourseId = "d5e67890a1b2c3d4e5f67890f1a2b3c4";

        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Entities.Course>().HasData(
                new Models.Entities.Course
                {
                    Id = BasicCourseId,
                    Name = "Basic Course",
                    Description = "For basic training",
                    Status = 1,
                    ImageUrl = "",
                    DurationInWeeks = 1,
                    DaysPerWeek = 1,
                    SlotsPerDay = 1,
                    Price = 100000,
                    MinDogs = 1,
                    MaxDogs = 4,
                    MinTrainers = 1,
                    MaxTrainers = 2,
                    Complexity = 1,
                    CreatedTrainerId = "54d3a3e95adc4b38885e43af50e12e42",
                    CategoryId = "156552f4dc9942b5bc72a6bae94be821",
                    CreatedTime = new DateTimeOffset(new DateTime(2023, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 1, 1))
                },
                new Models.Entities.Course
                {
                    Id = AgilityCourseId,
                    Name = "Agility Course",
                    Description = "Improve agility",
                    Status = 1,
                    ImageUrl = "",
                    DurationInWeeks = 2,
                    DaysPerWeek = 1,
                    SlotsPerDay = 1,
                    Price = 100000,
                    MinDogs = 1,
                    MaxDogs = 4,
                    MinTrainers = 1,
                    MaxTrainers = 2,
                    Complexity = 1,
                    CreatedTrainerId = "54d3a3e95adc4b38885e43af50e12e42",
                    CategoryId = "156552f4dc9942b5bc72a6bae94be821",
                    CreatedTime = new DateTimeOffset(new DateTime(2023, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 1, 1))
                },
                new Models.Entities.Course
                {
                    Id = BehavioralCorrectionCourseId,
                    Name = "Behavioral Correction Course",
                    Description = "Correct bad behaviors",
                    Status = 1,
                    ImageUrl = "",
                    DurationInWeeks = 2,
                    DaysPerWeek = 1,
                    SlotsPerDay = 1,
                    Price = 100000,
                    MinDogs = 1,
                    MaxDogs = 4,
                    MinTrainers = 1,
                    MaxTrainers = 2,
                    Complexity = 1,
                    CreatedTrainerId = "54d3a3e95adc4b38885e43af50e12e42",
                    CategoryId = "c44beb29575744b68c42cf4f70274a20",
                    CreatedTime = new DateTimeOffset(new DateTime(2023, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 1, 1))
                },
                new Models.Entities.Course
                {
                    Id = SocializationCourseId,
                    Name = "Socialization Course",
                    Description = "Improve socializing skill",
                    Status = 1,
                    ImageUrl = "",
                    DurationInWeeks = 2,
                    DaysPerWeek = 1,
                    SlotsPerDay = 1,
                    Price = 100000,
                    MinDogs = 1,
                    MaxDogs = 4,
                    MinTrainers = 1,
                    MaxTrainers = 2,
                    Complexity = 1,
                    CreatedTrainerId = "54d3a3e95adc4b38885e43af50e12e42",
                    CategoryId = "156552f4dc9942b5bc72a6bae94be821",
                    CreatedTime = new DateTimeOffset(new DateTime(2023, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 1, 1))
                },
                new Models.Entities.Course
                {
                    Id = ProtectionTrainingCourseId,
                    Name = "Protection Trainging Course",
                    Description = "Traing for protection",
                    Status = 1,
                    ImageUrl = "",
                    DurationInWeeks = 3,
                    DaysPerWeek = 1,
                    SlotsPerDay = 1,
                    Price = 100000,
                    MinDogs = 1,
                    MaxDogs = 4,
                    MinTrainers = 1,
                    MaxTrainers = 2,
                    Complexity = 1,
                    CreatedTrainerId = "54d3a3e95adc4b38885e43af50e12e42",
                    CategoryId = "f8cb65025770497e9a61c75501ed6cd3",
                    CreatedTime = new DateTimeOffset(new DateTime(2023, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 1, 1))
                }
            );
        }
    }
}
