using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.SeedingData
{
    public class CageCategory
    {
        public static readonly string SmallCageId = "57f1808014f741c79e2791dea717d760";
        public static readonly string MediumCageId = "fc97a573f1224b93b73ddce3eebd4095";
        public static readonly string LargeCageId = "79e21dea717d7609e2791dea717d7604";

        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Entities.CageCategory>().HasData(
                new Models.Entities.CageCategory
                {
                    Id = SmallCageId,
                    Name = "Small Cage",
                    Description = "For small dogs",
                    Status = 1,
                    DogTypeId = "d1e2f3a4b5c67890d1e2f3a4b5c67890",
                    CreatedTime = new DateTimeOffset(new DateTime(2024, 1, 10)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2024, 1, 10))
                },
                new Models.Entities.CageCategory
                {
                    Id = MediumCageId,
                    Name = "Medium Cage",
                    Description = "For medium dogs",
                    Status = 1,
                    DogTypeId = "e2f3a4b5c67890d1e2f3a4b5c67890d1",
                    CreatedTime = new DateTimeOffset(new DateTime(2024, 1, 10)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2024, 1, 10))
                },
                new Models.Entities.CageCategory
                {
                    Id = LargeCageId,
                    Name = "Large Cage",
                    Description = "For large dogs",
                    Status = 1,
                    DogTypeId = "f3a4b5c67890d1e2f3a4b5c67890d1e2",
                    CreatedTime = new DateTimeOffset(new DateTime(2024, 1, 10)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2024, 1, 10))
                }
            );
        }
    }
}
