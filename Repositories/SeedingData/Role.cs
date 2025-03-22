using Microsoft.EntityFrameworkCore;
using Models.Entities;
using System;

namespace Repositories.SeedingData
{
    public static class Role
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Entities.Role>().HasData(
                new Models.Entities.Role
                {
                    Id = Guid.NewGuid().ToString("N"),
                    Name = "Admin",
                    Status = 1,
                    Description = "System administrator with full access",
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.Role
                {
                    Id = Guid.NewGuid().ToString("N"),
                    Name = "Trainer_Member",
                    Status = 1,
                    Description = "Trainer responsible for courses and lessons",
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.Role
                {
                    Id = Guid.NewGuid().ToString("N"),
                    Name = "Trainer_Lead",
                    Status = 1,
                    Description = "Lead trainer responsible for courses and lessons",
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.Role
                {
                    Id = Guid.NewGuid().ToString("N"),
                    Name = "Customer_Individual",
                    Status = 1,
                    Description = "Individual customer who can enroll in courses",
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.Role
                {
                    Id = Guid.NewGuid().ToString("N"),
                    Name = "Customer_Organizational",
                    Status = 1,
                    Description = "Organizational customer who can enroll in courses",
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.Role
                {
                    Id = Guid.NewGuid().ToString("N"),
                    Name = "Staff_Employee",
                    Status = 1,
                    Description = "Staff employee member managing operations",
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.Role
                {
                    Id = Guid.NewGuid().ToString("N"),
                    Name = "Staff_Manager",
                    Status = 1,
                    Description = "Staff manager member managing operations",
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                }
            );
        }
    }
}