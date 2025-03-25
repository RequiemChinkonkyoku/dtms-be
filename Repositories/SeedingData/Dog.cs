using Microsoft.EntityFrameworkCore;
using Models.Entities;
using System;

namespace Repositories.SeedingData
{
    public static class Dog
    {
        public static readonly string Dog1Id = "2ea60c66720d4571833911be746470a8";
        public static readonly string Dog2Id = "468c7f90cef546d1a336b133ce986031";
        public static readonly string Dog3Id = "4e763c98bfd940168bfcc8bbcaa36f92";
        public static readonly string Dog4Id = "8487615b64754cc2be8401202ffad21e";
        public static readonly string Dog5Id = "bbf004a7a5c24d1b989bc7110a5c56c3";
        public static readonly string Dog6Id = "dc8c01d14f87485e910eb153d90d432c";
        public static readonly string Dog7Id = "e28448d9b78a4098a300783838d4bc15";
        public static readonly string Dog8Id = "f153eb7f29934c30908c68fc668e01d7";
        public static readonly string Dog9Id = "fe7077791778468984040eeec2ae731e";

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
