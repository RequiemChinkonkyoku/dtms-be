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
        public static readonly string CustomerDog1Id = "1a2b3c4d5e6f7g8h9i0j1k2l3m4n5o6p";
        public static readonly string CustomerDog2Id = "2b3c4d5e6f7g8h9i0j1k2l3m4n5o6p7q";
        public static readonly string CustomerDog3Id = "3c4d5e6f7g8h9i0j1k2l3m4n5o6p7q8r";
        public static readonly string CustomerDog4Id = "4d5e6f7g8h9i0j1k2l3m4n5o6p7q8r9s";
        public static readonly string CustomerDog5Id = "5e6f7g8h9i0j1k2l3m4n5o6p7q8r9s0t";
        public static readonly string CustomerDog6Id = "6f7g8h9i0j1k2l3m4n5o6p7q8r9s0t1u";
        public static readonly string CustomerDog7Id = "7g8h9i0j1k2l3m4n5o6p7q8r9s0t1u2v";
        public static readonly string CustomerDog8Id = "8h9i0j1k2l3m4n5o6p7q8r9s0t1u2v3w";
        public static readonly string CustomerDog9Id = "9i0j1k2l3m4n5o6p7q8r9s0t1u2v3w4x";
        public static readonly string CustomerDog10Id = "0j1k2l3m4n5o6p7q8r9s0t1u2v3w4x5y";
        public static readonly string CustomerDog11Id = "1k2l3m4n5o6p7q8r9s0t1u2v3w4x5y6z";
        public static readonly string CustomerDog12Id = "2l3m4n5o6p7q8r9s0t1u2v3w4x5y6z7a";
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
                },

                new Models.Entities.Dog
                {
                    Id = CustomerDog1Id,
                    Name = "Buddy",
                    ImageUrl = "https://res.cloudinary.com/djy6ydaxz/image/upload/v1740296126/k8lymjfwzbenlvfyt0ev.jpg",
                    DateOfBirth = new DateOnly(2020, 3, 15),
                    Gender = 1, // Male
                    Status = 1,
                    RegistrationTime = new DateTime(2021, 6, 10),
                    DogBreedId = DogBreed.LabradorRetrieverBreedId,
                    CreatedTime = new DateTimeOffset(new DateTime(2021, 6, 10)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 1, 15))
                },
                new Models.Entities.Dog
                {
                    Id = CustomerDog2Id,
                    Name = "Lola",
                    ImageUrl = "https://res.cloudinary.com/djy6ydaxz/image/upload/v1740296300/vozosvu7c92d3gbz9xmp.jpg",
                    DateOfBirth = new DateOnly(2022, 7, 22),
                    Gender = 0, // Female
                    Status = 1,
                    RegistrationTime = new DateTime(2022, 8, 5),
                    DogBreedId = DogBreed.PomeranianBreedId,
                    CreatedTime = new DateTimeOffset(new DateTime(2022, 8, 5)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 2, 20))
                },

                // Dogs for Sarah Williams (CustomerIndividual2)
                new Models.Entities.Dog
                {
                    Id = CustomerDog3Id,
                    Name = "Max",
                    ImageUrl = "https://res.cloudinary.com/djy6ydaxz/image/upload/v1740296126/k8lymjfwzbenlvfyt0ev.jpg",
                    DateOfBirth = new DateOnly(2019, 5, 10),
                    Gender = 1, // Male
                    Status = 1,
                    RegistrationTime = new DateTime(2021, 3, 15),
                    DogBreedId = DogBreed.GermanShepherdBreedId,
                    CreatedTime = new DateTimeOffset(new DateTime(2021, 3, 15)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 3, 10))
                },
                new Models.Entities.Dog
                {
                    Id = CustomerDog4Id,
                    Name = "Bella",
                    ImageUrl = "https://res.cloudinary.com/djy6ydaxz/image/upload/v1740296300/vozosvu7c92d3gbz9xmp.jpg",
                    DateOfBirth = new DateOnly(2021, 2, 28),
                    Gender = 0, // Female
                    Status = 1,
                    RegistrationTime = new DateTime(2021, 4, 5),
                    DogBreedId = DogBreed.GoldenRetrieverBreedId,
                    CreatedTime = new DateTimeOffset(new DateTime(2021, 4, 5)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 1, 30))
                },
                new Models.Entities.Dog
                {
                    Id = CustomerDog5Id,
                    Name = "Rocky",
                    ImageUrl = "https://res.cloudinary.com/djy6ydaxz/image/upload/v1740296214/wgpr6pg1jvkwrib4a1op.jpg",
                    DateOfBirth = new DateOnly(2020, 11, 15),
                    Gender = 1, // Male
                    Status = 1,
                    RegistrationTime = new DateTime(2022, 1, 20),
                    DogBreedId = DogBreed.BulldogBreedId,
                    CreatedTime = new DateTimeOffset(new DateTime(2022, 1, 20)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 4, 5))
                },

                // Dogs for Michael Brown (CustomerIndividual3)
                new Models.Entities.Dog
                {
                    Id = CustomerDog6Id,
                    Name = "Daisy",
                    ImageUrl = "https://res.cloudinary.com/djy6ydaxz/image/upload/v1740296265/inloikxoyxcakdmakrrk.jpg",
                    DateOfBirth = new DateOnly(2022, 4, 5),
                    Gender = 0, // Female
                    Status = 1,
                    RegistrationTime = new DateTime(2022, 6, 15),
                    DogBreedId = DogBreed.BeagleBreedId,
                    CreatedTime = new DateTimeOffset(new DateTime(2022, 6, 15)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 5, 10))
                },
                new Models.Entities.Dog
                {
                    Id = CustomerDog7Id,
                    Name = "Charlie",
                    ImageUrl = "https://res.cloudinary.com/djy6ydaxz/image/upload/v1740296126/k8lymjfwzbenlvfyt0ev.jpg",
                    DateOfBirth = new DateOnly(2021, 8, 12),
                    Gender = 1, // Male
                    Status = 1,
                    RegistrationTime = new DateTime(2022, 9, 1),
                    DogBreedId = DogBreed.FrenchBulldogBreedId,
                    CreatedTime = new DateTimeOffset(new DateTime(2022, 9, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 6, 15))
                },

                // Dogs for ABC Corporation (CustomerOrganization1)
                new Models.Entities.Dog
                {
                    Id = CustomerDog8Id,
                    Name = "Rex",
                    ImageUrl = "https://res.cloudinary.com/djy6ydaxz/image/upload/v1740296300/vozosvu7c92d3gbz9xmp.jpg",
                    DateOfBirth = new DateOnly(2018, 6, 20),
                    Gender = 1, // Male
                    Status = 1,
                    RegistrationTime = new DateTime(2019, 1, 10),
                    DogBreedId = DogBreed.RottweilerBreedId,
                    CreatedTime = new DateTimeOffset(new DateTime(2019, 1, 10)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 7, 20))
                },
                new Models.Entities.Dog
                {
                    Id = CustomerDog9Id,
                    Name = "Luna",
                    ImageUrl = "https://res.cloudinary.com/djy6ydaxz/image/upload/v1740296214/wgpr6pg1jvkwrib4a1op.jpg",
                    DateOfBirth = new DateOnly(2020, 9, 5),
                    Gender = 0, // Female
                    Status = 1,
                    RegistrationTime = new DateTime(2021, 2, 15),
                    DogBreedId = DogBreed.GermanShorthairedPointerBreedId,
                    CreatedTime = new DateTimeOffset(new DateTime(2021, 2, 15)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 8, 10))
                },
                new Models.Entities.Dog
                {
                    Id = CustomerDog10Id,
                    Name = "Thor",
                    ImageUrl = "https://res.cloudinary.com/djy6ydaxz/image/upload/v1740296265/inloikxoyxcakdmakrrk.jpg",
                    DateOfBirth = new DateOnly(2019, 12, 25),
                    Gender = 1, // Male
                    Status = 1,
                    RegistrationTime = new DateTime(2020, 3, 5),
                    DogBreedId = DogBreed.BoxerBreedId,
                    CreatedTime = new DateTimeOffset(new DateTime(2020, 3, 5)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 9, 5))
                },

                // Dogs for XYZ Enterprises (CustomerOrganization2)
                new Models.Entities.Dog
                {
                    Id = CustomerDog11Id,
                    Name = "Zoe",
                    ImageUrl = "https://res.cloudinary.com/djy6ydaxz/image/upload/v1740296126/k8lymjfwzbenlvfyt0ev.jpg",
                    DateOfBirth = new DateOnly(2021, 1, 15),
                    Gender = 0, // Female
                    Status = 1,
                    RegistrationTime = new DateTime(2021, 5, 20),
                    DogBreedId = DogBreed.DachshundBreedId,
                    CreatedTime = new DateTimeOffset(new DateTime(2021, 5, 20)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 10, 15))
                },
                new Models.Entities.Dog
                {
                    Id = CustomerDog12Id,
                    Name = "Zeus",
                    ImageUrl = "https://res.cloudinary.com/djy6ydaxz/image/upload/v1740296300/vozosvu7c92d3gbz9xmp.jpg",
                    DateOfBirth = new DateOnly(2020, 4, 10),
                    Gender = 1, // Male
                    Status = 1,
                    RegistrationTime = new DateTime(2020, 8, 15),
                    DogBreedId = DogBreed.SiberianHuskyBreedId,
                    CreatedTime = new DateTimeOffset(new DateTime(2020, 8, 15)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 11, 20))
                }

            );
        }
    }
}
