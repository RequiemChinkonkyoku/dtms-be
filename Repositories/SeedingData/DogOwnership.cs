using Microsoft.EntityFrameworkCore;
using Models.Entities;
using System;

namespace Repositories.SeedingData
{
    public static class DogOwnership
    {
        public static readonly string Ownership1Id = "1a2b3c4d5e6f7890a1b2c3d4e5f67890";
        public static readonly string Ownership2Id = "2b3c4d5e6f7890a1b2c3d4e5f678901a";
        public static readonly string Ownership3Id = "3c4d5e6f7890a1b2c3d4e5f678901a2b";
        public static readonly string Ownership4Id = "4d5e6f7890a1b2c3d4e5f678901a2b3c";
        public static readonly string Ownership5Id = "5e6f7890a1b2c3d4e5f678901a2b3c4d";
        public static readonly string Ownership6Id = "6f7890a1b2c3d4e5f678901a2b3c4d5e";
        public static readonly string Ownership7Id = "7890a1b2c3d4e5f678901a2b3c4d5e6f";
        public static readonly string Ownership8Id = "90a1b2c3d4e5f678901a2b3c4d5e6f78";
        public static readonly string Ownership9Id = "a1b2c3d4e5f678901a2b3c4d5e6f7890";

        public static readonly string AlexDog1Id = "418632b5-df1c-4711-a8a0-7f465a0df76d";

        public static readonly string AlexDog2Id = "30005b68-a32c-470b-83e5-97ea8f262c39";

        public static readonly string SarahDog1Id = "78da1a94-e3c4-43e6-9bf3-965d018dc3d2";
        public static readonly string SarahDog2Id = "c39435b1-5bf9-44cf-9379-b389eeaaca12";
        public static readonly string SarahDog3Id = "bd78edba-a5df-4653-8222-90359b3a9e6d";

        public static readonly string MichaelDog1Id = "d50b4068-0a47-432c-b650-ec3791fb466b";
        public static readonly string MichaelDog2Id = "e280e786-0bbf-4a50-9456-dc7d48e9193d";

        public static readonly string AbcCorpDog1Id = "7e8e6f28-a7cc-4015-bac9-4e82eb75fc2d";
        public static readonly string AbcCorpDog2Id = "24517aa8-430d-4ba8-a099-ee9fe2569ce3";
        public static readonly string AbcCorpDog3Id = "b11355e4-a09d-4e5c-b459-7cff8b9a1d21";

