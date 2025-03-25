using Microsoft.EntityFrameworkCore;
using Models.Entities;
using System;

namespace Repositories.SeedingData
{
    public static class TrainerSpecialization
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Entities.TrainerSpecialization>().HasData(
                new Models.Entities.TrainerSpecialization
                {
                    Id = "a1b2c3d4e5f6478a9b0c1d2e3f4g5678", // Fixed GUID
                    TrainerId = Account.TrainerMemberId, // Member gets 1 specialization
                    SpecializaionId = Specialization.ObedienceTrainingId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.TrainerSpecialization
                {
                    Id = "b2c3d4e5f6478a9b0c1d2e3f4g5678a1", // Fixed GUID
                    TrainerId = Account.TrainerLeadId, // Lead gets 2 specializations
                    SpecializaionId = Specialization.BehavioralTherapyId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.TrainerSpecialization
                {
                    Id = "c3d4e5f6478a9b0c1d2e3f4g5678a1b2", // Fixed GUID
                    TrainerId = Account.TrainerLeadId,
                    SpecializaionId = Specialization.AgilityTrainingId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                }
            );
        }
    }
}