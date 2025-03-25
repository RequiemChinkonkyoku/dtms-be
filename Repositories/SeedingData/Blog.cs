using Microsoft.EntityFrameworkCore;
using Models.Entities;
using System;

namespace Repositories.SeedingData
{
    public static class Blog
    {
        public static readonly string Blog1Id = "57f1808014f741c79e2791dea717d760";
        public static readonly string Blog2Id = "fc97a573f1224b93b73ddce3eebd4095";

        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Entities.Blog>().HasData(
                new Models.Entities.Blog
                {
                    Id = Blog1Id,
                    Title = "The Importance of Dog Training",
                    Content = "Training your dog is crucial for a harmonious relationship between pet and owner...",
                    ImageUrl = "https://example.com/blog1.jpg",
                    Status = 1,
                    TimePublished = new DateTime(2024, 1, 10),
                    StaffId = Account.StaffEmployeeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2024, 1, 10)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2024, 1, 10))
                },
                new Models.Entities.Blog
                {
                    Id = Blog2Id,
                    Title = "Understanding Canine Nutrition",
                    Content = "Providing a balanced diet is essential for your dog's overall health and well-being...",
                    ImageUrl = "https://example.com/blog2.jpg",
                    Status = 1,
                    TimePublished = new DateTime(2024, 2, 5),
                    StaffId = Account.StaffManagerId,
                    CreatedTime = new DateTimeOffset(new DateTime(2024, 2, 5)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2024, 2, 5))
                }
            );
        }
    }
}