        public static readonly string XyzEntDog1Id = "dece629f-b9f9-4fad-9dc3-8ab8dafd0ac4";
        public static readonly string XyzEntDog2Id = "8d735322-c7d3-40bc-9b62-e1d9d8ca20e3";
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Entities.DogOwnership>().HasData(
                // Individual gets 2 dogs
                new Models.Entities.DogOwnership
                {
                    Id = Ownership1Id,
                    FromDate = new DateOnly(2023, 1, 1),
                    ToDate = null,
                    CustomerId = Account.CustomerIndividualId,
                    DogId = Dog.Dog1Id,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogOwnership
                {
                    Id = Ownership2Id,
                    FromDate = new DateOnly(2023, 3, 15),
                    ToDate = null,
                    CustomerId = Account.CustomerIndividualId,
                    DogId = Dog.Dog2Id,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },

                // Organization gets 7 dogs
                new Models.Entities.DogOwnership
                {
                    Id = Ownership3Id,
                    FromDate = new DateOnly(2022, 6, 10),
                    ToDate = null,
                    CustomerId = Account.CustomerOrganizationId,
                    DogId = Dog.Dog3Id,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogOwnership
                {
                    Id = Ownership4Id,
                    FromDate = new DateOnly(2021, 9, 5),
                    ToDate = null,
                    CustomerId = Account.CustomerOrganizationId,
                    DogId = Dog.Dog4Id,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogOwnership
                {
                    Id = Ownership5Id,
                    FromDate = new DateOnly(2020, 4, 20),
                    ToDate = null,
                    CustomerId = Account.CustomerOrganizationId,
                    DogId = Dog.Dog5Id,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogOwnership
                {
                    Id = Ownership6Id,
                    FromDate = new DateOnly(2022, 8, 12),
                    ToDate = null,
                    CustomerId = Account.CustomerOrganizationId,
                    DogId = Dog.Dog6Id,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogOwnership
                {
                    Id = Ownership7Id,
                    FromDate = new DateOnly(2023, 2, 14),
                    ToDate = null,
                    CustomerId = Account.CustomerOrganizationId,
                    DogId = Dog.Dog7Id,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogOwnership
                {
                    Id = Ownership8Id,
                    FromDate = new DateOnly(2023, 5, 7),
                    ToDate = null,
                    CustomerId = Account.CustomerOrganizationId,
                    DogId = Dog.Dog8Id,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogOwnership
                {
                    Id = Ownership9Id,
                    FromDate = new DateOnly(2023, 7, 22),
                    ToDate = null,
                    CustomerId = Account.CustomerOrganizationId,
                    DogId = Dog.Dog9Id,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogOwnership
                {
                    Id = AlexDog1Id,
                    FromDate = new DateOnly(2021, 6, 10),
                    ToDate = null, // Current owner
                    CustomerId = Account.CustomerIndividual1Id,
                    DogId = Dog.CustomerDog1Id, // Buddy the Labrador
                    CreatedTime = new DateTimeOffset(new DateTime(2021, 6, 10)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 1, 15))
                },
                new Models.Entities.DogOwnership
                {
                    Id = AlexDog2Id,
                    FromDate = new DateOnly(2022, 8, 5),
                    ToDate = null, // Current owner
                    CustomerId = Account.CustomerIndividual1Id,
                    DogId = Dog.CustomerDog2Id, // Lola the Pomeranian
                    CreatedTime = new DateTimeOffset(new DateTime(2022, 8, 5)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 2, 20))
                },

                // Sarah Williams (Individual) - 3 dogs
                new Models.Entities.DogOwnership
                {
                    Id = SarahDog1Id,
                    FromDate = new DateOnly(2021, 3, 15),
                    ToDate = null, // Current owner
                    CustomerId = Account.CustomerIndividual2Id,
                    DogId = Dog.CustomerDog3Id, // Max the German Shepherd
                    CreatedTime = new DateTimeOffset(new DateTime(2021, 3, 15)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 3, 10))
                },
                new Models.Entities.DogOwnership
                {
                    Id = SarahDog2Id,
                    FromDate = new DateOnly(2021, 4, 5),
                    ToDate = null, // Current owner
                    CustomerId = Account.CustomerIndividual2Id,
                    DogId = Dog.CustomerDog4Id, // Bella the Golden Retriever
                    CreatedTime = new DateTimeOffset(new DateTime(2021, 4, 5)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 1, 30))
                },
                new Models.Entities.DogOwnership
                {
                    Id = SarahDog3Id,
                    FromDate = new DateOnly(2022, 1, 20),
                    ToDate = null, // Current owner
                    CustomerId = Account.CustomerIndividual2Id,
                    DogId = Dog.CustomerDog5Id, // Rocky the Bulldog
                    CreatedTime = new DateTimeOffset(new DateTime(2022, 1, 20)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 4, 5))
                },

                // Michael Brown (Individual) - 2 dogs
                new Models.Entities.DogOwnership
                {
                    Id = MichaelDog1Id,
                    FromDate = new DateOnly(2022, 6, 15),
                    ToDate = null, // Current owner
                    CustomerId = Account.CustomerIndividual3Id,
                    DogId = Dog.CustomerDog6Id, // Daisy the Beagle
                    CreatedTime = new DateTimeOffset(new DateTime(2022, 6, 15)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 5, 10))
                },
                new Models.Entities.DogOwnership
                {
                    Id = MichaelDog2Id,
                    FromDate = new DateOnly(2022, 9, 1),
                    ToDate = null, // Current owner
                    CustomerId = Account.CustomerIndividual3Id,
                    DogId = Dog.CustomerDog7Id, // Charlie the French Bulldog
                    CreatedTime = new DateTimeOffset(new DateTime(2022, 9, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 6, 15))
                },

                // ABC Corporation (Organization) - 3 dogs
                new Models.Entities.DogOwnership
                {
                    Id = AbcCorpDog1Id,
                    FromDate = new DateOnly(2019, 1, 10),
                    ToDate = null, // Current owner
                    CustomerId = Account.CustomerOrganization1Id,
                    DogId = Dog.CustomerDog8Id, // Rex the Rottweiler
                    CreatedTime = new DateTimeOffset(new DateTime(2019, 1, 10)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 7, 20))
                },
                new Models.Entities.DogOwnership
                {
                    Id = AbcCorpDog2Id,
                    FromDate = new DateOnly(2021, 2, 15),
                    ToDate = null, // Current owner
                    CustomerId = Account.CustomerOrganization1Id,
                    DogId = Dog.CustomerDog9Id, // Luna the German Shorthaired Pointer
                    CreatedTime = new DateTimeOffset(new DateTime(2021, 2, 15)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 8, 10))
                },
                new Models.Entities.DogOwnership
                {
                    Id = AbcCorpDog3Id,
                    FromDate = new DateOnly(2020, 3, 5),
                    ToDate = null, // Current owner
                    CustomerId = Account.CustomerOrganization1Id,
                    DogId = Dog.CustomerDog10Id, // Thor the Boxer
                    CreatedTime = new DateTimeOffset(new DateTime(2020, 3, 5)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 9, 5))
                },

                // XYZ Enterprises (Organization) - 2 dogs
                new Models.Entities.DogOwnership
                {
                    Id = XyzEntDog1Id,
                    FromDate = new DateOnly(2021, 5, 20),
                    ToDate = null, // Current owner
                    CustomerId = Account.CustomerOrganization2Id,
                    DogId = Dog.CustomerDog11Id, // Zoe the Dachshund
                    CreatedTime = new DateTimeOffset(new DateTime(2021, 5, 20)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 10, 15))
                },
                new Models.Entities.DogOwnership
                {
                    Id = XyzEntDog2Id,
                    FromDate = new DateOnly(2020, 8, 15),
                    ToDate = null, // Current owner
                    CustomerId = Account.CustomerOrganization2Id,
                    DogId = Dog.CustomerDog12Id, // Zeus the Siberian Husky
                    CreatedTime = new DateTimeOffset(new DateTime(2020, 8, 15)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 11, 20))
                }
            );
        }
    }
}
