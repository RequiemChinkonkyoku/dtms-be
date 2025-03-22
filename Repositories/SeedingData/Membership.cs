using Microsoft.EntityFrameworkCore;
using Models.Entities;
using System;

namespace Repositories.SeedingData
{
    public static class Membership
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Entities.Membership>().HasData(
                new Models.Entities.Membership
                {
                    Id = Guid.NewGuid().ToString("N"),
                    Name = "Basic",
                    RequiredPoints = 0,
                    Description = "Entry-level membership with standard benefits",
                    DiscountAmount = 0m,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.Membership
                {
                    Id = Guid.NewGuid().ToString("N"),
                    Name = "Gold",
                    RequiredPoints = 500,
                    Description = "Premium membership with exclusive discounts",
                    DiscountAmount = 10m,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.Membership
                {
                    Id = Guid.NewGuid().ToString("N"),
                    Name = "Platinum",
                    RequiredPoints = 1000,
                    Description = "Elite membership with the highest privileges",
                    DiscountAmount = 20m,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                }
            );
        }
    }
}