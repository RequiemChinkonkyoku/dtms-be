using Microsoft.EntityFrameworkCore;
using Models.Entities;
using System;

namespace Repositories.SeedingData
{
    public static class Specialization
    {
        public static readonly string ObedienceTrainingId = "6f78901a2b3c4d5e6f78901a2b3c4d5e";
        public static readonly string BehavioralTherapyId = "78901a2b3c4d5e6f78901a2b3c4d5e6f";
        public static readonly string AgilityTrainingId = "8901a2b3c4d5e6f78901a2b3c4d5e6f7"; // Keeping the same as before

        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Entities.Specialization>().HasData(
                new Models.Entities.Specialization
                {
                    Id = ObedienceTrainingId,
                    Name = "Obedience Training",
                    Description = "Basic and advanced obedience training for dogs.",
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.Specialization
                {
                    Id = BehavioralTherapyId,
                    Name = "Behavioral Therapy",
                    Description = "Helping dogs overcome behavioral issues.",
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.Specialization
                {
                    Id = AgilityTrainingId,
                    Name = "Agility Training",
                    Description = "Training dogs for agility courses and competitions.",
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                }
            );
        }
    }
}