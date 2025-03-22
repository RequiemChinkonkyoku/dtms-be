using Microsoft.EntityFrameworkCore;
using Repositories.SeedingData;

namespace Repositories;

public static class ModelBuilderExtensions
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        Role.Seed(modelBuilder);
        Membership.Seed(modelBuilder);
    }
}