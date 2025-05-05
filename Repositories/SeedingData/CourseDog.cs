using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.SeedingData
{
    public class CourseDog
    {
        public static readonly string CDId1 = "e1f2a3b4c5d67890a1b2c3d4e5f67890";
        public static readonly string CDId2 = "f2a3b4c5d67890a1b2c3d4e5f67890e1";
        public static readonly string CDId3 = "a3b4c5d67890a1b2c3d4e5f67890e1f2";
        public static readonly string CDId4 = "b4c5d67890a1b2c3d4e5f67890e1f2a3";
        public static readonly string CDId5 = "c5d67890a1b2c3d4e5f67890e1f2a3b4";
        public static readonly string CDId6 = "d67890a1b2c3d4e5f67890e1f2a3b4c5";
        public static readonly string CDId7 = "e7890a1b2c3d4e5f67890e1f2a3b4c5d6";
        public static readonly string CDId8 = "f890a1b2c3d4e5f67890e1f2a3b4c5d67";
        public static readonly string CDId9 = "901a2b3c4d5e67890e1f2a3b4c5d678f8";
        public static readonly string CDId10 = "a12b3c4d5e67890e1f2a3b4c5d678f890";
        public static readonly string CDId11 = "b23c4d5e67890e1f2a3b4c5d678f890a1";
        public static readonly string CDId12 = "c34d5e67890e1f2a3b4c5d678f890a12b";
        public static readonly string CDId13 = "d45e67890e1f2a3b4c5d678f890a12b3c";
        public static readonly string CDId14 = "e56f7890e1f2a3b4c5d678f890a12b3c4";
        public static readonly string CDId15 = "f67a890e1f2a3b4c5d678f890a12b3c45";
        public static readonly string CDId16 = "678b90e1f2a3b4c5d678f890a12b3c45d";
        public static readonly string CDId17 = "789c01e1f2a3b4c5d678f890a12b3c45d6";
        public static readonly string CDId18 = "890d12e1f2a3b4c5d678f890a12b3c45d6";
        public static readonly string CDId19 = "901e23e1f2a3b4c5d678f890a12b3c45d6";
        public static readonly string CDId20 = "a12f34e1f2a3b4c5d678f890a12b3c45d6";
        public static readonly string CDId21 = "b12f34e1f2a3b4c5d678f890a12b3c45d6";
        public static readonly string CDId22 = "c12f34e1f2a3b4c5d678f890a12b3c45d6";
        public static readonly string CDId23 = "d12f34e1f2a3b4c5d678f890a12b3c45d6";

        public static readonly string BasicCourseId = "f1a2b3c4d5e67890a1b2c3d4e5f67890";
        public static readonly string AgilityCourseId = "a2b3c4d5e67890a1b2c3d4e5f67890f1";
        public static readonly string BehavioralCorrectionCourseId = "b3c4d5e67890a1b2c3d4e5f67890f1a2";
        public static readonly string SocializationCourseId = "c4d5e67890a1b2c3d4e5f67890f1a2b3";
        public static readonly string ProtectionTrainingCourseId = "d5e67890a1b2c3d4e5f67890f1a2b3c4";
        public static readonly string QuickLearnerCourseId = "e75s896fa1b2c3d4e5f67890f1a2b3c4";

        public static readonly string ChihuahuaBreedId = "4bee6ab4f7f841d69bacedcfd25c8d07";
        public static readonly string PomeranianBreedId = "a8f5f1675aaf4d1b8f7c8d924d3c3c4b";
        public static readonly string FrenchBulldogBreedId = "bb57a3e3cd2048e88e02f5b87a935a62";

        public static readonly string CockerSpanielBreedId = "c1a3ebdb3bfa44cc81f3a1f6205f8b64";
        public static readonly string BorderCollieBreedId = "df76e3ed02444a61ad1efba0a5b75f06";
        public static readonly string BeagleBreedId = "e478aa3ff61d4b6f88d3b3e3a7f47b14";

        public static readonly string GoldenRetrieverBreedId = "f3c7da2e95764c47be56aeb742ecf3b1";
        public static readonly string GermanShepherdBreedId = "0d4f1f5a2b4a45d699cf43a66f5b8b22";
        public static readonly string RottweilerBreedId = "1a5c9e4f7d884cf2a3f99e26c7b5a081";

        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Entities.CourseDog>().HasData(
                new Models.Entities.CourseDog
                {
                    Id = CDId1,
                    Status = 1,
                    CourseId = BasicCourseId,
                    DogBreedId = ChihuahuaBreedId,
                    CreatedTime = new DateTimeOffset(new DateTime(2023, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 1, 1))
                },
                new Models.Entities.CourseDog
                {
                    Id = CDId2,
                    Status = 1,
                    CourseId = BasicCourseId,
                    DogBreedId = PomeranianBreedId,
                    CreatedTime = new DateTimeOffset(new DateTime(2023, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 1, 1))
                },
                new Models.Entities.CourseDog
                {
                    Id = CDId3,
                    Status = 1,
                    CourseId = BasicCourseId,
                    DogBreedId = FrenchBulldogBreedId,
                    CreatedTime = new DateTimeOffset(new DateTime(2023, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 1, 1))
                },
                new Models.Entities.CourseDog
                {
                    Id = CDId4,
                    Status = 1,
                    CourseId = BasicCourseId,
                    DogBreedId = GoldenRetrieverBreedId,
                    CreatedTime = new DateTimeOffset(new DateTime(2023, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 1, 1))
                },
                new Models.Entities.CourseDog
                {
                    Id = CDId5,
                    Status = 1,
                    CourseId = AgilityCourseId,
                    DogBreedId = FrenchBulldogBreedId,
                    CreatedTime = new DateTimeOffset(new DateTime(2023, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 1, 1))
                },
                new Models.Entities.CourseDog
                {
                    Id = CDId6,
                    Status = 1,
                    CourseId = AgilityCourseId,
                    DogBreedId = CockerSpanielBreedId,
                    CreatedTime = new DateTimeOffset(new DateTime(2023, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 1, 1))
                },
                new Models.Entities.CourseDog
                {
                    Id = CDId7,
                    Status = 1,
                    CourseId = AgilityCourseId,
                    DogBreedId = BorderCollieBreedId,
                    CreatedTime = new DateTimeOffset(new DateTime(2023, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 1, 1))
                },
                new Models.Entities.CourseDog
                {
                    Id = CDId8,
                    Status = 1,
                    CourseId = AgilityCourseId,
                    DogBreedId = BeagleBreedId,
                    CreatedTime = new DateTimeOffset(new DateTime(2023, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 1, 1))
                },
                new Models.Entities.CourseDog
                {
                    Id = CDId9,
                    Status = 1,
                    CourseId = BehavioralCorrectionCourseId,
                    DogBreedId = GoldenRetrieverBreedId,
                    CreatedTime = new DateTimeOffset(new DateTime(2023, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 1, 1))
                },
                new Models.Entities.CourseDog
                {
                    Id = CDId10,
                    Status = 1,
                    CourseId = BehavioralCorrectionCourseId,
                    DogBreedId = GermanShepherdBreedId,
                    CreatedTime = new DateTimeOffset(new DateTime(2023, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 1, 1))
                },
                new Models.Entities.CourseDog
                {
                    Id = CDId11,
                    Status = 1,
                    CourseId = BehavioralCorrectionCourseId,
                    DogBreedId = RottweilerBreedId,
                    CreatedTime = new DateTimeOffset(new DateTime(2023, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 1, 1))
                },
                new Models.Entities.CourseDog
                {
                    Id = CDId12,
                    Status = 1,
                    CourseId = BehavioralCorrectionCourseId,
                    DogBreedId = FrenchBulldogBreedId,
                    CreatedTime = new DateTimeOffset(new DateTime(2023, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 1, 1))
                },
                new Models.Entities.CourseDog
                {
                    Id = CDId13,
                    Status = 1,
                    CourseId = SocializationCourseId,
                    DogBreedId = ChihuahuaBreedId,
                    CreatedTime = new DateTimeOffset(new DateTime(2023, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 1, 1))
                },
                new Models.Entities.CourseDog
                {
                    Id = CDId14,
                    Status = 1,
                    CourseId = SocializationCourseId,
                    DogBreedId = BeagleBreedId,
                    CreatedTime = new DateTimeOffset(new DateTime(2023, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 1, 1))
                },
                new Models.Entities.CourseDog
                {
                    Id = CDId15,
                    Status = 1,
                    CourseId = SocializationCourseId,
                    DogBreedId = PomeranianBreedId,
                    CreatedTime = new DateTimeOffset(new DateTime(2023, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 1, 1))
                },
                new Models.Entities.CourseDog
                {
                    Id = CDId16,
                    Status = 1,
                    CourseId = SocializationCourseId,
                    DogBreedId = FrenchBulldogBreedId,
                    CreatedTime = new DateTimeOffset(new DateTime(2023, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 1, 1))
                },
                new Models.Entities.CourseDog
                {
                    Id = CDId17,
                    Status = 1,
                    CourseId = ProtectionTrainingCourseId,
                    DogBreedId = FrenchBulldogBreedId,
                    CreatedTime = new DateTimeOffset(new DateTime(2023, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 1, 1))
                },
                new Models.Entities.CourseDog
                {
                    Id = CDId18,
                    Status = 1,
                    CourseId = ProtectionTrainingCourseId,
                    DogBreedId = GoldenRetrieverBreedId,
                    CreatedTime = new DateTimeOffset(new DateTime(2023, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 1, 1))
                },
                new Models.Entities.CourseDog
                {
                    Id = CDId19,
                    Status = 1,
                    CourseId = ProtectionTrainingCourseId,
                    DogBreedId = GermanShepherdBreedId,
                    CreatedTime = new DateTimeOffset(new DateTime(2023, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 1, 1))
                },
                new Models.Entities.CourseDog
                {
                    Id = CDId20,
                    Status = 1,
                    CourseId = ProtectionTrainingCourseId,
                    DogBreedId = RottweilerBreedId,
                    CreatedTime = new DateTimeOffset(new DateTime(2023, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 1, 1))
                },
                new Models.Entities.CourseDog
                {
                    Id = CDId21,
                    Status = 1,
                    CourseId = QuickLearnerCourseId,
                    DogBreedId = FrenchBulldogBreedId,
                    CreatedTime = new DateTimeOffset(new DateTime(2023, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 1, 1))
                },
                new Models.Entities.CourseDog
                {
                    Id = CDId22,
                    Status = 1,
                    CourseId = QuickLearnerCourseId,
                    DogBreedId = GoldenRetrieverBreedId,
                    CreatedTime = new DateTimeOffset(new DateTime(2023, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 1, 1))
                },
                new Models.Entities.CourseDog
                {
                    Id = CDId23,
                    Status = 1,
                    CourseId = QuickLearnerCourseId,
                    DogBreedId = BeagleBreedId,
                    CreatedTime = new DateTimeOffset(new DateTime(2023, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2023, 1, 1))
                }
            );
        }
    }
}
