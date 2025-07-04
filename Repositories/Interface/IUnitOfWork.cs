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
    IClassRepository Classes { get; }
    ILessonEquipmentRepository LessonEquipments { get; }
    ICourseRepository Courses { get; }
    IDogCertificateRepository DogCertificates { get; }
    IDogDocumentRepository DogDocuments { get; }
    IDogDocumentTypeRepository DogDocumentTypes { get; }
    IDogRepository Dogs { get; }
    IDogBreedRepository DogBreeds { get; }
    IEnrollmentRepository Enrollments { get; }
    IEquipmentRepository Equipments { get; }
    IEquipmentCategoryRepository EquipmentCategories { get; }
    ILegalDocumentRepository LegalDocuments { get; }
    ILessonRepository Lessons { get; }
    IMembershipRepository Memberships { get; }
    INotificationRepository Notifications { get; }
    IPaymentMethodRepository PaymentMethods { get; }
    ITransactionRepository Transactions { get; }
    IPrerequisiteRepository Prerequisites { get; }
    IProgressReportRepository ProgressReports { get; }
    IScheduleRepository Schedules { get; }
    ISkillRepository Skills { get; }
    ISlotRepository Slots { get; }
    ISpecializationRepository Specializations { get; }
    ITrainerAssignmentRepository TrainerAssignments { get; }
    ITrainerReportRepository TrainerReports { get; }
    ITrainerSkillRepository TrainerSkills { get; }
    ITrainerSpecializationRepository TrainerSpecializations { get; }
    IWishListRepository WishLists { get; }
    ITrainingReportRepository TrainingReports { get; }
    IAccountOtpRepository AccountOtps { get; }
    ICourseLessonRepository CourseLessons { get; }
    ICourseDogRepository CourseDogs { get; }
    IDogOwnershipRepository DogOwnerships { get; }
    IPretestRepository Pretests { get; }
    IRoleRepository Roles { get; }
    ILessonPrerequisiteRepository LessonPrerequisites { get; }
    IDogTypeRepository DogTypes{ get; }
    ITransactionRepository Transaction { get; }
    Task SaveChanges();
}