using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.SeedingData
{
    public class LessonEquipment
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Entities.LessonEquipment>().HasData(
                // Lesson 1 - Basic Training Equipment
                new Models.Entities.LessonEquipment
                {
                    Id = "2a27bcf3-dfa6-4473-a1fd-bc9fd5776522",
                    LessonId = Lesson.BasicLessonId,
                    EquipmentId = Equipment.ClickerId,
                    Quantity = 2,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.LessonEquipment
                {
                    Id = "5c75803a-7992-4029-8c61-b023ad4d2817",
                    LessonId = Lesson.BasicLessonId,
                    EquipmentId = Equipment.HarnessId,
                    Quantity = 3,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.LessonEquipment
                {
                    Id = "e8425e60-e6d1-401b-90ee-35f92f780e38",
                    LessonId = Lesson.BasicLessonId,
                    EquipmentId = Equipment.BrushId,
                    Quantity = 1,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.LessonEquipment
                {
                    Id = "c70d780d-3e03-475e-84fa-072e93bdd9d3",
                    LessonId = Lesson.BasicLessonId,
                    EquipmentId = Equipment.TrainingLeashId,
                    Quantity = 4,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },

                // Lesson 2 - Agility Training Equipment
                new Models.Entities.LessonEquipment
                {
                    Id = "f102119b-755e-4d9f-93ac-b81cd02e63cf",
                    LessonId = Lesson.AgilityLessonId,
                    EquipmentId = Equipment.TrainingLeashId,
                    Quantity = 4,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.LessonEquipment
                {
                    Id = "13772874-9fa8-4015-9f15-88286751f87d",
                    LessonId = Lesson.AgilityLessonId,
                    EquipmentId = Equipment.AgilityPolesId,
                    Quantity = 6,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.LessonEquipment
                {
                    Id = "f1430a6d-0bc4-41be-8db5-c20e6ae56aba",
                    LessonId = Lesson.AgilityLessonId,
                    EquipmentId = Equipment.TreatPouchId,
                    Quantity = 2,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.LessonEquipment
                {
                    Id = "1a54eff4-fb3f-460b-ac1a-c6b1513da2b4",
                    LessonId = Lesson.AgilityLessonId,
                    EquipmentId = Equipment.WhistleId,
                    Quantity = 1,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },

                // Continue with the same pattern for remaining lessons...
                new Models.Entities.LessonEquipment
                {
                    Id = "0ea1596f-c90c-43a4-ab98-46c28bff058b",
                    LessonId = Lesson.BehavioralCorrectionLessonId,
                    EquipmentId = Equipment.TreatPouchId,
                    Quantity = 2,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.LessonEquipment
                {
                    Id = "4315c999-84be-402e-a5d8-61794312725d",
                    LessonId = Lesson.BehavioralCorrectionLessonId,
                    EquipmentId = Equipment.WhistleId,
                    Quantity = 1,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.LessonEquipment
                {
                    Id = "ed7a2e59-228d-4b28-ae5c-88d279685f9f",
                    LessonId = Lesson.BehavioralCorrectionLessonId,
                    EquipmentId = Equipment.TargetStickId,
                    Quantity = 3,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.LessonEquipment
                {
                    Id = "b4792d46-bb29-4818-a877-c5fd5a519571",
                    LessonId = Lesson.BehavioralCorrectionLessonId,
                    EquipmentId = Equipment.TugToyId,
                    Quantity = 2,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },

                // Lesson 4 - Socialization Equipment
                new Models.Entities.LessonEquipment
                {
                    Id = "e9aa8c1e-bac5-442f-9d2d-2ca6fada6028",
                    LessonId = Lesson.SocializationLessonId,
                    EquipmentId = Equipment.TargetStickId,
                    Quantity = 3,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.LessonEquipment
                {
                    Id = "68f0ef61-bf18-49d3-8a80-c7a2fa3b9580",
                    LessonId = Lesson.SocializationLessonId,
                    EquipmentId = Equipment.TugToyId,
                    Quantity = 2,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.LessonEquipment
                {
                    Id = "39a80597-2a3b-4d76-bb0c-9b86a2fb75e7",
                    LessonId = Lesson.SocializationLessonId,
                    EquipmentId = Equipment.PuzzleFeederId,
                    Quantity = 1,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.LessonEquipment
                {
                    Id = "fe4f8280-56d0-4a7b-a7a5-a8a54bd624cd",
                    LessonId = Lesson.SocializationLessonId,
                    EquipmentId = Equipment.ClickerId,
                    Quantity = 2,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },

                // Lesson 5 - Protection Training Equipment
                new Models.Entities.LessonEquipment
                {
                    Id = "1cb8ae5c-9ac0-4435-9178-ec6c2fab5e5d",
                    LessonId = Lesson.ProtectionTrainingLessonId,
                    EquipmentId = Equipment.PuzzleFeederId,
                    Quantity = 1,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.LessonEquipment
                {
                    Id = "673773c7-4907-4c38-b5f0-36b77bd8d3c4",
                    LessonId = Lesson.ProtectionTrainingLessonId,
                    EquipmentId = Equipment.ClickerId,
                    Quantity = 2,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.LessonEquipment
                {
                    Id = "f34217c6-2c3d-46ad-9cb9-c521225f27aa",
                    LessonId = Lesson.ProtectionTrainingLessonId,
                    EquipmentId = Equipment.HarnessId,
                    Quantity = 3,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.LessonEquipment
                {
                    Id = "42d21a61-2cb4-45d1-af06-1833ab07eb27",
                    LessonId = Lesson.ProtectionTrainingLessonId,
                    EquipmentId = Equipment.BrushId,
                    Quantity = 1,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                }
                );
        }

    }
}
