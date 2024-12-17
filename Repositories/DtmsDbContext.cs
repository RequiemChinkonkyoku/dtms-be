using System.Reflection.Metadata;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Models.Entities;

namespace Repositories;

public class DtmsDbContext : DbContext
{
    public DtmsDbContext()
    {
        
    }
    
    public DtmsDbContext(DbContextOptions<DtmsDbContext> options) : base(options)
    {
        
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json", true, true)
                .Build();
            var connectionString = configuration.GetConnectionString("DtmsDB");
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
    
    public virtual DbSet<Account> Accounts { get; set; }
    public virtual DbSet<Membership> Memberships { get; set; }
    public virtual DbSet<CustomerProfile> CustomerProfiles { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.Entity<Account>(entity =>
        {
            entity.HasOne(a => a.CustomerProfile)
                .WithOne(cp => cp.Account)
                .HasForeignKey<CustomerProfile>(cp => cp.AccountId)
                .OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(a => a.TrainerProfile)
                .WithOne(tp => tp.Account)
                .HasForeignKey<TrainerProfile>(tp => tp.AccountId)
                .OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(a => a.StaffProfile)
                .WithOne(sp => sp.Account)
                .HasForeignKey<StaffProfile>(sp => sp.AccountId)
                .OnDelete(DeleteBehavior.Cascade);

            // Ensure only one profile type can exist at a time
            entity.HasCheckConstraint(
                "CK_Account_ProfileType",
                "(CustomerProfileId IS NOT NULL AND ProfileType = 'Customer') OR " +
                "(TrainerProfileId IS NOT NULL AND ProfileType = 'Trainer') OR " +
                "(StaffProfileId IS NOT NULL AND ProfileType = 'Staff')"
            );
        });
        
        modelBuilder.Entity<CustomerProfile>()
            .HasOne(cp => cp.Membership) // One CustomerProfile has one Membership
            .WithMany(m => m.CustomerProfiles) // One Membership can have many CustomerProfiles
            .HasForeignKey(cp => cp.MembershipId) // Foreign key in CustomerProfile
            .OnDelete(DeleteBehavior.Restrict); // Prevent cascade delete
    }
}