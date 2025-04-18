using Microsoft.EntityFrameworkCore;
using Models.Entities;
using System;

namespace Repositories.SeedingData
{
    public static class Skill
    {
        public static readonly string BasicCommandsId = "1a2b3c4d5e6f78901a2b3c4d5e6f7890";
        public static readonly string AgilityTrainingId = "2b3c4d5e6f78901a2b3c4d5e6f78901a";
        public static readonly string BehavioralCorrectionId = "3c4d5e6f78901a2b3c4d5e6f78901a2b";
        public static readonly string SocializationId = "4d5e6f78901a2b3c4d5e6f78901a2b3c";
        public static readonly string ProtectionTrainingId = "5e6f78901a2b3c4d5e6f78901a2b3c4d";
        public static readonly string RevisionSkillId = "6f78901a2b3c4d5e6f78901a2b3c4d5e";

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
                },
                new Models.Entities.Skill
                {
                    Id = RevisionSkillId,
                    Name = "Revision",
                    Description = "Covers all previously taught skills for reinforcement",
                    Status = 1,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                }
            );
        }
    }
}
