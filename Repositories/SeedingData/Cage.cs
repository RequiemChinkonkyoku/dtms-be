using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.SeedingData
{
    public class Cage
    {
        public static readonly string Cage0Id = "-1";
        public static readonly string Cage1Id = "2ba0b50b9b3f48198eb7d789601b22ad";
        public static readonly string Cage2Id = "6588249643834379aa75a9304c33207c";
        public static readonly string Cage3Id = "5696c91a9cff44deafca48fe8bf128b8";
        public static readonly string Cage4Id = "b58a8a39d8304e2ab5e155a57c4d9a14";
        public static readonly string Cage5Id = "d6be91c6ee2e4936a7b1571d4e833fa0";
        public static readonly string Cage6Id = "78d46b734c9847b38f39f91f58b4e5fd";
        public static readonly string Cage7Id = "64e87f1654be463980c3473767ae3b39";
        public static readonly string Cage8Id = "6b0f0d03e1d24f24a7b9c2ad39e7d38f";
        public static readonly string Cage9Id = "937f90c681f448e6ae8c7b4b5b86fbe9";
        public static readonly string Cage10Id = "9d1e6e1651be4d5e80f1a29f4729d1ce";
        public static readonly string Cage11Id = "1c9b6e0e5c4b401ab74fa62c8d7bfa41";
        public static readonly string Cage12Id = "87a02b7e498b4f4dba7e0cb6f9488cbf";
        public static readonly string Cage13Id = "a9465f7dfcd44b019299961ac6dc7e11";
        public static readonly string Cage14Id = "dc08dfdf0c324f5cb4fc9f81a74aebbb";
        public static readonly string Cage15Id = "d5b8a3f7fd744003a10b9838c9f4f5cf";

        public static readonly string Category1Id = "57f1808014f741c79e2791dea717d760";
        public static readonly string Category2Id = "fc97a573f1224b93b73ddce3eebd4095";
        public static readonly string Category3Id = "79e21dea717d7609e2791dea717d7604";

        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Entities.Cage>().HasData(
                new Models.Entities.Cage
                {
                    Id = Cage0Id,
                    Number = 0,
                    Status = 1,
                    Location = "Area A",
                    CageCategoryId = Category1Id,
                    CreatedTime = new DateTimeOffset(new DateTime(2024, 1, 10)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2024, 1, 10))
                },

                new Models.Entities.Cage
                {
                    Id = Cage1Id,
                    Number = 1,
                    Status = 1,
                    Location = "Area A",
                    CageCategoryId = Category1Id,
                    CreatedTime = new DateTimeOffset(new DateTime(2024, 1, 10)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2024, 1, 10))
                },
                new Models.Entities.Cage
                {
                    Id = Cage4Id,
                    Number = 4,
                    Status = 1,
                    Location = "Area A",
                    CageCategoryId = Category1Id,
                    CreatedTime = new DateTimeOffset(new DateTime(2024, 1, 10)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2024, 1, 10))
                },
                new Models.Entities.Cage
                {
                    Id = Cage5Id,
                    Number = 5,
                    Status = 1,
                    Location = "Area A",
                    CageCategoryId = Category1Id,
                    CreatedTime = new DateTimeOffset(new DateTime(2024, 1, 10)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2024, 1, 10))
                },
                new Models.Entities.Cage
                {
                    Id = Cage6Id,
                    Number = 6,
                    Status = 1,
                    Location = "Area A",
                    CageCategoryId = Category1Id,
                    CreatedTime = new DateTimeOffset(new DateTime(2024, 1, 10)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2024, 1, 10))
                },
                new Models.Entities.Cage
                {
                    Id = Cage14Id,
                    Number = 14,
                    Status = 1,
                    Location = "Area A",
                    CageCategoryId = Category1Id,
                    CreatedTime = new DateTimeOffset(new DateTime(2024, 1, 10)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2024, 1, 10))
                },

                new Models.Entities.Cage
                {
                    Id = Cage2Id,
                    Number = 2,
                    Status = 1,
                    Location = "Area B",
                    CageCategoryId = Category2Id,
                    CreatedTime = new DateTimeOffset(new DateTime(2024, 1, 10)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2024, 1, 10))
                },
                new Models.Entities.Cage
                {
                    Id = Cage7Id,
                    Number = 7,
                    Status = 1,
                    Location = "Area B",
                    CageCategoryId = Category2Id,
                    CreatedTime = new DateTimeOffset(new DateTime(2024, 1, 10)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2024, 1, 10))
                },
                new Models.Entities.Cage
                {
                    Id = Cage8Id,
                    Number = 8,
                    Status = 1,
                    Location = "Area B",
                    CageCategoryId = Category2Id,
                    CreatedTime = new DateTimeOffset(new DateTime(2024, 1, 10)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2024, 1, 10))
                },
                new Models.Entities.Cage
                {
                    Id = Cage9Id,
                    Number = 9,
                    Status = 1,
                    Location = "Area B",
                    CageCategoryId = Category2Id,
                    CreatedTime = new DateTimeOffset(new DateTime(2024, 1, 10)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2024, 1, 10))
                },
                new Models.Entities.Cage
                {
                    Id = Cage10Id,
                    Number = 10,
                    Status = 1,
                    Location = "Area B",
                    CageCategoryId = Category2Id,
                    CreatedTime = new DateTimeOffset(new DateTime(2024, 1, 10)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2024, 1, 10))
                },

                new Models.Entities.Cage
                {
                    Id = Cage3Id,
                    Number = 3,
                    Status = 1,
                    Location = "Area C",
                    CageCategoryId = Category3Id,
                    CreatedTime = new DateTimeOffset(new DateTime(2024, 1, 10)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2024, 1, 10))
                },
                new Models.Entities.Cage
                {
                    Id = Cage11Id,
                    Number = 11,
                    Status = 1,
                    Location = "Area C",
                    CageCategoryId = Category3Id,
                    CreatedTime = new DateTimeOffset(new DateTime(2024, 1, 10)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2024, 1, 10))
                },
                new Models.Entities.Cage
                {
                    Id = Cage12Id,
                    Number = 12,
                    Status = 1,
                    Location = "Area C",
                    CageCategoryId = Category3Id,
                    CreatedTime = new DateTimeOffset(new DateTime(2024, 1, 10)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2024, 1, 10))
                },
                new Models.Entities.Cage
                {
                    Id = Cage13Id,
                    Number = 13,
                    Status = 1,
                    Location = "Area C",
                    CageCategoryId = Category3Id,
                    CreatedTime = new DateTimeOffset(new DateTime(2024, 1, 10)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2024, 1, 10))
                },
                new Models.Entities.Cage
                {
                    Id = Cage15Id,
                    Number = 15,
                    Status = 1,
                    Location = "Area C",
                    CageCategoryId = Category3Id,
                    CreatedTime = new DateTimeOffset(new DateTime(2024, 1, 10)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2024, 1, 10))
                }
            );
        }
    }
}
