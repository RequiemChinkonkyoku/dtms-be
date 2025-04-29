using Microsoft.AspNetCore.Hosting;
using Repositories.Interface;

namespace Repositories.Implement;

public class UnitOfWork : IUnitOfWork
{
    private readonly DtmsDbContext _dbContext;

    public IAccountRepository Accounts { get; }
    public IAttendanceRepository Attendances { get; }
    public IAvailabilityRepository Availabilities { get; }
    public IBlogRepository Blogs { get; }
    public ICageRepository Cages { get; }
    public ICageCategoryRepository CageCategories { get; }
    public ICategoryRepository Categories { get; }
    public ICertificateRepository Certificates { get; }
    public ICertificationRepository Certifications { get; }
    public IClassRepository Classes { get; }
    public ILessonEquipmentRepository LessonEquipments { get; }
    public ICourseRepository Courses { get; }
    public IDogCertificateRepository DogCertificates { get; }
    public IDogDocumentRepository DogDocuments { get; }
    public IDogDocumentTypeRepository DogDocumentTypes { get; }
    public IDogRepository Dogs { get; }
    public IDogBreedRepository DogBreeds { get; }
    public IEnrollmentRepository Enrollments { get; }
    public IEquipmentRepository Equipments { get; }
    public IEquipmentCategoryRepository EquipmentCategories { get; }
    public ILegalDocumentRepository LegalDocuments { get; }
    public ILessonRepository Lessons { get; }
    public IMembershipRepository Memberships { get; }
    public INotificationRepository Notifications { get; }
    public IPaymentMethodRepository PaymentMethods { get; }
    public ITransactionRepository Transactions { get; }
    public IPrerequisiteRepository Prerequisites { get; }
    public IProgressReportRepository ProgressReports { get; }
    public IScheduleRepository Schedules { get; }
    public ISkillRepository Skills { get; }
    public ISlotRepository Slots { get; }
    public ISpecializationRepository Specializations { get; }
    public ITrainerAssignmentRepository TrainerAssignments { get; }
    public ITrainerReportRepository TrainerReports { get; }
    public ITrainerSkillRepository TrainerSkills { get; }
    public ITrainerSpecializationRepository TrainerSpecializations { get; }
    public ITrainingReportRepository TrainingReports { get; }
    public IWishListRepository WishLists { get; }
    public IAccountOtpRepository AccountOtps { get; }
    public ICourseLessonRepository CourseLessons { get; }
    public ICourseDogRepository CourseDogs { get; }
    public IDogOwnershipRepository DogOwnerships { get; }
    public IPretestRepository Pretests { get; }
    public IRoleRepository Roles { get; }
    public ILessonPrerequisiteRepository LessonPrerequisites { get; }
    public IDogTypeRepository DogTypes{ get; }

    public ITransactionRepository Transaction { get; }


    public UnitOfWork(IAccountRepository accountRepository,
                      IAttendanceRepository attendanceRepository,
                      IAvailabilityRepository availabilityRepository,
                      IBlogRepository blogRepository,
                      ICageRepository cageRepository,
                      ICageCategoryRepository cageCategoryRepository,
                      ICategoryRepository categoryRepository,
                      ICertificateRepository certificateRepository,
                      ICertificationRepository certificationRepository,
                      IClassRepository classRepository,
                      ICourseRepository courseRepository,
                      ILessonEquipmentRepository lessonEquipmentRepository,
                      IDogCertificateRepository dogCertificateRepository,
                      IDogDocumentRepository dogDocumentRepository,
                      IDogDocumentTypeRepository dogDocumentTypeRepository,
                      IDogRepository dogRepository,
                      IDogBreedRepository dogBreedRepository,
                      IEnrollmentRepository enrollmentRepository,
                      IEquipmentRepository equipmentRepository,
                      IEquipmentCategoryRepository equipmentCategoryRepository,
                      ILegalDocumentRepository legalDocumentRepository,
                      ILessonRepository lessonRepository,
                      IMembershipRepository membershipRepository,
                      INotificationRepository notificationRepository,
                      IPaymentMethodRepository paymentMethodRepository,
                      ITransactionRepository transactionRepository,
                      IPrerequisiteRepository prerequisiteRepository,
                      IProgressReportRepository progressReportRepository,
                      IScheduleRepository scheduleRepository,
                      ISkillRepository skillRepository,
                      ILessonEquipmentRepository lessonEquipmentRepository1,
                      ISlotRepository slotRepository,
                      ISpecializationRepository specializationRepository,
                      ITrainerAssignmentRepository trainerAssignmentRepository,
                      ITrainerReportRepository trainerReportRepository,
                      ITrainerSkillRepository trainerSkillRepository,
                      ITrainerSpecializationRepository trainerSpecializationRepository,
                      IWishListRepository wishListRepository,
                      ITrainingReportRepository trainingReports,
                      IAccountOtpRepository accountOtpRepository,
                      ICourseLessonRepository courseLessonRepository,
                      ICourseDogRepository courseDogRepository,
                      IDogOwnershipRepository dogOwnershipRepository,
                      IPretestRepository pretestRepository,
                      IRoleRepository roleRepository,
                      ILessonPrerequisiteRepository lessonPrerequisites,
                      IDogTypeRepository dogTypeRepository,
                      ITransactionRepository transaction)

    {
        _dbContext = new DtmsDbContext();
        Accounts = accountRepository;
        Attendances = attendanceRepository;
        Availabilities = availabilityRepository;
        Blogs = blogRepository;
        Cages = cageRepository;
        CageCategories = cageCategoryRepository;
        Categories = categoryRepository;
        Certificates = certificateRepository;
        Certifications = certificationRepository;
        Classes = classRepository;
        Courses = courseRepository;
        LessonEquipments = lessonEquipmentRepository;
        DogCertificates = dogCertificateRepository;
        DogDocuments = dogDocumentRepository;
        DogDocumentTypes = dogDocumentTypeRepository;
        Dogs = dogRepository;
        DogBreeds = dogBreedRepository;
        Enrollments = enrollmentRepository;
        Equipments = equipmentRepository;
        EquipmentCategories = equipmentCategoryRepository;
        LegalDocuments = legalDocumentRepository;
        Lessons = lessonRepository;
        Memberships = membershipRepository;
        Notifications = notificationRepository;
        PaymentMethods = paymentMethodRepository;
        Transactions = transactionRepository;
        Prerequisites = prerequisiteRepository;
        ProgressReports = progressReportRepository;
        Schedules = scheduleRepository;
        Skills = skillRepository;
        LessonEquipments = lessonEquipmentRepository;
        Slots = slotRepository;
        Specializations = specializationRepository;
        TrainerAssignments = trainerAssignmentRepository;
        TrainerReports = trainerReportRepository;
        TrainerSkills = trainerSkillRepository;
        TrainerSpecializations = trainerSpecializationRepository;
        WishLists = wishListRepository;
        TrainingReports = trainingReports;
        AccountOtps = accountOtpRepository;
        CourseLessons = courseLessonRepository;
        CourseDogs = courseDogRepository;
        DogOwnerships = dogOwnershipRepository;
        Pretests = pretestRepository;
        Roles = roleRepository;
        LessonPrerequisites = lessonPrerequisites;
        DogTypes = dogTypeRepository;
        Transaction = transaction;
    }

    public async Task SaveChanges()
    {
        await _dbContext.SaveChangesAsync();
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (disposing)
        {
            _dbContext.Dispose();
        }
    }
}