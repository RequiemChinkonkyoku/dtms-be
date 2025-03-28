using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.SeedingData
{
    public class PaymentMethod
    {
        public static readonly string VnPayMethodId = "1";

        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Entities.PaymentMethod>().HasData(
                new Models.Entities.PaymentMethod
                {
                    Id = VnPayMethodId,
                    Name = "VnPay",
                    Description = "Payment via VnPay",
                    Status = 1,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                }
            );
        }

    }
}
