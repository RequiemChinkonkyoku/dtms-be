using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.SeedingData
{
    public class Certificate
    {
        public static readonly string BasicCourseCertId = "f1a2b3c4d5e67890a1b2c3d4e5f67890";
        public static readonly string AgilityCourseCertId = "a2b3c4d5e67890a1b2c3d4e5f67890f1";
        public static readonly string BehavioralCorrectionCourseCertId = "b3c4d5e67890a1b2c3d4e5f67890f1a2";
        public static readonly string SocializationCourseCertId = "c4d5e67890a1b2c3d4e5f67890f1a2b3";
        public static readonly string ProtectionTrainingCourseCertId = "d5e67890a1b2c3d4e5f67890f1a2b3c4";
        public static readonly string QuickLearnerCourseCertId = "e742a9vfq5y3c3d4e5f67890f1a2b3c4";

        public static readonly string BasicCourseId = "f1a2b3c4d5e67890a1b2c3d4e5f67890";
        public static readonly string AgilityCourseId = "a2b3c4d5e67890a1b2c3d4e5f67890f1";
        public static readonly string BehavioralCorrectionCourseId = "b3c4d5e67890a1b2c3d4e5f67890f1a2";
        public static readonly string SocializationCourseId = "c4d5e67890a1b2c3d4e5f67890f1a2b3";
        public static readonly string ProtectionTrainingCourseId = "d5e67890a1b2c3d4e5f67890f1a2b3c4";
        public static readonly string QuickLearnerCourseId = "e75s896fa1b2c3d4e5f67890f1a2b3c4";

        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Entities.Certificate>().HasData(
                new Models.Entities.Certificate
                {
                    Id = BasicCourseCertId,
                    Name = "Basic Course Certificate",
                    Description = "Cert for basic course",
                    Status = 1,
                    CourseId = BasicCourseId,
                    CreatedTime = new DateTimeOffset(new DateTime(2023, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 1, 1))
                },
                new Models.Entities.Certificate
                {
                    Id = AgilityCourseCertId,
                    Name = "Agility Course Certificate",
                    Description = "Cert for agility course",
                    Status = 1,
                    CourseId = AgilityCourseId,
                    CreatedTime = new DateTimeOffset(new DateTime(2023, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 1, 1))
                },
                new Models.Entities.Certificate
                {
                    Id = BehavioralCorrectionCourseCertId,
                    Name = "Behavioural Course Certificate",
                    Description = "Cert for bahvioural course",
                    Status = 1,
                    CourseId = BehavioralCorrectionCourseId,
                    CreatedTime = new DateTimeOffset(new DateTime(2023, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 1, 1))
                },
                new Models.Entities.Certificate
                {
                    Id = SocializationCourseCertId,
                    Name = "Socialization Course Certificate",
                    Description = "Cert for socialization course",
                    Status = 1,
                    CourseId = SocializationCourseId,
                    CreatedTime = new DateTimeOffset(new DateTime(2023, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 1, 1))
                },
                new Models.Entities.Certificate
                {
                    Id = ProtectionTrainingCourseCertId,
                    Name = "Protection Course Certificate",
                    Description = "Cert for protection course",
                    Status = 1,
                    CourseId = ProtectionTrainingCourseId,
                    CreatedTime = new DateTimeOffset(new DateTime(2023, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 1, 1))
                },
                new Models.Entities.Certificate
                {
                    Id = QuickLearnerCourseCertId,
                    Name = "Quick Learner Course Certificate",
                    Description = "Cert for quick learner course",
                    Status = 1,
                    CourseId = QuickLearnerCourseId,
                    CreatedTime = new DateTimeOffset(new DateTime(2023, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 1, 1))
                }
            );
        }
    }
}
