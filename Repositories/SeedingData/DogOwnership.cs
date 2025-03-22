using Microsoft.EntityFrameworkCore;
using Models.Entities;
using System;

namespace Repositories.SeedingData
{
    public static class DogOwnership
    {
        public static readonly string Ownership1Id = Guid.NewGuid().ToString("N");
        public static readonly string Ownership2Id = Guid.NewGuid().ToString("N");
        public static readonly string Ownership3Id = Guid.NewGuid().ToString("N");
        public static readonly string Ownership4Id = Guid.NewGuid().ToString("N");
        public static readonly string Ownership5Id = Guid.NewGuid().ToString("N");
        public static readonly string Ownership6Id = Guid.NewGuid().ToString("N");
        public static readonly string Ownership7Id = Guid.NewGuid().ToString("N");
        public static readonly string Ownership8Id = Guid.NewGuid().ToString("N");
        public static readonly string Ownership9Id = Guid.NewGuid().ToString("N");

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
                }
            );
        }
    }
}
