using Microsoft.EntityFrameworkCore;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.SeedingData
{
    public class DogDocument
    {
        public static readonly string DogDocument1Id = "f81d4fae7dec11d0a76500a0c91e6bf6";
        public static readonly string DogDocument2Id = "a3c12f7e5d9647f9b9a2e8f5b4c3d1a0";
        public static readonly string DogDocument3Id = "b5d2f8a47c9342c4aa3e1d9f6e7b5c8d";
        public static readonly string DogDocument4Id = "c8e7d3f5a1b24f6a9d2c5b7e8f4a3d9f";
        public static readonly string DogDocument5Id = "d2c5a7e9f4b3d6a1c8e5f7b9a3d1f4e8";
        public static readonly string DogDocument6Id = "e7f5b4a3c1d9f6a8d2c3e5b7a9f4d1c8";
        public static readonly string DogDocument7Id = "f4d1a9c5e3b7f6a2c8d3e7b5a1f9d2c5";
        public static readonly string DogDocument8Id = "a9f4b5d3c1e7a8f6d2c3e5b7a1d9f2c8";
        public static readonly string DogDocument9Id = "b3d7a5c1f9e6a2c8d4e7b5a1f4d2c9e8";

        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Entities.DogDocument>().HasData(
                new Models.Entities.DogDocument
                {
                    Id = DogDocument1Id,
                    Name = "Vaccination Record",
                    ImageUrl = "https://example.com/documents/vaccination1.jpg",
                    Description = "Annual vaccination record for Bella.",
                    Status = 1, // Active
                    IssueDate = new DateOnly(2023, 1, 10),
                    UploadTime = new DateTime(2023, 1, 10),
                    DogId = Dog.Dog1Id, // Bella
                    DogDocumentTypeId = DogDocumentType.VaccinationRecordId,
                    CreatedTime = new DateTimeOffset(new DateTime(2023, 1, 10)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 1, 10))
                },
                new Models.Entities.DogDocument
                {
                    Id = DogDocument2Id,
                    Name = "Pedigree Certificate",
                    ImageUrl = "https://example.com/documents/pedigree1.jpg",
                    Description = "Pedigree certificate for Rocky.",
                    Status = 1, // Active
                    IssueDate = new DateOnly(2020, 9, 1),
                    UploadTime = new DateTime(2020, 9, 1),
                    DogId = Dog.Dog2Id, // Rocky
                    DogDocumentTypeId = DogDocumentType.PedigreeCertificateId,
                    CreatedTime = new DateTimeOffset(new DateTime(2020, 9, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2020, 9, 1))
                },
                new Models.Entities.DogDocument
                {
                    Id = DogDocument3Id,
                    Name = "Microchip Registration",
                    ImageUrl = "https://example.com/documents/microchip1.jpg",
                    Description = "Microchip registration for Luna.",
                    Status = 1, // Active
                    IssueDate = new DateOnly(2022, 2, 15),
                    UploadTime = new DateTime(2022, 2, 15),
                    DogId = Dog.Dog3Id, // Luna
                    DogDocumentTypeId = DogDocumentType.MicrochipRegistrationId,
                    CreatedTime = new DateTimeOffset(new DateTime(2022, 2, 15)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2022, 2, 15))
                },
                new Models.Entities.DogDocument
                {
                    Id = DogDocument4Id,
                    Name = "Training Certificate",
                    ImageUrl = "https://example.com/documents/training1.jpg",
                    Description = "Basic obedience training certificate for Charlie.",
                    Status = 1, // Active
                    IssueDate = new DateOnly(2021, 3, 20),
                    UploadTime = new DateTime(2021, 3, 20),
                    DogId = Dog.Dog4Id, // Charlie
                    DogDocumentTypeId = DogDocumentType.TrainingCertificateId,
                    CreatedTime = new DateTimeOffset(new DateTime(2021, 3, 20)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2021, 3, 20))
                },
                new Models.Entities.DogDocument
                {
                    Id = DogDocument5Id,
                    Name = "Health Insurance",
                    ImageUrl = "https://example.com/documents/insurance1.jpg",
                    Description = "Health insurance policy for Max.",
                    Status = 1, // Active
                    IssueDate = new DateOnly(2021, 8, 5),
                    UploadTime = new DateTime(2021, 8, 5),
                    DogId = Dog.Dog5Id, // Max
                    DogDocumentTypeId = DogDocumentType.HealthInsuranceId,
                    CreatedTime = new DateTimeOffset(new DateTime(2021, 8, 5)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2021, 8, 5))
                },
                new Models.Entities.DogDocument
                {
                    Id = DogDocument6Id,
                    Name = "Adoption Papers",
                    ImageUrl = "https://example.com/documents/adoption1.jpg",
                    Description = "Adoption papers for Daisy.",
                    Status = 1, // Active
                    IssueDate = new DateOnly(2020, 7, 12),
                    UploadTime = new DateTime(2020, 7, 12),
                    DogId = Dog.Dog6Id, // Daisy
                    DogDocumentTypeId = DogDocumentType.AdoptionPapersId,
                    CreatedTime = new DateTimeOffset(new DateTime(2020, 7, 12)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2020, 7, 12))
                },
                new Models.Entities.DogDocument
                {
                    Id = DogDocument7Id,
                    Name = "Show Competition Certificate",
                    ImageUrl = "https://example.com/documents/show1.jpg",
                    Description = "Certificate for winning Best in Show.",
                    Status = 1, // Active
                    IssueDate = new DateOnly(2019, 12, 1),
                    UploadTime = new DateTime(2019, 12, 1),
                    DogId = Dog.Dog7Id, // Buddy
                    DogDocumentTypeId = DogDocumentType.ShowCompetitionCertificateId,
                    CreatedTime = new DateTimeOffset(new DateTime(2019, 12, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2019, 12, 1))
                },
                new Models.Entities.DogDocument
                {
                    Id = DogDocument8Id,
                    Name = "Breeding License",
                    ImageUrl = "https://example.com/documents/breeding1.jpg",
                    Description = "Breeding license for Rex.",
                    Status = 1, // Active
                    IssueDate = new DateOnly(2019, 10, 1),
                    UploadTime = new DateTime(2019, 10, 1),
                    DogId = Dog.Dog8Id, // Rex
                    DogDocumentTypeId = DogDocumentType.BreedingLicenseId,
                    CreatedTime = new DateTimeOffset(new DateTime(2019, 10, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2019, 10, 1))
                },
                new Models.Entities.DogDocument
                {
                    Id = DogDocument9Id,
                    Name = "Therapy Dog Certification",
                    ImageUrl = "https://example.com/documents/therapy1.jpg",
                    Description = "Therapy dog certification for Zara.",
                    Status = 1, // Active
                    IssueDate = new DateOnly(2021, 4, 1),
                    UploadTime = new DateTime(2021, 4, 1),
                    DogId = Dog.Dog9Id, // Zara
                    DogDocumentTypeId = DogDocumentType.TherapyDogCertificationId,
                    CreatedTime = new DateTimeOffset(new DateTime(2021, 4, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2021, 4, 1))
                }
            );
        }
    }
}
