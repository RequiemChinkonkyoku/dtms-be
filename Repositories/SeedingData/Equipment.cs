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

        public static readonly string TrainingLeashId = "d4e5f67890a1b2c3d4e5f67890a1b2c3";
        public static readonly string AgilityPolesId = "e5f67890a1b2c3d4e5f67890a1b2c3d4";
        public static readonly string TreatPouchId = "f67890a1b2c3d4e5f67890a1b2c3d4e5";
        public static readonly string WhistleId = "7890a1b2c3d4e5f67890a1b2c3d4e5f6";
        public static readonly string TargetStickId = "890a1b2c3d4e5f67890a1b2c3d4e5f67";
        public static readonly string TugToyId = "90a1b2c3d4e5f67890a1b2c3d4e5f678";
        public static readonly string PuzzleFeederId = "0a1b2c3d4e5f67890a1b2c3d4e5f6789";
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
                },
                new Models.Entities.Equipment
                {
                    Id = TrainingLeashId,
                    Name = "Training Leash",
                    Description = "6-foot leash with multiple handles for control during training.",
                    Status = 1,
                    EquipmentCategoryId = EquipmentCategory.TrainingToolsId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.Equipment
                {
                    Id = AgilityPolesId,
                    Name = "Agility Training Poles",
                    Description = "Set of adjustable poles for agility and obstacle training.",
                    Status = 1,
                    EquipmentCategoryId = EquipmentCategory.TrainingToolsId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.Equipment
                {
                    Id = TreatPouchId,
                    Name = "Training Treat Pouch",
                    Description = "Waist-worn pouch for easy access to training treats.",
                    Status = 1,
                    EquipmentCategoryId = EquipmentCategory.TrainingToolsId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.Equipment
                {
                    Id = WhistleId,
                    Name = "Training Whistle",
                    Description = "High-pitched whistle for recall and command training.",
                    Status = 1,
                    EquipmentCategoryId = EquipmentCategory.TrainingToolsId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.Equipment
                {
                    Id = TargetStickId,
                    Name = "Target Training Stick",
                    Description = "Adjustable stick with target ball for precision training.",
                    Status = 1,
                    EquipmentCategoryId = EquipmentCategory.TrainingToolsId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.Equipment
                {
                    Id = TugToyId,
                    Name = "Tug Training Toy",
                    Description = "Durable tug toy for reward-based training and play.",
                    Status = 1,
                    EquipmentCategoryId = EquipmentCategory.TrainingToolsId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.Equipment
                {
                    Id = PuzzleFeederId,
                    Name = "Puzzle Feeder",
                    Description = "Interactive puzzle toy for mental stimulation training.",
                    Status = 1,
                    EquipmentCategoryId = EquipmentCategory.TrainingToolsId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                }
            );
        }
    }
}
