using Microsoft.EntityFrameworkCore;
using Models.Entities;
using System;
using BCrypt.Net;

namespace Repositories.SeedingData
{
    public static class Account
    {
        public static readonly string AdminId = "6144c9fe6b7e4f4294ea469ffb6a90fd";
        public static readonly string TrainerMemberId = "54d3a3e95adc4b38885e43af50e12e42";
        public static readonly string TrainerLeadId = "fa13bc18b0c54ba0b9886b007f4d8b08";
        public static readonly string CustomerIndividualId = "ea46ce4e457f42dfb18b6347bd4ea1f4";
        public static readonly string CustomerOrganizationId = "2bf1c6f4a7db4fed825958e6d78e7226";
        public static readonly string StaffEmployeeId = "00786efb729542fa87a19d44fb3cdf79";
        public static readonly string StaffManagerId = "eaa27cff0c91479087bb22370ffbb6d0";

        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Entities.Account>().HasData(
                new Models.Entities.Account
                {
                    Id = AdminId,
                    Username = "admin",
                    Email = "admin@gmail.com",
                    Password = BCrypt.Net.BCrypt.HashPassword("Test@1234"),
                    ImageUrl = "empty",
                    Status = 1,
                    RegistrationTime = new DateTime(2000, 1, 1),
                    FullName = "Admin User",
                    PhoneNumber = "0123456789",
                    Address = "Admin Address",
                    DateOfBirth = new DateTime(1990, 1, 1),
                    Gender = 1,
                    MembershipPoints = 0,
                    RoleId = Role.AdminRoleId,
                    MembershipId = Membership.BasicMembershipId
                },
                new Models.Entities.Account
                {
                    Id = TrainerMemberId,
                    Username = "trainer_member",
                    Email = "trainer_member@gmail.com",
                    Password = BCrypt.Net.BCrypt.HashPassword("Test@1234"),
                    ImageUrl = "empty",
                    Status = 1,
                    RegistrationTime = new DateTime(2000, 1, 1),
                    FullName = "Trainer Member",
                    PhoneNumber = "0987654321",
                    Address = "Trainer Member Address",
                    DateOfBirth = new DateTime(1985, 5, 10),
                    Gender = 1,
                    MembershipPoints = 0,
                    RoleId = Role.Trainer_MemberRoleId,
                    MembershipId = Membership.BasicMembershipId
                },
                new Models.Entities.Account
                {
                    Id = TrainerLeadId,
                    Username = "trainer_lead",
                    Email = "trainer_lead@gmail.com",
                    Password = BCrypt.Net.BCrypt.HashPassword("Test@1234"),
                    ImageUrl = "empty",
                    Status = 1,
                    RegistrationTime = new DateTime(2000, 1, 1),
                    FullName = "Trainer Lead",
                    PhoneNumber = "0911223344",
                    Address = "Trainer Lead Address",
                    DateOfBirth = new DateTime(1983, 8, 15),
                    Gender = 1,
                    MembershipPoints = 0,
                    RoleId = Role.Trainer_LeadRoleId,
                    MembershipId = Membership.BasicMembershipId
                },
                new Models.Entities.Account
                {
                    Id = CustomerIndividualId,
                    Username = "customer_individual",
                    Email = "customer_individual@gmail.com",
                    Password = BCrypt.Net.BCrypt.HashPassword("Test@1234"),
                    ImageUrl = "empty",
                    Status = 1,
                    RegistrationTime = new DateTime(2000, 1, 1),
                    FullName = "Customer Individual",
                    PhoneNumber = "0988112233",
                    Address = "Customer Individual Address",
                    DateOfBirth = new DateTime(1995, 12, 20),
                    Gender = 2,
                    MembershipPoints = 100,
                    RoleId = Role.Customer_IndividualRoleId,
                    MembershipId = Membership.BasicMembershipId
                },
                new Models.Entities.Account
                {
                    Id = CustomerOrganizationId,
                    Username = "customer_organization",
                    Email = "customer_organization@gmail.com",
                    Password = BCrypt.Net.BCrypt.HashPassword("Test@1234"),
                    ImageUrl = "empty",
                    Status = 1,
                    RegistrationTime = new DateTime(2000, 1, 1),
                    FullName = "Customer Organization",
                    PhoneNumber = "0977554433",
                    Address = "Customer Organization Address",
                    DateOfBirth = new DateTime(1992, 3, 8),
                    Gender = 2,
                    MembershipPoints = 200,
                    RoleId = Role.Customer_OrganizationalRoleId,
                    MembershipId = Membership.BasicMembershipId
                },
                new Models.Entities.Account
                {
                    Id = StaffEmployeeId,
                    Username = "staff_employee",
                    Email = "staff_employee@gmail.com",
                    Password = BCrypt.Net.BCrypt.HashPassword("Test@1234"),
                    ImageUrl = "empty",
                    Status = 1,
                    RegistrationTime = new DateTime(2000, 1, 1),
                    FullName = "Staff Employee",
                    PhoneNumber = "0966332211",
                    Address = "Staff Employee Address",
                    DateOfBirth = new DateTime(1988, 7, 25),
                    Gender = 1,
                    MembershipPoints = 0,
                    RoleId = Role.Staff_EmployeeRoleId,
                    MembershipId = Membership.BasicMembershipId
                },
                new Models.Entities.Account
                {
                    Id = StaffManagerId,
                    Username = "staff_manager",
                    Email = "staff_manager@gmail.com",
                    Password = BCrypt.Net.BCrypt.HashPassword("Test@1234"),
                    ImageUrl = "empty",
                    Status = 1,
                    RegistrationTime = new DateTime(2000, 1, 1),
                    FullName = "Staff Manager",
                    PhoneNumber = "0955223344",
                    Address = "Staff Manager Address",
                    DateOfBirth = new DateTime(1980, 2, 14),
                    Gender = 1,
                    MembershipPoints = 0,
                    RoleId = Role.Staff_ManagerRoleId,
                    MembershipId = Membership.BasicMembershipId
                },
                new Models.Entities.Account
                {
                    Id = "9f7c3e8a4b6d49f19a8d2e3f4c7b5680",
                    Username = "test",
                    Email = "test@gmail.com",
                    Password = BCrypt.Net.BCrypt.HashPassword("Test@1234"),
                    ImageUrl = "empty",
                    Status = 1,
                    RegistrationTime = new DateTime(2000, 1, 1),
                    FullName = "Test User",
                    PhoneNumber = "0123456789",
                    Address = "Test Address",
                    DateOfBirth = new DateTime(1990, 1, 1),
                    Gender = 1,
                    MembershipPoints = 0,
                    RoleId = Role.Customer_IndividualRoleId,
                    MembershipId = Membership.BasicMembershipId
                }
            );
        }
    }
}
