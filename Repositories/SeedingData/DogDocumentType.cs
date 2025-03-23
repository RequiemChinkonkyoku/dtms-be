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
        public static readonly string VaccinationRecordId = Guid.NewGuid().ToString("N");
        public static readonly string PedigreeCertificateId = Guid.NewGuid().ToString("N");
        public static readonly string MicrochipRegistrationId = Guid.NewGuid().ToString("N");
        public static readonly string TrainingCertificateId = Guid.NewGuid().ToString("N");
        public static readonly string HealthInsuranceId = Guid.NewGuid().ToString("N");
        public static readonly string AdoptionPapersId = Guid.NewGuid().ToString("N");
        public static readonly string ShowCompetitionCertificateId = Guid.NewGuid().ToString("N");
        public static readonly string BreedingLicenseId = Guid.NewGuid().ToString("N");
        public static readonly string TherapyDogCertificationId = Guid.NewGuid().ToString("N");

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

