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
                    Id = Guid.NewGuid().ToString("N"),
                    TrainerId = Account.TrainerMemberId, // Member gets 1 specialization
                    SpecializaionId = Specialization.ObedienceTrainingId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.TrainerSpecialization
                {
                    Id = Guid.NewGuid().ToString("N"),
                    TrainerId = Account.TrainerLeadId, // Lead gets 2 specializations
                    SpecializaionId = Specialization.BehavioralTherapyId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.TrainerSpecialization
                {
                    Id = Guid.NewGuid().ToString("N"),
                    TrainerId = Account.TrainerLeadId,
                    SpecializaionId = Specialization.AgilityTrainingId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                }
            );
        }
    }
}