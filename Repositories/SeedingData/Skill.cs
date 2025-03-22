using Microsoft.EntityFrameworkCore;
using Models.Entities;
using System;

namespace Repositories.SeedingData
{
    public static class Skill
    {
        public static readonly string BasicCommandsId = Guid.NewGuid().ToString("N");
        public static readonly string AgilityTrainingId = Guid.NewGuid().ToString("N");
        public static readonly string BehavioralCorrectionId = Guid.NewGuid().ToString("N");
        public static readonly string SocializationId = Guid.NewGuid().ToString("N");
        public static readonly string ProtectionTrainingId = Guid.NewGuid().ToString("N");

        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Entities.Skill>().HasData(
                new Models.Entities.Skill
                {
                    Id = BasicCommandsId,
                    Name = "Basic Commands",
                    Description = "Training dogs to follow basic commands like sit, stay, and come.",
                    Status = 1,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.Skill
                {
                    Id = AgilityTrainingId,
                    Name = "Agility Training",
                    Description = "Enhancing a dog's physical abilities and responsiveness through obstacle courses.",
                    Status = 1,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.Skill
                {
                    Id = BehavioralCorrectionId,
                    Name = "Behavioral Correction",
                    Description = "Addressing and correcting unwanted behaviors in dogs.",
                    Status = 1,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.Skill
                {
                    Id = SocializationId,
                    Name = "Socialization",
                    Description = "Helping dogs become comfortable around other animals and people.",
                    Status = 1,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.Skill
                {
                    Id = ProtectionTrainingId,
                    Name = "Protection Training",
                    Description = "Training dogs for guarding and protective behavior.",
                    Status = 1,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                }
            );
        }
    }
}
