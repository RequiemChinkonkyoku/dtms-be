using Microsoft.EntityFrameworkCore;
using Models.Entities;
using System;

namespace Repositories.SeedingData
{
    public static class Membership
    {
        public static readonly string BasicMembershipId = Guid.NewGuid().ToString("N");
        public static readonly string GoldMembershipId = Guid.NewGuid().ToString("N");
        public static readonly string PlatinumMembershipId = Guid.NewGuid().ToString("N");

        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Entities.Membership>().HasData(
                new Models.Entities.Membership
                {
                    Id = BasicMembershipId,
                    Name = "Basic",
                    RequiredPoints = 0,
                    Description = "Entry-level membership",
                    DiscountAmount = 0m,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.Membership
                {
                    Id = GoldMembershipId,
                    Name = "Gold",
                    RequiredPoints = 500,
                    Description = "Premium membership",
                    DiscountAmount = 10m,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.Membership
                {
                    Id = PlatinumMembershipId,
                    Name = "Platinum",
                    RequiredPoints = 1000,
                    Description = "Elite membership",
                    DiscountAmount = 20m,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                }
            );
        }
    }
}