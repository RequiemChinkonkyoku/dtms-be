using Microsoft.EntityFrameworkCore;
using Models.Entities;
using System;

namespace Repositories.SeedingData
{
    public static class EquipmentCategory
    {
        public static readonly string TrainingToolsId = "d4e5f67890a1b2c3d4e5f67890a1b2c3";
        public static readonly string SafetyGearId = "e5f67890a1b2c3d4e5f67890a1b2c3d4";
        public static readonly string GroomingEquipmentId = "f67890a1b2c3d4e5f67890a1b2c3d4e5";

        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Entities.EquipmentCategory>().HasData(
                new Models.Entities.EquipmentCategory
                {
                    Id = TrainingToolsId,
                    Name = "Training Tools",
                    Description = "Equipment used for dog training and obedience exercises.",
                    Status = 1,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.EquipmentCategory
                {
                    Id = SafetyGearId,
                    Name = "Safety Gear",
                    Description = "Protective gear for dogs, such as harnesses and pads.",
                    Status = 1,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.EquipmentCategory
                {
                    Id = GroomingEquipmentId,
                    Name = "Grooming Equipment",
                    Description = "Tools used for dog grooming, including brushes and clippers.",
                    Status = 1,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                }
            );
        }
    }
}
