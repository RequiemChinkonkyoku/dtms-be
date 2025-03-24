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
    public virtual DbSet<Category> Categories { get; set; }
    public virtual DbSet<Specialization> Specializations { get; set; }
    public virtual DbSet<TrainerSpecialization> TrainerSpecializations { get; set; }
    public virtual DbSet<Class> Classes { get; set; }
    public virtual DbSet<TrainerAssignment> TrainerAssignments { get; set; }
    public virtual DbSet<Slot> Slots { get; set; }
    public virtual DbSet<Availability> Availabilities { get; set; }
    public virtual DbSet<Equipment> Equipments { get; set; }
    public virtual DbSet<Schedule> Schedules { get; set; }
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
    public virtual DbSet<CageCategory> CageCategories { get; set; }
    public virtual DbSet<LessonEquipment> LessonEquipments { get; set; }
    public virtual DbSet<EquipmentCategory> EquipmentCategories { get; set; }
    public virtual DbSet<DogBreed> DogBreeds { get; set; }
    public virtual DbSet<CustomerRole> CustomerRoles { get; set; }
    public virtual DbSet<AccountOtp> AccountOtps { get; set; }
    public virtual DbSet<CourseLesson> CourseLessons { get; set; }
    public virtual DbSet<CourseDog> CourseDogs { get; set; }
    public virtual DbSet<DogOwnership> DogOwnerships { get; set; }
    public virtual DbSet<PreTest> PreTests { get; set; }
    public virtual DbSet<DogType> DogTypes { get; set; }

    public virtual DbSet<Models.Entities.Role> Roles { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Account>()
            .HasOne(m => m.Membership) // One CustomerProfile has one Membership
            .WithMany(a => a.Accounts) // One Membership can have many CustomerProfiles
            .HasForeignKey(m => m.MembershipId) // Foreign key in CustomerProfile
            .OnDelete(DeleteBehavior.Restrict); // Prevent cascade delete

        modelBuilder.Entity<Payment>()
            .HasOne(pm => pm.PaymentMethod)
            .WithMany(p => p.Payments)
            .HasForeignKey(pm => pm.PaymentMethodId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Payment>()
            .HasOne(p => p.Enrollment)
            .WithMany(e => e.Payments)
            .HasForeignKey(p => p.EnrollmentId)
            .OnDelete(DeleteBehavior.Cascade);

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
            .HasOne(dd => dd.Customer)
            .WithMany(d => d.LegalDocuments)
            .HasForeignKey(dd => dd.CustomerId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Blog>()
            .HasOne(dd => dd.Staff)
            .WithMany(d => d.Blogs)
            .HasForeignKey(dd => dd.StaffId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Certifications>()
            .HasOne(dd => dd.Trainer)
            .WithMany(d => d.Certifications)
            .HasForeignKey(dd => dd.TrainerId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<TrainerSkill>()
            .HasOne(dd => dd.Trainer)
            .WithMany(d => d.TrainerSkills)
            .HasForeignKey(dd => dd.TrainerId)
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
            .HasOne(dd => dd.Trainer)
            .WithMany(d => d.Courses)
            .HasForeignKey(dd => dd.CreatedTrainerId)
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
            .HasOne(tsp => tsp.Trainer)
            .WithMany(tp => tp.TrainerSpecializations)
            .HasForeignKey(tsp => tsp.TrainerId)
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
            .HasOne(ta => ta.Trainer)
            .WithMany(tp => tp.TrainerAssignments)
            .HasForeignKey(ta => ta.TrainerId)
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
            .HasOne(av => av.Trainer)
            .WithMany(tp => tp.Availabilities)
            .HasForeignKey(av => av.TrainerId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Availability>()
            .HasOne(av => av.Schedule)
            .WithMany(sc => sc.Availabilities)
            .HasForeignKey(av => av.ScheduleId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<LessonEquipment>()
            .HasOne(ce => ce.Lesson)
            .WithMany(c => c.LessonEquipments)
            .HasForeignKey(ce => ce.LessonId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<LessonEquipment>()
            .HasOne(ce => ce.Equipment)
            .WithMany(e => e.LessonEquipments)
            .HasForeignKey(ce => ce.EquipmentId)
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
            .HasOne(a => a.Slot)
            .WithMany(a => a.Attendances)
            .HasForeignKey(a => a.SlotId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<ProgressReport>()
            .HasOne(pr => pr.Attendance)
            .WithMany(a => a.ProgressReports)
            .HasForeignKey(pr => pr.AttendanceId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<ProgressReport>()
            .HasOne(pr => pr.Trainer)
            .WithMany(t => t.ProgressReports)
            .HasForeignKey(pr => pr.TrainerId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<TrainingReport>()
            .HasOne(tr => tr.Enrollment)
            .WithMany(d => d.TrainingReports)
            .HasForeignKey(tr => tr.EnrollmentId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<TrainingReport>()
            .HasOne(tr => tr.Trainer)
            .WithMany(t => t.TrainingReports)
            .HasForeignKey(tr => tr.TrainerId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<TrainerReport>()
            .HasOne(tr => tr.Trainer)
            .WithMany(a => a.TrainerReportsAsTrainer) // Use the new collection
            .HasForeignKey(tr => tr.TrainerId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<TrainerReport>()
            .HasOne(tr => tr.Customer)
            .WithMany(a => a.TrainerReportsAsCustomer) // Use the new collection
            .HasForeignKey(tr => tr.CustomerId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<WishList>()
            .HasOne(w => w.Customer)
            .WithMany(c => c.WishLists)
            .HasForeignKey(tr => tr.CustomerId)
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

        modelBuilder.Entity<Cage>()
            .HasOne(c => c.CageCategory)
            .WithMany(cc => cc.Cages)
            .HasForeignKey(c => c.CageCategoryId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Equipment>()
            .HasOne(e => e.EquipmentCategory)
            .WithMany(ec => ec.Equipments)
            .HasForeignKey(e => e.EquipmentCategoryId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Dog>()
            .HasOne(d => d.DogBreed)
            .WithMany(db => db.Dogs)
            .HasForeignKey(d => d.DogBreedId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<AccountOtp>()
            .HasOne(u => u.Account)
            .WithMany(r => r.AccountOtps)
            .HasForeignKey(u => u.AccountId)
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

        modelBuilder.Entity<CourseDog>()
            .HasOne(dd => dd.Course)
            .WithMany(d => d.CourseDogs)
            .HasForeignKey(dd => dd.CourseId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<CourseDog>()
            .HasOne(dd => dd.DogBreed)
            .WithMany(d => d.CourseDogs)
            .HasForeignKey(dd => dd.DogBreedId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<DogOwnership>()
            .HasOne(dd => dd.Customer)
            .WithMany(d => d.DogOwnerships)
            .HasForeignKey(dd => dd.CustomerId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<DogOwnership>()
            .HasOne(dd => dd.Dog)
            .WithMany(d => d.DogOwnerships)
            .HasForeignKey(dd => dd.DogId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<PreTest>()
            .HasOne(dd => dd.Dog)
            .WithMany(d => d.PreTests)
            .HasForeignKey(dd => dd.DogId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<PreTest>()
            .HasOne(dd => dd.Class)
            .WithMany(d => d.PreTests)
            .HasForeignKey(dd => dd.ClassId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<DogBreed>()
            .HasOne(db => db.DogType)
            .WithMany(dt => dt.DogBreeds)
            .HasForeignKey(db => db.DogTypeId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<CageCategory>()
            .HasOne(cc => cc.DogType)
            .WithMany(dt => dt.CageCategories)
            .HasForeignKey(cc => cc.DogTypeId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Account>()
            .HasOne(a => a.Role)
            .WithMany(r => r.Accounts)
            .HasForeignKey(a => a.RoleId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Payment>()
            .HasOne(a => a.Customer)
            .WithMany(r => r.Payments)
            .HasForeignKey(a => a.CustomerId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Enrollment>()
            .HasOne(e => e.Staff)
            .WithMany(d => d.Enrollments)
            .HasForeignKey(e => e.StaffId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Seed();
    }
}