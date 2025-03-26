using AutoMapper;
using Models.DTOs.Blog;
using Models.DTOs.Certification;
using Models.DTOs.Course;
using Models.DTOs.LegalDocument;
using Models.DTOs.Membership;
using Models.DTOs.Response;
using Models.DTOs.TrainerReport;
using Models.DTOs.TrainingReport;
using Models.Entities;

namespace Models.Automapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<DogDocument, DogDocumentResponse>()
                .ReverseMap();
            CreateMap<DogDocumentType, DogDocumentTypeResponse>()
                .ReverseMap();
            CreateMap<TrainerReport, TrainerReportResponse>()
                .ReverseMap();
            CreateMap<TrainerReport, CreateTrainerReportRequest>()
                .ReverseMap();
            CreateMap<TrainingReport, TrainingReportResponse>()
                .ReverseMap();
            CreateMap<TrainingReport, CreateTrainingReportRequest>()
                .ReverseMap();
            CreateMap<Membership, MembershipResponse>()
                .ReverseMap();
            CreateMap<Membership, CreateMembershipRequest>()
                .ReverseMap();
            CreateMap<LegalDocument, LegalDocumentResponse>()
                .ReverseMap();
            CreateMap<LegalDocument, CreateLegalDocumentRequest>()
                .ReverseMap();
            CreateMap<Certifications, CertificationResponse>()
                .ReverseMap();
            CreateMap<Certifications, CreateCertificationRequest>()
                .ReverseMap();
            CreateMap<Blog, BlogResponse>()
                .ReverseMap();
            CreateMap<Blog, CreateBlogRequest>()
                .ReverseMap();
            CreateMap<Dog, DogResponse>()
                .ForMember(dest => dest.DogBreedName, opt => opt.MapFrom(src => src.DogBreed.Name))
                .ForMember(dest => dest.OwnerName, opt => opt.MapFrom(src =>
                    src.DogOwnerships != null && src.DogOwnerships.Any() ?
                    src.DogOwnerships
                        .Where(ownership => ownership.ToDate == null)
                        .Select(ownership => ownership.Customer.FullName)
                        .FirstOrDefault() : "No Owner"))
                .ForMember(dest => dest.CustomerProfileId, opt => opt.MapFrom(src =>
                    src.DogOwnerships != null && src.DogOwnerships.Any() ?
                    src.DogOwnerships
                        .Where(ownership => ownership.ToDate == null)
                        .Select(ownership => ownership.CustomerId)
                        .FirstOrDefault() : null))
                .ReverseMap();
            CreateMap<DogBreed, DogBreedResponse>()
                .ForMember(dest => dest.DogNames, opt => opt.MapFrom(src => src.Dogs.Select(d => d.Name).ToList()))
                .ReverseMap();
            CreateMap<DogOwnership, DogOwnershipResponse>()
                .ForMember(dest => dest.CustomerFullName, opt => opt.MapFrom(src => src.Customer.FullName))
                .ForMember(dest => dest.DogName, opt => opt.MapFrom(src => src.Dog.Name))
                .ReverseMap();
            CreateMap<Course, CourseResponse>()
                .ForMember(dest => dest.CreatedTrainerId, opt => opt.MapFrom(src => src.Trainer.Id))
                .ForMember(dest => dest.CertificateId, opt => opt.MapFrom(src => src.Certificate.Id))
                .ForMember(dest => dest.CategoryId, opt => opt.MapFrom(src => src.Category.Id))
                .ForMember(dest => dest.PrerequisiteIds, opt => opt.MapFrom(src => src.Prerequisites.Select(p => p.PrerequisiteCourse.Id).ToList()))
                .ForMember(dest => dest.LessonIds, opt => opt.MapFrom(src => src.CourseLessons.Select(cl => cl.LessonId).ToList()))
                .ForMember(dest => dest.DogBreedIds, opt => opt.MapFrom(src => src.CourseDogs.Select(cd => cd.DogBreedId).ToList()))
                .ReverseMap();
            CreateMap<ProgressReport, ProgressReportResponse>()
                .ForMember(dest => dest.AttendanceDate,
                    opt => opt.MapFrom(src => src.Attendance.Date.ToDateTime(TimeOnly.MinValue))) 
                .ForMember(dest => dest.Feedback, opt => opt.MapFrom(src => src.Feedback))
                .ForMember(dest => dest.HealthObservation, opt => opt.MapFrom(src => src.HealthObservation))
                .ForMember(dest => dest.BehaviorObservation, opt => opt.MapFrom(src => src.BehaviorObservation))
                .ForMember(dest => dest.PerformanceObservation, opt => opt.MapFrom(src => src.PerformanceObservation))
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status))
                .ForMember(dest => dest.TrainerName,
                    opt => opt.MapFrom(src => src.Trainer.FullName)) 
                .ForMember(dest => dest.DogId,
                    opt => opt.MapFrom(src => src.Attendance.DogId));
            CreateMap<Attendance, AttendanceResponse>()
                .ForMember(dest => dest.DogId, opt => opt.MapFrom(src => src.Dog.Id))
                .ForMember(dest => dest.DogName, opt => opt.MapFrom(src => src.Dog.Name))
                .ForMember(dest => dest.ProgressReports, opt => opt.MapFrom(src => src.ProgressReports));
            CreateMap<Schedule, ScheduleResponse>();
        }
    }
}
