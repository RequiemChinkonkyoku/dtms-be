using Microsoft.EntityFrameworkCore;
using Models.Entities;
using System;

namespace Repositories.SeedingData
{
    public static class Membership
    {
        public static readonly string BasicMembershipId = "a1b2c3d4e5f67890a1b2c3d4e5f67890";
        public static readonly string GoldMembershipId = "b2c3d4e5f67890a1b2c3d4e5f67890a1";
        public static readonly string PlatinumMembershipId = "c3d4e5f67890a1b2c3d4e5f67890a1b2";

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