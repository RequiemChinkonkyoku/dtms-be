using Microsoft.EntityFrameworkCore;
using Models.Entities;
using System;

namespace Repositories.SeedingData
{
    public static class DogType
    {
        public static readonly string SmallDogTypeId = "d1e2f3a4b5c67890d1e2f3a4b5c67890";
        public static readonly string MediumDogTypeId = "e2f3a4b5c67890d1e2f3a4b5c67890d1";
        public static readonly string LargeDogTypeId = "f3a4b5c67890d1e2f3a4b5c67890d1e2";

        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Entities.DogType>().HasData(
                new Models.Entities.DogType
                {
                    Id = SmallDogTypeId,
                    Name = "Small",
                    Description = "Small-sized dog breeds",
                    Status = 1,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogType
                {
                    Id = MediumDogTypeId,
                    Name = "Medium",
                    Description = "Medium-sized dog breeds",
                    Status = 1,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogType
                {
                    Id = LargeDogTypeId,
                    Name = "Large",
                    Description = "Large-sized dog breeds",
                    Status = 1,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                }
            );
        }
    }
}