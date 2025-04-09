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

        public static readonly string TrainerMember1Id = "a1b2c3d4e5f648a9b0c1d2e3f4a5b6c7";
        public static readonly string TrainerMember2Id = "b2c3d4e5f648a9b0c1d2e3f4a5b6c7d8";
        public static readonly string TrainerMember3Id = "c3d4e5f648a9b0c1d2e3f4a5b6c7d8e9";
        public static readonly string TrainerMember4Id = "d4e5f648a9b0c1d2e3f4a5b6c7d8e9f0";
        public static readonly string TrainerMember5Id = "e5f648a9b0c1d2e3f4a5b6c7d8e9f0a1";

        public static readonly string TrainerLead1Id = "f648a9b0c1d2e3f4a5b6c7d8e9f0a1b2";
        public static readonly string TrainerLead2Id = "a9b0c1d2e3f4a5b6c7d8e9f0a1b2c3d4";
        public static readonly string TrainerLead3Id = "c1d2e3f4a5b6c7d8e9f0a1b2c3d4e5f6";
        public static readonly string TrainerLead4Id = "e3f4a5b6c7d8e9f0a1b2c3d4e5f648a9";
        public static readonly string TrainerLead5Id = "a5b6c7d8e9f0a1b2c3d4e5f648a9b0c1";

        public static readonly string CustomerIndividual1Id = "a1b2c3d4e5f648a9b0c1d2e3f4a5b6c1";
        public static readonly string CustomerIndividual2Id = "b2c3d4e5f648a9b0c1d2e3f4a5b6c1d2";
        public static readonly string CustomerIndividual3Id = "c3d4e5f648a9b0c1d2e3f4a5b6c1d2e3";

        public static readonly string CustomerOrganization1Id = "d4e5f648a9b0c1d2e3f4a5b6c1d2e3f4";
        public static readonly string CustomerOrganization2Id = "e5f648a9b0c1d2e3f4a5b6c1d2e3f4a5";

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
                },
                 new Models.Entities.Account
                 {
                     Id = TrainerMember1Id,
                     Username = "AaronHank",
                     Email = "Aaron_Hank@gmail.com",
                     Password = BCrypt.Net.BCrypt.HashPassword("Test@1234"),
                     ImageUrl = "https://res.cloudinary.com/djy6ydaxz/image/upload/v1744168717/waccatxqnji44dxgwxhf.png",
                     Status = 1,
                     RegistrationTime = new DateTime(2000, 1, 1),
                     FullName = "Aaron Hank",
                     PhoneNumber = "0911223345",
                     Address = "123 Trainer Street",
                     DateOfBirth = new DateTime(1985, 6, 15),
                     Gender = 1,
                     MembershipPoints = 0,
                     RoleId = Role.Trainer_MemberRoleId,
                     MembershipId = Membership.BasicMembershipId
                 },
                new Models.Entities.Account
                {
                    Id = TrainerMember2Id,
                    Username = "AlbaJessica",
                    Email = "Alba_Jessica@gmail.com",
                    Password = BCrypt.Net.BCrypt.HashPassword("Test@1234"),
                    ImageUrl = "https://res.cloudinary.com/djy6ydaxz/image/upload/v1744168717/waccatxqnji44dxgwxhf.png",
                    Status = 1,
                    RegistrationTime = new DateTime(2000, 1, 1),
                    FullName = "Alba Jessica",
                    PhoneNumber = "0922334456",
                    Address = "456 Fitness Ave",
                    DateOfBirth = new DateTime(1988, 3, 22),
                    Gender = 2,
                    MembershipPoints = 0,
                    RoleId = Role.Trainer_MemberRoleId,
                    MembershipId = Membership.BasicMembershipId
                },
                new Models.Entities.Account
                {
                    Id = TrainerMember3Id,
                    Username = "AustenJane",
                    Email = "Austen_Jane@gmail.com",
                    Password = BCrypt.Net.BCrypt.HashPassword("Test@1234"),
                    ImageUrl = "https://res.cloudinary.com/djy6ydaxz/image/upload/v1744168717/waccatxqnji44dxgwxhf.png",
                    Status = 1,
                    RegistrationTime = new DateTime(2000, 1, 1),
                    FullName = "Austen Jane",
                    PhoneNumber = "0933445567",
                    Address = "789 Workout Lane",
                    DateOfBirth = new DateTime(1982, 11, 5),
                    Gender = 1,
                    MembershipPoints = 0,
                    RoleId = Role.Trainer_MemberRoleId,
                    MembershipId = Membership.BasicMembershipId
                },
                new Models.Entities.Account
                {
                    Id = TrainerMember4Id,
                    Username = "AustinAlfred",
                    Email = "Austin_Alfred@gmail.com",
                    Password = BCrypt.Net.BCrypt.HashPassword("Test@1234"),
                    ImageUrl = "https://res.cloudinary.com/djy6ydaxz/image/upload/v1744168717/waccatxqnji44dxgwxhf.png",
                    Status = 1,
                    RegistrationTime = new DateTime(2000, 1, 1),
                    FullName = "Austin Alfred",
                    PhoneNumber = "0944556678",
                    Address = "321 Exercise Blvd",
                    DateOfBirth = new DateTime(1990, 7, 30),
                    Gender = 2,
                    MembershipPoints = 0,
                    RoleId = Role.Trainer_MemberRoleId,
                    MembershipId = Membership.BasicMembershipId
                },
                new Models.Entities.Account
                {
                    Id = TrainerMember5Id,
                    Username = "BachRichard",
                    Email = "Bach_Richard@gmail.com",
                    Password = BCrypt.Net.BCrypt.HashPassword("Test@1234"),
                    ImageUrl = "https://res.cloudinary.com/djy6ydaxz/image/upload/v1744168717/waccatxqnji44dxgwxhf.png",
                    Status = 1,
                    RegistrationTime = new DateTime(2000, 1, 1),
                    FullName = "Bach Richard",
                    PhoneNumber = "0955667789",
                    Address = "654 Gym Road",
                    DateOfBirth = new DateTime(1987, 9, 12),
                    Gender = 1,
                    MembershipPoints = 0,
                    RoleId = Role.Trainer_MemberRoleId,
                    MembershipId = Membership.BasicMembershipId
                },

                // New Trainer Leads (5 accounts)
                new Models.Entities.Account
                {
                    Id = TrainerLead1Id,
                    Username = "BucklesFrank",
                    Email = "Buckles_Frank@gmail.com",
                    Password = BCrypt.Net.BCrypt.HashPassword("Test@1234"),
                    ImageUrl = "https://res.cloudinary.com/djy6ydaxz/image/upload/v1744168717/waccatxqnji44dxgwxhf.png",
                    Status = 1,
                    RegistrationTime = new DateTime(2000, 1, 1),
                    FullName = "Buckles Frank",
                    PhoneNumber = "0966778899",
                    Address = "987 Training Center",
                    DateOfBirth = new DateTime(1980, 4, 18),
                    Gender = 1,
                    MembershipPoints = 0,
                    RoleId = Role.Trainer_LeadRoleId,
                    MembershipId = Membership.BasicMembershipId
                },
                new Models.Entities.Account
                {
                    Id = TrainerLead2Id,
                    Username = "CalvinJohn",
                    Email = "Calvin_Jonh@gmail.com",
                    Password = BCrypt.Net.BCrypt.HashPassword("Test@1234"),
                    ImageUrl = "https://res.cloudinary.com/djy6ydaxz/image/upload/v1744168717/waccatxqnji44dxgwxhf.png",
                    Status = 1,
                    RegistrationTime = new DateTime(2000, 1, 1),
                    FullName = "Calvin John",
                    PhoneNumber = "0977889900",
                    Address = "555 Fitness Plaza",
                    DateOfBirth = new DateTime(1978, 12, 8),
                    Gender = 2,
                    MembershipPoints = 0,
                    RoleId = Role.Trainer_LeadRoleId,
                    MembershipId = Membership.BasicMembershipId
                },
                new Models.Entities.Account
                {
                    Id = TrainerLead3Id,
                    Username = "CaoCao",
                    Email = "Cao_Cao@gmail.com",
                    Password = BCrypt.Net.BCrypt.HashPassword("Test@1234"),
                    ImageUrl = "https://res.cloudinary.com/djy6ydaxz/image/upload/v1744168717/waccatxqnji44dxgwxhf.png",
                    Status = 1,
                    RegistrationTime = new DateTime(2000, 1, 1),
                    FullName = "Cao Cao",
                    PhoneNumber = "0988990011",
                    Address = "222 Wellness Way",
                    DateOfBirth = new DateTime(1975, 5, 25),
                    Gender = 1,
                    MembershipPoints = 0,
                    RoleId = Role.Trainer_LeadRoleId,
                    MembershipId = Membership.BasicMembershipId
                },
                new Models.Entities.Account
                {
                    Id = TrainerLead4Id,
                    Username = "CharlesRay",
                    Email = "Charles_Ray@gmail.com",
                    Password = BCrypt.Net.BCrypt.HashPassword("Test@1234"),
                    ImageUrl = "https://res.cloudinary.com/djy6ydaxz/image/upload/v1744168717/waccatxqnji44dxgwxhf.png",
                    Status = 1,
                    RegistrationTime = new DateTime(2000, 1, 1),
                    FullName = "Charles Ray",
                    PhoneNumber = "0999001122",
                    Address = "888 Health Circle",
                    DateOfBirth = new DateTime(1982, 10, 3),
                    Gender = 2,
                    MembershipPoints = 0,
                    RoleId = Role.Trainer_LeadRoleId,
                    MembershipId = Membership.BasicMembershipId
                },
                new Models.Entities.Account
                {
                    Id = TrainerLead5Id,
                    Username = "ClarkRamsey",
                    Email = "Clark_Ramsey@gmail.com",
                    Password = BCrypt.Net.BCrypt.HashPassword("Test@1234"),
                    ImageUrl = "https://res.cloudinary.com/djy6ydaxz/image/upload/v1744168717/waccatxqnji44dxgwxhf.png",
                    Status = 1,
                    RegistrationTime = new DateTime(2000, 1, 1),
                    FullName = "Clark Ramsey",
                    PhoneNumber = "0910112233",
                    Address = "444 Performance Drive",
                    DateOfBirth = new DateTime(1979, 2, 14),
                    Gender = 1,
                    MembershipPoints = 0,
                    RoleId = Role.Trainer_LeadRoleId,
                    MembershipId = Membership.BasicMembershipId
                },
                new Models.Entities.Account
                {
                    Id = CustomerIndividual1Id,
                    Username = "AlexJohnson",
                    Email = "AlexJohnson@gmail.com",
                    Password = BCrypt.Net.BCrypt.HashPassword("Test@1234"),
                    ImageUrl = "https://res.cloudinary.com/djy6ydaxz/image/upload/v1744168717/waccatxqnji44dxgwxhf.png",
                    Status = 1,
                    RegistrationTime = new DateTime(2020, 5, 15),
                    FullName = "Alex Johnson",
                    PhoneNumber = "0912345678",
                    Address = "123 Main Street, Cityville",
                    DateOfBirth = new DateTime(1990, 8, 20),
                    Gender = 1, // Male
                    MembershipPoints = 150,
                    RoleId = Role.Customer_IndividualRoleId,
                    MembershipId = Membership.BasicMembershipId
                },
                new Models.Entities.Account
                {
                    Id = CustomerIndividual2Id,
                    Username = "SarahWilliams",
                    Email = "SarahWilliams@gmail.com",
                    Password = BCrypt.Net.BCrypt.HashPassword("Test@1234"),
                    ImageUrl = "https://res.cloudinary.com/djy6ydaxz/image/upload/v1744168717/waccatxqnji44dxgwxhf.png",
                    Status = 1,
                    RegistrationTime = new DateTime(2021, 2, 10),
                    FullName = "Sarah Williams",
                    PhoneNumber = "0923456789",
                    Address = "456 Oak Avenue, Townsville",
                    DateOfBirth = new DateTime(1988, 3, 12),
                    Gender = 2, // Female
                    MembershipPoints = 250,
                    RoleId = Role.Customer_IndividualRoleId,
                    MembershipId = Membership.BasicMembershipId
                },
                new Models.Entities.Account
                {
                    Id = CustomerIndividual3Id,
                    Username = "MichaelBrown",
                    Email = "MichaelBrown@gmail.com",
                    Password = BCrypt.Net.BCrypt.HashPassword("Test@1234"),
                    ImageUrl = "https://res.cloudinary.com/djy6ydaxz/image/upload/v1744168717/waccatxqnji44dxgwxhf.png",
                    Status = 1,
                    RegistrationTime = new DateTime(2022, 7, 22),
                    FullName = "Michael Brown",
                    PhoneNumber = "0934567890",
                    Address = "789 Pine Road, Villagetown",
                    DateOfBirth = new DateTime(1995, 11, 5),
                    Gender = 1, // Male
                    MembershipPoints = 75,
                    RoleId = Role.Customer_IndividualRoleId,
                    MembershipId = Membership.BasicMembershipId
                },

                new Models.Entities.Account
                {
                    Id = CustomerOrganization1Id,
                    Username = "ABCCorporation",
                    Email = "ABCCorporation@gmail.com",
                    Password = BCrypt.Net.BCrypt.HashPassword("Test@1234"),
                    ImageUrl = "https://res.cloudinary.com/djy6ydaxz/image/upload/v1744168717/waccatxqnji44dxgwxhf.png",
                    Status = 1,
                    RegistrationTime = new DateTime(2019, 11, 30),
                    FullName = "ABC Corporation",
                    PhoneNumber = "0945678901",
                    Address = "101 Business Park, Metropolis",
                    DateOfBirth = new DateTime(1985, 1, 1), 
                    Gender = 1, 
                    MembershipPoints = 500,
                    RoleId = Role.Customer_OrganizationalRoleId,
                    MembershipId = Membership.BasicMembershipId
                },
                new Models.Entities.Account
                {
                    Id = CustomerOrganization2Id,
                    Username = "XYZEnterprises",
                    Email = "XYZEnterprises@gmail.com",
                    Password = BCrypt.Net.BCrypt.HashPassword("Test@1234"),
                    ImageUrl = "https://res.cloudinary.com/djy6ydaxz/image/upload/v1744168717/waccatxqnji44dxgwxhf.png",
                    Status = 1,
                    RegistrationTime = new DateTime(2020, 9, 5),
                    FullName = "XYZEnterprises",
                    PhoneNumber = "0956789012",
                    Address = "202 Commerce Street, Downtown",
                    DateOfBirth = new DateTime(1990, 1, 1), 
                    Gender = 1, 
                    MembershipPoints = 350,
                    RoleId = Role.Customer_OrganizationalRoleId,
                    MembershipId = Membership.BasicMembershipId
                }

            );
        }
    }
}
