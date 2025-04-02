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


        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Entities.Cage>().HasData(
                new Models.Entities.Cage
                {
                    Id = Cage0Id,
                    Number = 0,
                    Status = 1,
                    Location = "None",
                    CageCategoryId = "57f1808014f741c79e2791dea717d760",
                    CreatedTime = new DateTimeOffset(new DateTime(2024, 1, 10)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2024, 1, 10))
                },
                new Models.Entities.Cage
                {
                    Id = Cage1Id,
                    Number = 1,
                    Status = 1,
                    Location = "Area A",
                    CageCategoryId = "57f1808014f741c79e2791dea717d760",
                    CreatedTime = new DateTimeOffset(new DateTime(2024, 1, 10)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2024, 1, 10))
                },
                new Models.Entities.Cage
                {
                    Id = Cage2Id,
                    Number = 2,
                    Status = 1,
                    Location = "Area B",
                    CageCategoryId = "fc97a573f1224b93b73ddce3eebd4095",
                    CreatedTime = new DateTimeOffset(new DateTime(2024, 1, 10)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2024, 1, 10))
                },
                new Models.Entities.Cage
                {
                    Id = Cage3Id,
                    Number = 3,
                    Status = 1,
                    Location = "Area C",
                    CageCategoryId = "79e21dea717d7609e2791dea717d7604",
                    CreatedTime = new DateTimeOffset(new DateTime(2024, 1, 10)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2024, 1, 10))
                }
            );
        }
    }
}
