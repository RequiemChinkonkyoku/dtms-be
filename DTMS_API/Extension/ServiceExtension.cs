
using Models.Entities;
using Repositories.Implement;
using Repositories.Interface;
using Services.Implement;
using Services.Interface;
using Services.Setting;

namespace DTMS_API.Extension;

public static class ServiceExtension
{
    public static IServiceCollection AddServiceExtension(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));

        services.AddScoped<IUnitOfWork, UnitOfWork>();

        services.AddScoped<IAccountRepository, AccountRepository>();
        services.AddScoped<IAttendanceRepository, AttendanceRepository>();
        services.AddScoped<IAvailabilityRepository, AvailabilityRepository>();
        services.AddScoped<IBlogRepository, BlogRepository>();
        services.AddScoped<ICageRepository, CageRepository>();
        services.AddScoped<ICageCategoryRepository, CageCategoryRepository>();
        services.AddScoped<ICategoryRepository, CategoryRepository>();
        services.AddScoped<ICertificateRepository, CertificateRepository>();
        services.AddScoped<ICertificationRepository, CertificationRepository>();
        services.AddScoped<IChatRepository, ChatRepository>();
        services.AddScoped<IClassRepository, ClassRepository>();
        services.AddScoped<ICourseRepository, CourseRepository>();
        services.AddScoped<ILessonEquipmentRepository, LessonEquipmentRepository>();
        services.AddScoped<ICustomerProfileRepository, CustomerProfileRepository>();
        services.AddScoped<ICustomerRoleRepository, CustomerRoleRepository>();
        services.AddScoped<IDogRepository, DogRepository>();
        services.AddScoped<IDogBreedRepository, DogBreedRepository>();
        services.AddScoped<IDogCertificateRepository, DogCertificateRepository>();
        services.AddScoped<IDogDocumentRepository, DogDocumentRepository>();
        services.AddScoped<IDogDocumentTypeRepository, DogDocumentTypeRepository>();
        services.AddScoped<IEnrollmentRepository, EnrollmentRepository>();
        services.AddScoped<IEquipmentRepository, EquipmentRepository>();
        services.AddScoped<IEquipmentCategoryRepository, EquipmentCategoryRepository>();
        services.AddScoped<ILegalDocumentRepository, LegalDocumentRepository>();
        services.AddScoped<ILessonRepository, LessonRepository>();
        services.AddScoped<IMembershipRepository, MembershipRepository>();
        services.AddScoped<INotificationRepository, NotificationRepository>();
        services.AddScoped<ITransactionRepository, TransactionRepository>();
        services.AddScoped<IPaymentMethodRepository, PaymentMethodRepository>();
        services.AddScoped<IPrerequisiteRepository, PrerequisiteRepository>();
        services.AddScoped<IProgressReportRepository, ProgressReportRepository>();
        services.AddScoped<IScheduleRepository, ScheduleRepository>();
        services.AddScoped<ISkillRepository, SkillRepository>();
        services.AddScoped<ISlotRepository, SlotRepository>();
        services.AddScoped<ISpecializationRepository, SpecializationRepository>();
        services.AddScoped<IStaffProfileRepository, StaffProfileRepository>();
        services.AddScoped<IStaffRoleRepository, StaffRoleRepository>();
        services.AddScoped<ITrainerAssignmentRepository, TrainerAssignmentRepository>();
        services.AddScoped<ITrainerProfileRepository, TrainerProfileRepository>();
        services.AddScoped<ITrainerReportRepository, TrainerReportRepository>();
        services.AddScoped<ITrainerRoleRepository, TrainerRoleRepository>();
        services.AddScoped<ITrainerSkillRepository, TrainerSkillRepository>();
        services.AddScoped<ITrainerSpecializationRepository, TrainerSpecializationRepository>();
        services.AddScoped<ITrainingReportRepository, TrainingReportRepository>();
        services.AddScoped<IWishListRepository, WishListRepository>();
        services.AddScoped<IAccountOtpRepository, AccountOtpRepository>();
        services.AddScoped<ICourseLessonRepository, CourseLessonRepository>();
        services.AddScoped<ICourseDogRepository, CourseDogRepository>();
        services.AddScoped<IDogOwnershipRepository, DogOwnershipRepository>();
        services.AddScoped<IPretestRepository, PretestRepository>();
        services.AddScoped<IRoleRepository, RoleRepository>();
        services.AddScoped<ILessonPrerequisiteRepository, LessonPrerequisiteRepository>();
        services.AddScoped<IDogTypeRepository, DogTypeRepository>();

        services.AddScoped<IAccountService, AccountService>();
        services.AddScoped<IAttendanceService, AttendanceService>();
        services.AddScoped<IAvailabilityService, AvailabilityService>();
        services.AddScoped<IBlogService, BlogService>();
        services.AddScoped<ICageService, CageService>();
        services.AddScoped<ICageCategoryService, CageCategoryService>();
        services.AddScoped<ICategoryService, CategoryService>();
        services.AddScoped<ICertificateService, CertificateService>();
        services.AddScoped<ICertificationService, CertificationService>();
        services.AddScoped<IChatService, ChatService>();
        services.AddScoped<IClassService, ClassService>();
        services.AddScoped<ICourseService, CourseService>();
        services.AddScoped<ILessonEquipmentService, LessonEquipmentService>();
        services.AddScoped<ICustomerProfileService, CustomerProfileService>();
        services.AddScoped<ICustomerRoleService, CustomerRoleService>();
        services.AddScoped<IDogService, DogService>();
        services.AddScoped<IDogBreedService, DogBreedService>();
        services.AddScoped<IDogCertificateService, DogCertificateService>();
        services.AddScoped<IDogDocumentService, DogDocumentService>();
        services.AddScoped<IDogDocumentTypeService, DogDocumentTypeService>();
        services.AddScoped<IEnrollmentService, EnrollmentService>();
        services.AddScoped<IEquipmentService, EquipmentService>();
        services.AddScoped<IEquipmentCategoryService, EquipmentCategoryService>();
        services.AddScoped<ILegalDocumentService, LegalDocumentService>();
        services.AddScoped<ILessonService, LessonService>();
        services.AddScoped<IMembershipService, MembershipService>();
        services.AddScoped<INotificationService, NotificationService>();
        services.AddScoped<IPaymentService, PaymentService>();
        services.AddScoped<IPaymentMethodService, PaymentMethodService>();
        services.AddScoped<IPrerequisiteService, PrerequisiteService>();
        services.AddScoped<IProgressReportService, ProgressReportService>();
        services.AddScoped<IScheduleService, ScheduleService>();
        services.AddScoped<ISkillService, SkillService>();
        services.AddScoped<ISlotService, SlotService>();
        services.AddScoped<ISpecializationService, SpecializationService>();
        services.AddScoped<IStaffProfileService, StaffProfileService>();
        services.AddScoped<IStaffRoleService, StaffRoleService>();
        services.AddScoped<ITrainerAssignmentService, TrainerAssignmentService>();
        services.AddScoped<ITrainerProfileService, TrainerProfileService>();
        services.AddScoped<ITrainerReportService, TrainerReportService>();
        services.AddScoped<ITrainerRoleService, TrainerRoleService>();
        services.AddScoped<ITrainerSkillService, TrainerSkillService>();
        services.AddScoped<ITrainerSpecializationService, TrainerSpecializationService>();
        services.AddScoped<ITrainingReportService, TrainingReportService>();
        services.AddScoped<IWishListService, WishListService>();
        services.AddScoped<IDogOwnershipsService, DogOwnershipsService>();
        services.AddScoped<IRoleService, RoleService>();
        services.AddScoped<IVnPayService, VnPayService>();
        services.AddScoped<IPretestService, PretestService>();
        services.AddScoped<ILessonPrerequisiteService, LessonPrerequisiteService>();

        services.AddSignalR();

        //External Services
        services.Configure<CloudinarySetting>(configuration.GetSection("CloudinarySetting"));
        services.AddScoped<ICloudinaryService, CloudinaryService>();

        return services;
    }
}