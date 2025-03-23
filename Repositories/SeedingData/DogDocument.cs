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
        public static readonly string DogDocument1Id = Guid.NewGuid().ToString("N");
        public static readonly string DogDocument2Id = Guid.NewGuid().ToString("N");
        public static readonly string DogDocument3Id = Guid.NewGuid().ToString("N");
        public static readonly string DogDocument4Id = Guid.NewGuid().ToString("N");
        public static readonly string DogDocument5Id = Guid.NewGuid().ToString("N");
        public static readonly string DogDocument6Id = Guid.NewGuid().ToString("N");
        public static readonly string DogDocument7Id = Guid.NewGuid().ToString("N");
        public static readonly string DogDocument8Id = Guid.NewGuid().ToString("N");
        public static readonly string DogDocument9Id = Guid.NewGuid().ToString("N");

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
