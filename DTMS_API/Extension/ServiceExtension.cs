using Models.Entities;
using Repositories.Implement;
using Repositories.Interface;
using Services.Implement;
using Services.Interface;

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
        services.AddScoped<ICategoryRepository, CategoryRepository>();
        services.AddScoped<ICertificateRepository, CertificateRepository>();
        services.AddScoped<ICertificationRepository, CertificationRepository>();
        services.AddScoped<IChatRepository, ChatRepository>();
        services.AddScoped<IClassRepository, ClassRepository>();
        services.AddScoped<ICourseRepository, CourseRepository>();
        services.AddScoped<ICourseEquipmentRepository, CourseEquipmentRepository>();
        services.AddScoped<ICourseLessonRepository, CourseLessonRepository>();
        services.AddScoped<ICustomerProfileRepository, CustomerProfileRepository>();
        services.AddScoped<IDogRepository, DogRepository>();
        services.AddScoped<IDogCertificateRepository, DogCertificateRepository>();
        services.AddScoped<IDogDocumentRepository, DogDocumentRepository>();
        services.AddScoped<IDogDocumentTypeRepository, DogDocumentTypeRepository>();
        services.AddScoped<IEnrollmentRepository, EnrollmentRepository>();
        services.AddScoped<IEquipmentRepository, EquipmentRepository>();
        services.AddScoped<ILegalDocumentRepository, LegalDocumentRepository>();
        services.AddScoped<ILessonRepository, LessonRepository>();
        services.AddScoped<IMembershipRepository, MembershipRepository>();
        services.AddScoped<INotificationRepository, NotificationRepository>();
        services.AddScoped<IPaymentRepository, PaymentRepository>();
        services.AddScoped<IPaymentMethodRepository, PaymentMethodRepository>();
        services.AddScoped<IPrerequisiteRepository, PrerequisiteRepository>();
        services.AddScoped<IProgressReportRepository, ProgressReportRepository>();
        services.AddScoped<IScheduleRepository, ScheduleRepository>();
        services.AddScoped<ISkillRepository, SkillRepository>();
        services.AddScoped<ISlotRepository, SlotRepository>();
        services.AddScoped<ISlotEquipmentRepository, SlotEquipmentRepository>();
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

        services.AddScoped<IAccountService, AccountService>();
        services.AddScoped<IAttendanceService, AttendanceService>();
        services.AddScoped<IAvailabilityService, AvailabilityService>();
        services.AddScoped<IBlogService, BlogService>();
        services.AddScoped<ICageService, CageService>();
        services.AddScoped<ICategoryService, CategoryService>();
        services.AddScoped<ICertificateService, CertificateService>();
        services.AddScoped<ICertificationService, CertificationService>();
        services.AddScoped<IChatService, ChatService>();
        services.AddScoped<IClassService, ClassService>();
        services.AddScoped<ICourseService, CourseService>();
        services.AddScoped<ICourseEquipmentService, CourseEquipmentService>();
        services.AddScoped<ICourseLessonService, CourseLessonService>();
        services.AddScoped<ICustomerProfileService, CustomerProfileService>();
        services.AddScoped<IDogService, DogService>();
        services.AddScoped<IDogCertificateService, DogCertificateService>();
        services.AddScoped<IDogDocumentService, DogDocumentService>();
        services.AddScoped<IDogDocumentTypeService, DogDocumentTypeService>();
        services.AddScoped<IEnrollmentService, EnrollmentService>();
        services.AddScoped<IEquipmentService, EquipmentService>();
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
        services.AddScoped<ISlotEquipmentService, SlotEquipmentService>();
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

        return services;
    }
}