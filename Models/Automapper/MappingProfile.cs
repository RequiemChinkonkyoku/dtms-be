using AutoMapper;
using Models.DTOs.Blog;
using Models.DTOs.Certification;
using Models.DTOs.Class;
using Models.DTOs.Class.Response;
using Models.DTOs.Course;
using Models.DTOs.Course.Response;
using Models.DTOs.LegalDocument;
using Models.DTOs.Membership.Request;
using Models.DTOs.Membership.Response;
using Models.DTOs.Pretest.Response;
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
            CreateMap<Course, GetCourseResponse>()
                .ForMember(dest => dest.CreatedTrainerName, opt => opt.MapFrom(src => src.Trainer.FullName))
                .ForMember(dest => dest.CreatedTrainerId, opt => opt.MapFrom(src => src.Trainer.Id))
                .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.Name))
                .ForMember(dest => dest.CategoryId, opt => opt.MapFrom(src => src.Category.Id))
                .ForMember(dest => dest.CertificateId, opt => opt.MapFrom(src => src.Certificate.Id))
                .ForMember(dest => dest.CoursePrerequisites, opt => opt.MapFrom(src => src.Prerequisites
                    .Select(p => new CoursePrerequisiteDTO
                    {
                        Id = p.PrerequisiteCourseId,
                        Name = p.PrerequisiteCourse.Name
                    })))
                .ForMember(dest => dest.CourseLessons, opt => opt.MapFrom(src => src.CourseLessons
                    .Select(cl => new CourseLessonDTO
                    {
                        Id = cl.LessonId,
                        Name = cl.Lesson.LessonTitle
                    })))
                .ForMember(dest => dest.CourseDogBreeds, opt => opt.MapFrom(src => src.CourseDogs
                    .Select(cd => new CourseDogBreedDTO
                    {
                        Id = cd.DogBreedId,
                        Name = cd.DogBreed.Name
                    })))
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
            CreateMap<Class, GetClassResponse>()
                .ForMember(dest => dest.CourseId, opt => opt.MapFrom(src => src.Course.Id))
                .ForMember(dest => dest.CourseName, opt => opt.MapFrom(src => src.Course.Name))
                .ForMember(dest => dest.AssignedTrainers, opt => opt.MapFrom(src => src.TrainerAssignments
                    .Select(ta => new AssignedTrainerDTO
                    {
                        Id = ta.TrainerId,
                        Name = ta.Trainer.FullName
                    })))
                .ForMember(dest => dest.ClassSlots, opt => opt.MapFrom(src => src.Slots
                    .Select(s => new ClassSlotDTO
                    {
                        SlotDate = s.Date,
                        ScheduleId = s.ScheduleId,
                        StartTime = s.Schedule.StartTime,
                        EndTime = s.Schedule.EndTime
                    })
                    .OrderBy(cs => cs.SlotDate)))
                .ReverseMap();
            CreateMap<Account, TrainerBasicInfoResponse>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.FullName))
                .ReverseMap();
            CreateMap<PreTest, GetPretestResponse>()
                .ForMember(dest => dest.DogId, opt => opt.MapFrom(src => src.Dog.Id))
                .ForMember(dest => dest.DogName, opt => opt.MapFrom(src => src.Dog.Name))
                .ForMember(dest => dest.ClassId, opt => opt.MapFrom(src => src.Class.Id))
                .ForMember(dest => dest.ClassName, opt => opt.MapFrom(src => src.Class.Name))
                .ReverseMap();
        }
    }
}
