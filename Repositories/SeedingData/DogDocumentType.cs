using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Entities;


namespace Repositories.SeedingData
{
    public class DogDocumentType
    {
        public static readonly string VaccinationRecordId = "a1b2c3d4e5f64789a0b1c2d3e4f5a6b7";
        public static readonly string PedigreeCertificateId = "b7a6f5e4d3c2b1a0e5d4c3b2a1f69870";
        public static readonly string MicrochipRegistrationId = "c3d2e1f6a5b4c3d2e1f6a5b4c3d2e1f6";
        public static readonly string TrainingCertificateId = "d4e3f2a1b0c9d8e7f6a5b4c3d2e1f6a5";
        public static readonly string HealthInsuranceId = "e5f4a3b2c1d0e9f8a7b6c5d4e3f2a1b0";
        public static readonly string AdoptionPapersId = "f6a5b4c3d2e1f0a9b8c7d6e5f4a3b2c1";
        public static readonly string ShowCompetitionCertificateId = "a0b1c2d3e4f5a6b7c8d9e0f1a2b3c4d5";
        public static readonly string BreedingLicenseId = "b2c3d4e5f6a7b8c9d0e1f2a3b4c5d6e7";
        public static readonly string TherapyDogCertificationId = "c4d5e6f7a8b9c0d1e2f3a4b5c6d7e8f9";

        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Entities.DogDocumentType>().HasData(
                new Models.Entities.DogDocumentType
                {
                    Id = VaccinationRecordId,
                    Name = "Vaccination Record",
                    Description = "Document containing vaccination history of the dog.",
                    CreatedTime = new DateTimeOffset(new DateTime(2023, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 1, 1))
                },
                new Models.Entities.DogDocumentType
                {
                    Id = PedigreeCertificateId,
                    Name = "Pedigree Certificate",
                    Description = "Official document proving the dog's lineage and breed.",
                    CreatedTime = new DateTimeOffset(new DateTime(2023, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 1, 1))
                },
                new Models.Entities.DogDocumentType
                {
                    Id = MicrochipRegistrationId,
                    Name = "Microchip Registration",
                    Description = "Document containing the dog's microchip details.",
                    CreatedTime = new DateTimeOffset(new DateTime(2023, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 1, 1))
                },
                new Models.Entities.DogDocumentType
                {
                    Id = TrainingCertificateId,
                    Name = "Training Certificate",
                    Description = "Certificate proving the dog has completed a training program.",
                    CreatedTime = new DateTimeOffset(new DateTime(2023, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 1, 1))
                },
                new Models.Entities.DogDocumentType
                {
                    Id = HealthInsuranceId,
                    Name = "Health Insurance",
                    Description = "Document detailing the dog's health insurance policy.",
                    CreatedTime = new DateTimeOffset(new DateTime(2023, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 1, 1))
                },
                new Models.Entities.DogDocumentType
                {
                    Id = AdoptionPapersId,
                    Name = "Adoption Papers",
                    Description = "Legal documents for the adoption of the dog.",
                    CreatedTime = new DateTimeOffset(new DateTime(2023, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 1, 1))
                },
                new Models.Entities.DogDocumentType
                {
                    Id = ShowCompetitionCertificateId,
                    Name = "Show Competition Certificate",
                    Description = "Certificate awarded for participation or winning in dog shows.",
                    CreatedTime = new DateTimeOffset(new DateTime(2023, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 1, 1))
                },
                new Models.Entities.DogDocumentType
                {
                    Id = BreedingLicenseId,
                    Name = "Breeding License",
                    Description = "Official license permitting the dog to be used for breeding.",
                    CreatedTime = new DateTimeOffset(new DateTime(2023, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 1, 1))
                },
                new Models.Entities.DogDocumentType
                {
                    Id = TherapyDogCertificationId,
                    Name = "Therapy Dog Certification",
                    Description = "Certification proving the dog is qualified as a therapy dog.",
                    CreatedTime = new DateTimeOffset(new DateTime(2023, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 1, 1))
                }
            );
        }
    }
}

