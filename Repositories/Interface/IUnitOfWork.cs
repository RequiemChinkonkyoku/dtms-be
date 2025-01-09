namespace Repositories.Interface;

public interface IUnitOfWork : IDisposable
{
    IAccountRepository Accounts { get; }
    IAttendanceRepository Attendances { get; }
    IAvailabilityRepository Availabilities { get; }
    IBlogRepository Blogs { get; }
    ICageRepository Cages { get; }
    ICageCategoryRepository CageCategories { get; }
    ICategoryRepository Categories { get; }
    ICertificateRepository Certificates { get; }
    ICertificationRepository Certifications { get; }
    IChatRepository Chats { get; }
    IClassRepository Classes { get; }
    ILessonEquipmentRepository LessonEquipments { get; }
    ISlotLessonRepository SlotLessons { get; }
    ICourseRepository Courses { get; }
    ICustomerProfileRepository CustomerProfiles { get; }
    ICustomerRoleRepository CustomerRoles { get; }
    IDogCertificateRepository DogCertificates { get; }
    IDogDocumentRepository DogDocuments { get; }
    IDogDocumentTypeRepository DogDocumentTypes { get; }
    IDogRepository Dogs { get; }
    IDogBreedRepository DogBreeds { get; }
    IEnrollmentRepository Enrollments { get; }
    IEquipmentRepository Equipments { get; }
    ILegalDocumentRepository LegalDocuments { get; }
    ILessonRepository Lessons { get; }
    IMembershipRepository Memberships { get; }
    INotificationRepository Notifications { get; }
    IPaymentMethodRepository PaymentMethods { get; }
    IPaymentRepository Payments { get; }
    IPrerequisiteRepository Prerequisites { get; }
    IProgressReportRepository ProgressReports { get; }
    IScheduleRepository Schedules { get; }
    ISkillRepository Skills { get; }
    ISlotRepository Slots { get; }
    ISpecializationRepository Specializations { get; }
    IStaffProfileRepository StaffProfiles { get; }
    IStaffRoleRepository StaffRoles { get; }
    ITrainerAssignmentRepository TrainerAssignments { get; }
    ITrainerProfileRepository TrainerProfiles { get; }
    ITrainerReportRepository TrainerReports { get; }
    ITrainerRoleRepository TrainerRoles { get; }
    ITrainerSkillRepository TrainerSkills { get; }
    ITrainerSpecializationRepository TrainerSpecializations { get; }
    IWishListRepository WishLists { get; }
    ITrainingReportRepository TrainingReports { get; }

    Task SaveChanges();
}