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
                    Id = "a1b2c3d4e5f6478a9b0c1d2e3f4g5678",
                    TrainerId = Account.TrainerMemberId,
                    SkillId = Skill.BasicCommandsId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.TrainerSkill
                {
                    Id = "b2c3d4e5f6478a9b0c1d2e3f4g5678a1",
                    TrainerId = Account.TrainerMemberId,
                    SkillId = Skill.AgilityTrainingId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.TrainerSkill
                {
                    Id = "c3d4e5f6478a9b0c1d2e3f4g5678a1b2",
                    TrainerId = Account.TrainerMemberId,
                    SkillId = Skill.BehavioralCorrectionId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },

                // Lead Trainer (All 5 skills)
                new Models.Entities.TrainerSkill
                {
                    Id = "d4e5f6478a9b0c1d2e3f4g5678a1b2c3",
                    TrainerId = Account.TrainerLeadId,
                    SkillId = Skill.BasicCommandsId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.TrainerSkill
                {
                    Id = "e5f6478a9b0c1d2e3f4g5678a1b2c3d4",
                    TrainerId = Account.TrainerLeadId,
                    SkillId = Skill.AgilityTrainingId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.TrainerSkill
                {
                    Id = "f6478a9b0c1d2e3f4g5678a1b2c3d4e5",
                    TrainerId = Account.TrainerLeadId,
                    SkillId = Skill.BehavioralCorrectionId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.TrainerSkill
                {
                    Id = "478a9b0c1d2e3f4g5678a1b2c3d4e5f6",
                    TrainerId = Account.TrainerLeadId,
                    SkillId = Skill.SocializationId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.TrainerSkill
                {
                    Id = "8a9b0c1d2e3f4g5678a1b2c3d4e5f647",
                    TrainerId = Account.TrainerLeadId,
                    SkillId = Skill.ProtectionTrainingId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                }
            );
        }
    }
}
