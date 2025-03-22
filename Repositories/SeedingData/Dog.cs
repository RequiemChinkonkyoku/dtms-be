using Microsoft.EntityFrameworkCore;
using Models.Entities;
using System;

namespace Repositories.SeedingData
{
    public static class Dog
    {
        public static readonly string Dog1Id = Guid.NewGuid().ToString("N");
        public static readonly string Dog2Id = Guid.NewGuid().ToString("N");
        public static readonly string Dog3Id = Guid.NewGuid().ToString("N");
        public static readonly string Dog4Id = Guid.NewGuid().ToString("N");
        public static readonly string Dog5Id = Guid.NewGuid().ToString("N");
        public static readonly string Dog6Id = Guid.NewGuid().ToString("N");
        public static readonly string Dog7Id = Guid.NewGuid().ToString("N");
        public static readonly string Dog8Id = Guid.NewGuid().ToString("N");
        public static readonly string Dog9Id = Guid.NewGuid().ToString("N");

        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Entities.Dog>().HasData(
                new Models.Entities.Dog
                {
                    Id = Dog1Id,
                    Name = "Bella",
                    ImageUrl = "https://example.com/dog1.jpg",
                    DateOfBirth = new DateOnly(2021, 5, 15),
                    Gender = 0, // Female
                    Status = 1,
                    RegistrationTime = new DateTime(2000, 1, 1),
                    DogBreedId = DogBreed.ChihuahuaBreedId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.Dog
                {
                    Id = Dog2Id,
                    Name = "Rocky",
                    ImageUrl = "https://example.com/dog2.jpg",
                    DateOfBirth = new DateOnly(2020, 8, 22),
                    Gender = 1, // Male
                    Status = 1,
                    RegistrationTime = new DateTime(2000, 1, 1),
                    DogBreedId = DogBreed.PomeranianBreedId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.Dog
                {
                    Id = Dog3Id,
                    Name = "Luna",
                    ImageUrl = "https://example.com/dog3.jpg",
                    DateOfBirth = new DateOnly(2022, 1, 30),
                    Gender = 0,
                    Status = 1,
                    RegistrationTime = new DateTime(2000, 1, 1),
                    DogBreedId = DogBreed.FrenchBulldogBreedId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.Dog
                {
                    Id = Dog4Id,
                    Name = "Charlie",
                    ImageUrl = "https://example.com/dog4.jpg",
                    DateOfBirth = new DateOnly(2019, 12, 5),
                    Gender = 1,
                    Status = 1,
                    RegistrationTime = new DateTime(2000, 1, 1),
                    DogBreedId = DogBreed.CockerSpanielBreedId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.Dog
                {
                    Id = Dog5Id,
                    Name = "Max",
                    ImageUrl = "https://example.com/dog5.jpg",
                    DateOfBirth = new DateOnly(2021, 7, 18),
                    Gender = 1,
                    Status = 1,
                    RegistrationTime = new DateTime(2000, 1, 1),
                    DogBreedId = DogBreed.BorderCollieBreedId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.Dog
                {
                    Id = Dog6Id,
                    Name = "Daisy",
                    ImageUrl = "https://example.com/dog6.jpg",
                    DateOfBirth = new DateOnly(2020, 6, 10),
                    Gender = 0,
                    Status = 1,
                    RegistrationTime = new DateTime(2000, 1, 1),
                    DogBreedId = DogBreed.BeagleBreedId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.Dog
                {
                    Id = Dog7Id,
                    Name = "Buddy",
                    ImageUrl = "https://example.com/dog7.jpg",
                    DateOfBirth = new DateOnly(2018, 11, 25),
                    Gender = 1,
                    Status = 1,
                    RegistrationTime = new DateTime(2000, 1, 1),
                    DogBreedId = DogBreed.GoldenRetrieverBreedId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.Dog
                {
                    Id = Dog8Id,
                    Name = "Rex",
                    ImageUrl = "https://example.com/dog8.jpg",
                    DateOfBirth = new DateOnly(2019, 9, 14),
                    Gender = 1,
                    Status = 1,
                    RegistrationTime = new DateTime(2000, 1, 1),
                    DogBreedId = DogBreed.GermanShepherdBreedId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.Dog
                {
                    Id = Dog9Id,
                    Name = "Zara",
                    ImageUrl = "https://example.com/dog9.jpg",
                    DateOfBirth = new DateOnly(2021, 3, 8),
                    Gender = 0,
                    Status = 1,
                    RegistrationTime = new DateTime(2000, 1, 1),
                    DogBreedId = DogBreed.RottweilerBreedId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                }
            );
        }
    }
}
