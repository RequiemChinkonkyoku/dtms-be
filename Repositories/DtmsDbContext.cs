using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
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
                .AddJsonFile("connectionstrings.json", true, true)
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
    public virtual DbSet<Blog> Blogs { get; set; }
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
    public virtual DbSet<Prerequisite> Prerequisites { get; set; }
    public virtual DbSet<CourseLesson> CourseLessons { get; set; }
    public virtual DbSet<Category> Categories { get; set; }
    public virtual DbSet<Specialization> Specializations { get; set; }
    public virtual DbSet<TrainerSpecialization> TrainerSpecializations { get; set; }
    public virtual DbSet<Class> Classes { get; set; }
    public virtual DbSet<TrainerAssignment> TrainerAssignments { get; set; }
    public virtual DbSet<Slot> Slots { get; set; }
    public virtual DbSet<Availability> Availabilities { get; set; }
    public virtual DbSet<Equipment> Equipments { get; set; }
    public virtual DbSet<Schedule> Schedules { get; set; }
    public virtual DbSet<CourseEquipment> CourseEquipments { get; set; }
    public virtual DbSet<SlotEquipment> SlotEquipments { get; set; }
    public virtual DbSet<Cage> Cages { get; set; }
    public virtual DbSet<Certificate> Certificates { get; set; }
    public virtual DbSet<DogCertificate> DogCertificates { get; set; }
    public virtual DbSet<Attendance> Attendances { get; set; }
    public virtual DbSet<ProgressReport> ProgressReports { get; set; }
    public virtual DbSet<TrainingReport> TrainingReports { get; set; }
    public virtual DbSet<TrainerReport> TrainerReports { get; set; }
    public virtual DbSet<WishList> WishLists { get; set; }
    public virtual DbSet<Chat> Chats { get; set; }
    public virtual DbSet<Notification> Notifications { get; set; }

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

        modelBuilder.Entity<TrainerSpecialization>()
            .HasOne(tsp => tsp.TrainerProfile)
            .WithMany(tp => tp.TrainerSpecializations)
            .HasForeignKey(tsp => tsp.TrainerProfileId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<TrainerSpecialization>()
            .HasOne(tsp => tsp.Specialization)
            .WithMany(sp => sp.TrainerSpecializations)
            .HasForeignKey(tsp => tsp.SpecializaionId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Class>()
            .HasOne(cl => cl.Course)
            .WithMany(c => c.Classes)
            .HasForeignKey(cl => cl.CourseId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<TrainerAssignment>()
            .HasOne(ta => ta.TrainerProfile)
            .WithMany(tp => tp.TrainerAssignments)
            .HasForeignKey(ta => ta.TrainerProfileId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<TrainerAssignment>()
            .HasOne(ta => ta.Class)
            .WithMany(c => c.TrainerAssignments)
            .HasForeignKey(ta => ta.ClassId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Slot>()
            .HasOne(sl => sl.Class)
            .WithMany(c => c.Slots)
            .HasForeignKey(sl => sl.ClassId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Slot>()
            .HasOne(sl => sl.Schedule)
            .WithMany(sc => sc.Slots)
            .HasForeignKey(sl => sl.ScheduleId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Availability>()
            .HasOne(av => av.TrainerProfile)
            .WithMany(tp => tp.Availabilities)
            .HasForeignKey(av => av.TrainerProfileId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Availability>()
            .HasOne(av => av.Schedule)
            .WithMany(sc => sc.Availabilities)
            .HasForeignKey(av => av.ScheduleId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<CourseEquipment>()
            .HasOne(ce => ce.Course)
            .WithMany(c => c.CourseEquipment)
            .HasForeignKey(ce => ce.CourseId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<CourseEquipment>()
            .HasOne(ce => ce.Equipment)
            .WithMany(e => e.CourseEquipment)
            .HasForeignKey(ce => ce.EquipmentId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<SlotEquipment>()
            .HasOne(se => se.CourseEquipment)
            .WithMany(ce => ce.SlotEquipments)
            .HasForeignKey(se => se.CourseEquipmentId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<SlotEquipment>()
            .HasOne(se => se.Slot)
            .WithMany(s => s.SlotEquipments)
            .HasForeignKey(se => se.SlotId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Certificate>()
            .HasOne(ct => ct.Course)
            .WithOne(c => c.Certificate)
            .HasForeignKey<Certificate>(c => c.CourseId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<DogCertificate>()
            .HasOne(dc => dc.Dog)
            .WithMany(d => d.DogCertificates)
            .HasForeignKey(dc => dc.DogId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<DogCertificate>()
            .HasOne(dc => dc.Certificate)
            .WithMany(c => c.DogCertificates)
            .HasForeignKey(dc => dc.CertificateId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Enrollment>()
            .HasOne(e => e.Cage)
            .WithMany(c => c.Enrollments)
            .HasForeignKey(e => e.CageId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Enrollment>()
            .HasOne(e => e.Class)
            .WithMany(c => c.Enrollments)
            .HasForeignKey(e => e.ClassId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Enrollment>()
            .HasOne(e => e.Dog)
            .WithMany(d => d.Enrollments)
            .HasForeignKey(e => e.DogId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Attendance>()
            .HasOne(a => a.Dog)
            .WithMany(d => d.Attendances)
            .HasForeignKey(a => a.DogId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Attendance>()
            .HasOne(a => a.Class)
            .WithMany(a => a.Attendances)
            .HasForeignKey(a => a.ClassId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<ProgressReport>()
            .HasOne(pr => pr.Attendance)
            .WithMany(a => a.ProgressReports)
            .HasForeignKey(pr => pr.AttendanceId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<ProgressReport>()
            .HasOne(pr => pr.TrainerProfile)
            .WithMany(t => t.ProgressReports)
            .HasForeignKey(pr => pr.TrainerProfileId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<TrainingReport>()
            .HasOne(tr => tr.Dog)
            .WithMany(d => d.TrainingReports)
            .HasForeignKey(tr => tr.DogId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<TrainingReport>()
            .HasOne(tr => tr.TrainerProfile)
            .WithMany(t => t.TrainingReports)
            .HasForeignKey(tr => tr.TrainerProfileId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<TrainerReport>()
            .HasOne(tp => tp.TrainerProfile)
            .WithMany(t => t.TrainerReports)
            .HasForeignKey(tr => tr.TrainerProfileId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<TrainerReport>()
            .HasOne(tp => tp.CustomerProfile)
            .WithMany(c => c.TrainerReports)
            .HasForeignKey(tr => tr.CustomerProfileId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<WishList>()
            .HasOne(w => w.CustomerProfile)
            .WithMany(c => c.WishLists)
            .HasForeignKey(tr => tr.CustomerProfileId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<WishList>()
            .HasOne(w => w.Course)
            .WithMany(c => c.WishLists)
            .HasForeignKey(tr => tr.CourseId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Chat>()
            .Ignore(c => c.ReceiverAccount);

        modelBuilder.Entity<Chat>()
            .HasOne(c => c.SenderAccount)
            .WithMany(a => a.Chats)
            .HasForeignKey(c => c.SenderId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Chat>()
            .HasOne(n => n.ReceiverAccount)
            .WithMany()
            .HasForeignKey(n => n.ReceiverId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Notification>()
            .HasOne(n => n.ReceiverAccount)
            .WithMany(a => a.Notifications)
            .HasForeignKey(n => n.ReceiverId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}