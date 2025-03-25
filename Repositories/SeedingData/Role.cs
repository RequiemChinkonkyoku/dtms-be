using Microsoft.EntityFrameworkCore;
using Models.Entities;
using System;

namespace Repositories.SeedingData
{
    public static class Role
    {
        public static readonly string AdminRoleId = "d1e2f3a4b5c67890d1e2f3a4b5c67890";
        public static readonly string Trainer_MemberRoleId = "e2f3a4b5c67890d1e2f3a4b5c67890d1";
        public static readonly string Trainer_LeadRoleId = "f3a4b5c67890d1e2f3a4b5c67890d1e2";
        public static readonly string Customer_IndividualRoleId = "a4b5c67890d1e2f3a4b5c67890d1e2f3";
        public static readonly string Customer_OrganizationalRoleId = "b5c67890d1e2f3a4b5c67890d1e2f3a4";
        public static readonly string Staff_EmployeeRoleId = "c67890d1e2f3a4b5c67890d1e2f3a4b5";
        public static readonly string Staff_ManagerRoleId = "67890d1e2f3a4b5c67890d1e2f3a4b5c";
        
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Entities.Role>().HasData(
                new Models.Entities.Role
                {
                    Id = AdminRoleId,
                    Name = "Admin",
                    Status = 1,
                    Description = "System administrator with full access",
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.Role
                {
                    Id = Trainer_MemberRoleId,
                    Name = "Trainer_Member",
                    Status = 1,
                    Description = "Trainer responsible for courses and lessons",
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.Role
                {
                    Id = Trainer_LeadRoleId,
                    Name = "Trainer_Lead",
                    Status = 1,
                    Description = "Lead trainer responsible for courses and lessons",
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.Role
                {
                    Id = Customer_IndividualRoleId,
                    Name = "Customer_Individual",
                    Status = 1,
                    Description = "Individual customer who can enroll in courses",
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.Role
                {
                    Id = Customer_OrganizationalRoleId,
                    Name = "Customer_Organizational",
                    Status = 1,
                    Description = "Organizational customer who can enroll in courses",
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.Role
                {
                    Id = Staff_EmployeeRoleId,
                    Name = "Staff_Employee",
                    Status = 1,
                    Description = "Staff employee member managing operations",
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.Role
                {
                    Id = Staff_ManagerRoleId,
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