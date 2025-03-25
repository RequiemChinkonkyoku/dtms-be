using Microsoft.EntityFrameworkCore;
using Models.Entities;
using System;

namespace Repositories.SeedingData
{
    public static class Category
    {
        public static readonly string BasicTrainingId = "156552f4dc9942b5bc72a6bae94be821";
        public static readonly string AdvancedTrainingId = "f8cb65025770497e9a61c75501ed6cd3";
        public static readonly string BehavioralModificationId = "c44beb29575744b68c42cf4f70274a20";

        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Entities.Category>().HasData(
                new Models.Entities.Category
                {
                    Id = BasicTrainingId,
                    Name = "Basic Training",
                    Description = "Covers fundamental obedience commands and essential skills.",
                    Status = 1,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.Category
                {
                    Id = AdvancedTrainingId,
                    Name = "Advanced Training",
                    Description = "Focuses on advanced obedience and specialized training techniques.",
                    Status = 1,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.Category
                {
                    Id = BehavioralModificationId,
                    Name = "Behavioral Modification",
                    Description = "Addresses problem behaviors and corrective training for dogs.",
                    Status = 1,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                }
            );
        }
    }
}
