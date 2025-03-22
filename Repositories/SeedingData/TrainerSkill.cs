using Microsoft.EntityFrameworkCore;
using Models.Entities;
using System;

namespace Repositories.SeedingData
{
    public static class TrainerSkill
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Entities.TrainerSkill>().HasData(
                // Member Trainer (3 skills)
                new Models.Entities.TrainerSkill
                {
                    Id = Guid.NewGuid().ToString("N"),
                    TrainerId = Account.TrainerMemberId,
                    SkillId = Skill.BasicCommandsId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.TrainerSkill
                {
                    Id = Guid.NewGuid().ToString("N"),
                    TrainerId = Account.TrainerMemberId,
                    SkillId = Skill.AgilityTrainingId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.TrainerSkill
                {
                    Id = Guid.NewGuid().ToString("N"),
                    TrainerId = Account.TrainerMemberId,
                    SkillId = Skill.BehavioralCorrectionId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },

                // Lead Trainer (All 5 skills)
                new Models.Entities.TrainerSkill
                {
                    Id = Guid.NewGuid().ToString("N"),
                    TrainerId = Account.TrainerLeadId,
                    SkillId = Skill.BasicCommandsId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.TrainerSkill
                {
                    Id = Guid.NewGuid().ToString("N"),
                    TrainerId = Account.TrainerLeadId,
                    SkillId = Skill.AgilityTrainingId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.TrainerSkill
                {
                    Id = Guid.NewGuid().ToString("N"),
                    TrainerId = Account.TrainerLeadId,
                    SkillId = Skill.BehavioralCorrectionId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.TrainerSkill
                {
                    Id = Guid.NewGuid().ToString("N"),
                    TrainerId = Account.TrainerLeadId,
                    SkillId = Skill.SocializationId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.TrainerSkill
                {
                    Id = Guid.NewGuid().ToString("N"),
                    TrainerId = Account.TrainerLeadId,
                    SkillId = Skill.ProtectionTrainingId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                }
            );
        }
    }
}
