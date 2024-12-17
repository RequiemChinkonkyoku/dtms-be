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
    public virtual DbSet<TrainerProfile> TrainerProfiles { get; set; }
    public virtual DbSet<StaffProfile> StaffProfiles { get; set; }
    public virtual DbSet<Payment> Payments { get; set; }
    public virtual DbSet<PaymentMethod> PaymentMethods { get; set; }
    public virtual DbSet<Enrollment> Enrollments { get; set; }
    public virtual DbSet<Dog> Dogs { get; set; }
    public virtual DbSet<DogDocument> DogDocuments { get; set; }
    public virtual DbSet<DogDocumentType> DogDocumentTypes { get; set; }
    public virtual DbSet<LegalDocument> LegalDocuments { get; set; }
    public virtual DbSet<StaffRole> StaffRoles { get; set; }
    public virtual DbSet<TrainerRole> TrainerRoles { get; set; }
    public virtual DbSet<Skill> Skills { get; set; }
    public virtual DbSet<TrainerSkill> TrainerSkills { get; set; }
    public virtual DbSet<Lesson> Lessons { get; set; }
    public virtual DbSet<Course> Courses { get; set; }
    public virtual DbSet<CourseLesson> CourseLessons { get; set; }
    public virtual DbSet<Category> Categories { get; set; }

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
        });
        
        modelBuilder.Entity<CustomerProfile>()
            .HasOne(cp => cp.Membership) // One CustomerProfile has one Membership
            .WithMany(m => m.CustomerProfiles) // One Membership can have many CustomerProfiles
            .HasForeignKey(cp => cp.MembershipId) // Foreign key in CustomerProfile
            .OnDelete(DeleteBehavior.Restrict); // Prevent cascade delete
        
        modelBuilder.Entity<Payment>()
            .HasOne(pm => pm.PaymentMethod)
            .WithMany(p => p.Payments)
            .HasForeignKey(pm => pm.PaymentMethodId)
            .OnDelete(DeleteBehavior.Restrict);
        
        modelBuilder.Entity<Payment>()
            .HasOne(p => p.Enrollment)
            .WithOne(e => e.Payment)  
            .HasForeignKey<Enrollment>(e => e.PaymentId)  
            .OnDelete(DeleteBehavior.Cascade); 
        
        modelBuilder.Entity<Dog>()
            .HasOne(d => d.CustomerProfile)
            .WithMany(cp => cp.Dogs)
            .HasForeignKey(d => d.CustomerProfileId)
            .OnDelete(DeleteBehavior.Restrict);
        
        modelBuilder.Entity<DogDocument>()
            .HasOne(dd => dd.DogDocumentType)
            .WithMany(ddt => ddt.DogDocuments)
            .HasForeignKey(dd => dd.DogDocumentTypeId)
            .OnDelete(DeleteBehavior.Restrict);
        
        modelBuilder.Entity<DogDocument>()
            .HasOne(dd => dd.Dog)
            .WithMany(d => d.DogDocuments)
            .HasForeignKey(dd => dd.DogId)
            .OnDelete(DeleteBehavior.Restrict);
        
        modelBuilder.Entity<LegalDocument>()
            .HasOne(dd => dd.CustomerProfile)
            .WithMany(d => d.LegalDocuments)
            .HasForeignKey(dd => dd.CustomerProfileId)
            .OnDelete(DeleteBehavior.Restrict);
        
        modelBuilder.Entity<StaffProfile>()
            .HasOne(dd => dd.StaffRole)
            .WithMany(d => d.StaffProfiles)
            .HasForeignKey(dd => dd.StaffRoleId)
            .OnDelete(DeleteBehavior.Restrict);
        
        modelBuilder.Entity<Blog>()
            .HasOne(dd => dd.StaffProfile)
            .WithMany(d => d.Blogs)
            .HasForeignKey(dd => dd.StaffProfileId)
            .OnDelete(DeleteBehavior.Restrict);
        
        modelBuilder.Entity<TrainerProfile>()
            .HasOne(dd => dd.TrainerRole)
            .WithMany(d => d.TrainerProfiles)
            .HasForeignKey(dd => dd.TrainerRoleId)
            .OnDelete(DeleteBehavior.Restrict);
        
        modelBuilder.Entity<Certifications>()
            .HasOne(dd => dd.TrainerProfile)
            .WithMany(d => d.Certifications)
            .HasForeignKey(dd => dd.TrainerProfileId)
            .OnDelete(DeleteBehavior.Restrict);
        
        modelBuilder.Entity<TrainerSkill>()
            .HasOne(dd => dd.TrainerProfile)
            .WithMany(d => d.TrainerSkills)
            .HasForeignKey(dd => dd.TrainerProfileId)
            .OnDelete(DeleteBehavior.Restrict);
        
        modelBuilder.Entity<TrainerSkill>()
            .HasOne(dd => dd.Skill)
            .WithMany(d => d.TrainerSkills)
            .HasForeignKey(dd => dd.SkillId)
            .OnDelete(DeleteBehavior.Restrict);
        
        modelBuilder.Entity<Lesson>()
            .HasOne(dd => dd.Skill)
            .WithMany(d => d.Lessons)
            .HasForeignKey(dd => dd.SkillId)
            .OnDelete(DeleteBehavior.Restrict);
        
        modelBuilder.Entity<Course>()
            .HasOne(dd => dd.Category)
            .WithMany(d => d.Courses)
            .HasForeignKey(dd => dd.CategoryId)
            .OnDelete(DeleteBehavior.Restrict);
        
        modelBuilder.Entity<Course>()
            .HasOne(dd => dd.TrainerProfile)
            .WithMany(d => d.Courses)
            .HasForeignKey(dd => dd.TrainerProfileId)
            .OnDelete(DeleteBehavior.Restrict);
        
        modelBuilder.Entity<CourseLesson>()
            .HasOne(dd => dd.Course)
            .WithMany(d => d.CourseLessons)
            .HasForeignKey(dd => dd.CourseId)
            .OnDelete(DeleteBehavior.Restrict);
        
        modelBuilder.Entity<CourseLesson>()
            .HasOne(dd => dd.Lesson)
            .WithMany(d => d.CourseLessons)
            .HasForeignKey(dd => dd.LessonId)
            .OnDelete(DeleteBehavior.Restrict);
        
        modelBuilder.Entity<Prerequisite>()
            .HasOne(p => p.Course) // The course requiring prerequisites
            .WithMany(c => c.Prerequisites)
            .HasForeignKey(p => p.CourseId)
            .OnDelete(DeleteBehavior.Restrict); // Prevent cascading deletes

        modelBuilder.Entity<Prerequisite>()
            .HasOne(p => p.PrerequisiteCourse) // The prerequisite course
            .WithOne() // 1-to-1 constraint
            .HasForeignKey<Prerequisite>(p => p.PrerequisiteCourseId)
            .OnDelete(DeleteBehavior.Restrict); // Prevent cascading deletes
    }
}