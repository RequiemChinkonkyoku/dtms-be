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
    public IChatRepository Chats { get; }
    public IClassRepository Classes { get; }
    public ILessonEquipmentRepository LessonEquipments { get; }
    public ISlotLessonRepository SlotLessons { get; }
    public ICourseRepository Courses { get; }
    public ICustomerProfileRepository CustomerProfiles { get; }
    public ICustomerRoleRepository CustomerRoles { get; }
    public IDogCertificateRepository DogCertificates { get; }
    public IDogDocumentRepository DogDocuments { get; }
    public IDogDocumentTypeRepository DogDocumentTypes { get; }
    public IDogRepository Dogs { get; }
    public IDogBreedRepository DogBreeds { get; }
    public IEnrollmentRepository Enrollments { get; }
    public IEquipmentRepository Equipments { get; }
    public ILegalDocumentRepository LegalDocuments { get; }
    public ILessonRepository Lessons { get; }
    public IMembershipRepository Memberships { get; }
    public INotificationRepository Notifications { get; }
    public IPaymentMethodRepository PaymentMethods { get; }
    public IPaymentRepository Payments { get; }
    public IPrerequisiteRepository Prerequisites { get; }
    public IProgressReportRepository ProgressReports { get; }
    public IScheduleRepository Schedules { get; }
    public ISkillRepository Skills { get; }
    public ISlotRepository Slots { get; }
    public ISpecializationRepository Specializations { get; }
    public IStaffProfileRepository StaffProfiles { get; }
    public IStaffRoleRepository StaffRoles { get; }
    public ITrainerAssignmentRepository TrainerAssignments { get; }
    public ITrainerProfileRepository TrainerProfiles { get; }
    public ITrainerReportRepository TrainerReports { get; }
    public ITrainerRoleRepository TrainerRoles { get; }
    public ITrainerSkillRepository TrainerSkills { get; }
    public ITrainerSpecializationRepository TrainerSpecializations { get; }
    public ITrainingReportRepository TrainingReports { get; }
    public IWishListRepository WishLists { get; }
    public IAccountOtpRepository AccountOtps { get; }

    public UnitOfWork(IAccountRepository accountRepository,
                      IAttendanceRepository attendanceRepository,
                      IAvailabilityRepository availabilityRepository,
                      IBlogRepository blogRepository,
                      ICageRepository cageRepository,
                      ICageCategoryRepository cageCategoryRepository,
                      ICategoryRepository categoryRepository,
                      ICertificateRepository certificateRepository,
                      ICertificationRepository certificationRepository,
                      IChatRepository chatRepository,
                      IClassRepository classRepository,
                      ICourseRepository courseRepository,
                      ILessonEquipmentRepository lessonEquipmentRepository,
                      ISlotLessonRepository slotLessonRepository,
                      ICustomerProfileRepository customerProfileRepository,
                      ICustomerRoleRepository customerRoleRepository,
                      IDogCertificateRepository dogCertificateRepository,
                      IDogDocumentRepository dogDocumentRepository,
                      IDogDocumentTypeRepository dogDocumentTypeRepository,
                      IDogRepository dogRepository,
                      IDogBreedRepository dogBreedRepository,
                      IEnrollmentRepository enrollmentRepository,
                      IEquipmentRepository equipmentRepository,
                      ILegalDocumentRepository legalDocumentRepository,
                      ILessonRepository lessonRepository,
                      IMembershipRepository membershipRepository,
                      INotificationRepository notificationRepository,
                      IPaymentMethodRepository paymentMethodRepository,
                      IPaymentRepository paymentRepository,
                      IPrerequisiteRepository prerequisiteRepository,
                      IProgressReportRepository progressReportRepository,
                      IScheduleRepository scheduleRepository,
                      ISkillRepository skillRepository,
                      ILessonEquipmentRepository lessonEquipmentRepository1,
                      ISlotRepository slotRepository,
                      ISpecializationRepository specializationRepository,
                      IStaffProfileRepository staffProfileRepostitory,
                      IStaffRoleRepository staffRoleRepository,
                      ITrainerAssignmentRepository trainerAssignmentRepository,
                      ITrainerProfileRepository trainerProfileRepository,
                      ITrainerReportRepository trainerReportRepository,
                      ITrainerRoleRepository trainerRoleRepository,
                      ITrainerSkillRepository trainerSkillRepository,
                      ITrainerSpecializationRepository trainerSpecializationRepository,
                      IWishListRepository wishListRepository,
                      ITrainingReportRepository trainingReports,
                      IAccountOtpRepository accountOtpRepository)
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
        Chats = chatRepository;
        Classes = classRepository;
        Courses = courseRepository;
        LessonEquipments = lessonEquipmentRepository;
        SlotLessons = slotLessonRepository;
        CustomerProfiles = customerProfileRepository;
        CustomerRoles = customerRoleRepository;
        DogCertificates = dogCertificateRepository;
        DogDocuments = dogDocumentRepository;
        DogDocumentTypes = dogDocumentTypeRepository;
        Dogs = dogRepository;
        DogBreeds = dogBreedRepository;
        Enrollments = enrollmentRepository;
        Equipments = equipmentRepository;
        LegalDocuments = legalDocumentRepository;
        Lessons = lessonRepository;
        Memberships = membershipRepository;
        Notifications = notificationRepository;
        PaymentMethods = paymentMethodRepository;
        Payments = paymentRepository;
        Prerequisites = prerequisiteRepository;
        ProgressReports = progressReportRepository;
        Schedules = scheduleRepository;
        Skills = skillRepository;
        LessonEquipments = lessonEquipmentRepository;
        Slots = slotRepository;
        Specializations = specializationRepository;
        StaffProfiles = staffProfileRepostitory;
        StaffRoles = staffRoleRepository;
        TrainerAssignments = trainerAssignmentRepository;
        TrainerProfiles = trainerProfileRepository;
        TrainerReports = trainerReportRepository;
        TrainerRoles = trainerRoleRepository;
        TrainerSkills = trainerSkillRepository;
        TrainerSpecializations = trainerSpecializationRepository;
        WishLists = wishListRepository;
        TrainingReports = trainingReports;
        AccountOtps = accountOtpRepository;
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