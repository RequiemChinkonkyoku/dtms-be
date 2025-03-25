using Microsoft.EntityFrameworkCore;
using Models.Entities;
using System;

namespace Repositories.SeedingData
{
    public static class Equipment
    {
        public static readonly string ClickerId = "a1b2c3d4e5f67890a1b2c3d4e5f67890";
        public static readonly string HarnessId = "b2c3d4e5f67890a1b2c3d4e5f67890a1";
        public static readonly string BrushId = "c3d4e5f67890a1b2c3d4e5f67890a1b2";

        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Entities.Equipment>().HasData(
                new Models.Entities.Equipment
                {
                    Id = ClickerId,
                    Name = "Training Clicker",
                    Description = "A clicker used for positive reinforcement training.",
                    Status = 1,
                    EquipmentCategoryId = EquipmentCategory.TrainingToolsId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.Equipment
                {
                    Id = HarnessId,
                    Name = "Dog Harness",
                    Description = "A comfortable harness designed for safety and control.",
                    Status = 1,
                    EquipmentCategoryId = EquipmentCategory.SafetyGearId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.Equipment
                {
                    Id = BrushId,
                    Name = "Grooming Brush",
                    Description = "A brush for maintaining a dog's coat and hygiene.",
                    Status = 1,
                    EquipmentCategoryId = EquipmentCategory.GroomingEquipmentId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                }
            );
        }
    }
}
