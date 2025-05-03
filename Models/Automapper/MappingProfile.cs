using AutoMapper;
using Microsoft.IdentityModel.Tokens;
using Models.DTOs.Blog;
using Models.DTOs.Certificate.Response;
using Models.DTOs.Certification;
using Models.DTOs.Class;
using Models.DTOs.Class.Response;
using Models.DTOs.Course;
using Models.DTOs.Course.Response;
using Models.DTOs.DogCertificate.Response;
using Models.DTOs.Enrollment.Response;
using Models.DTOs.LegalDocument;
using Models.DTOs.Lesson.Response;
using Models.DTOs.LessonEquipment;
using Models.DTOs.Membership.Request;
using Models.DTOs.Membership.Response;
using Models.DTOs.Pretest.Response;
using Models.DTOs.Response;
using Models.DTOs.Slot.Response;
using Models.DTOs.TrainerReport;
using Models.DTOs.TrainingReport;
using Models.DTOs.Transaction.Response;
using Models.DTOs.Wishlist.Response;
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
                .ForMember(dest => dest.DogCode, opt => opt.MapFrom(src => src.DogCode))
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
                        Status = s.Status,
                        SlotId = s.Id,
                        SlotDate = s.Date,
                        ScheduleId = s.ScheduleId,
                        StartTime = s.Schedule.StartTime,
                        EndTime = s.Schedule.EndTime,
                        LessonId = s.LessonId != null ? s.Lesson.LessonTitle : "N/A",
                        LessonName = s.Lesson != null ? s.Lesson.LessonTitle : "N/A",
                    })
                    .OrderBy(cs => cs.SlotDate)))
                .ForMember(dest => dest.ClassEnrollments, opt => opt.MapFrom(src => src.Enrollments
                    .Select(e => new ClassEnrollmentDTO
                    {
                        Status = e.Status,
                        RequiredNightStay = e.RequiredNightStay,
                        EnrollmentId = e.Id,
                        DogId = e.DogId,
                        DogName = e.Dog.Name,
                        CageId = e.CageId,
                        Location = e.Cage.Location
                    })))
                .ReverseMap();
            CreateMap<Account, TrainerBasicInfoResponse>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.FullName))
                .ReverseMap();
            CreateMap<PreTest, GetPretestResponse>()
                .ForMember(dest => dest.TestDate, opt => opt.MapFrom(src => src.TestDate))
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status))
                .ForMember(dest => dest.Note, opt => opt.MapFrom(src => src.Note))
                .ForMember(dest => dest.DogId, opt => opt.MapFrom(src => src.Dog.Id))
                .ForMember(dest => dest.DogName, opt => opt.MapFrom(src => src.Dog.Name))
                .ForMember(dest => dest.ClassId, opt => opt.MapFrom(src => src.Class.Id))
                .ForMember(dest => dest.ClassName, opt => opt.MapFrom(src => src.Class.Name))
                .ReverseMap();
            CreateMap<Slot, GetSlotByClassResponse>()
                .ForMember(dest => dest.Schedule, opt => opt.MapFrom(src => new ClassScheduleResponse
                {
                    StartTime = src.Schedule.StartTime,
                    EndTime = src.Schedule.EndTime
                }))
                .ForMember(dest => dest.Lesson, opt => opt.MapFrom(src => src.Lesson != null
                    ? new ClassLessonResponse
                    {
                        Id = src.Lesson.Id,
                        Name = src.Lesson.LessonTitle
                    }
                    : null))
                .ForMember(dest => dest.Attendance, opt => opt.MapFrom((src, dest, _, context) =>
                {
                    var dogId = context.Items["DogId"] as string;
                    var attendance = src.Attendances?.FirstOrDefault(a => a.DogId == dogId);

                    return attendance != null
                        ? new ClassAttendanceResponse
                        {
                            Id = attendance.Id,
                            Date = attendance.Date.ToDateTime(TimeOnly.MinValue),
                            DogId = dogId
                        }
                        : null;
                }));
            CreateMap<ProgressReport, GetProgressReportByClassResponse>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Date, opt => opt.MapFrom(src => src.Attendance.Slot.Date))
                .ForMember(dest => dest.Schedule, opt => opt.MapFrom(src => new ClassScheduleResponse
                {
                    StartTime = src.Attendance.Slot.Schedule.StartTime,
                    EndTime = src.Attendance.Slot.Schedule.EndTime
                }))
                .ForMember(dest => dest.Lesson, opt => opt.MapFrom(src => src.Attendance.Slot.Lesson != null
                    ? new ClassLessonResponse
                    {
                        Id = src.Attendance.Slot.Lesson.Id,
                        Name = src.Attendance.Slot.Lesson.LessonTitle
                    }
                    : null))
                .ForMember(dest => dest.Attendance, opt => opt.MapFrom(src => new ClassAttendanceResponse
                {
                    Id = src.Attendance.Id,
                    Date = src.Attendance.Date.ToDateTime(TimeOnly.MinValue),
                    DogId = src.Attendance.DogId
                }));
            CreateMap<Slot, GetTrainerSlotResponse>()
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status))
                .ForMember(dest => dest.SlotId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.SlotDate, opt => opt.MapFrom(src => src.Date))
                .ForMember(dest => dest.ClassId, opt => opt.MapFrom(src => src.ClassId))
                .ForMember(dest => dest.ClassName, opt => opt.MapFrom(src => src.Class.Name))
                .ForMember(dest => dest.ScheduleId, opt => opt.MapFrom(src => src.ScheduleId))
                .ForMember(dest => dest.StartTime, opt => opt.MapFrom(src => src.Schedule.StartTime))
                .ForMember(dest => dest.EndTime, opt => opt.MapFrom(src => src.Schedule.EndTime))
                .ForMember(dest => dest.LessonId, opt => opt.MapFrom(src => src.LessonId))
                .ForMember(dest => dest.LessonName, opt => opt.MapFrom(src => src.Lesson.LessonTitle))
                .ReverseMap();
            CreateMap<Lesson, GetLessonResponse>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.LessonTitle, opt => opt.MapFrom(src => src.LessonTitle))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.Notes, opt => opt.MapFrom(src => src.Notes))
                .ForMember(dest => dest.Environment, opt => opt.MapFrom(src => src.Environment))
                .ForMember(dest => dest.Duration, opt => opt.MapFrom(src => src.Duration))
                .ForMember(dest => dest.Objective, opt => opt.MapFrom(src => src.Objective))
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status))
                .ForMember(dest => dest.SkillId, opt => opt.MapFrom(src => src.SkillId))
                .ForMember(dest => dest.SkillName, opt => opt.MapFrom(src => src.Skill.Name))
                .ForMember(dest => dest.LessonEquipments, opt => opt.MapFrom(src => src.LessonEquipments
                    .Select(le => new GetLessonEquipmentDTO
                    {
                        Id = le.Id,
                        LessonId = le.LessonId,
                        LessonTitle = le.Lesson.LessonTitle,
                        EquipmentId = le.EquipmentId,
                        EquipmentName = le.Equipment.Name,
                        Quantity = le.Quantity,
                    })))
                .ForMember(dest => dest.CourseList, opt => opt.MapFrom(src => src.CourseLessons
                    .Select(cl => new CourseLessonDTO
                    {
                        Id = cl.CourseId,
                        Name = cl.Course.Name
                    })))
                .ForMember(dest => dest.LessonPrerequisites, opt => opt.MapFrom(src => src.LessonPrerequisites
                    .Select(lp => new CoursePrerequisiteDTO
                    {
                        Id = lp.PrerequisiteLessonId,
                        Name = lp.PrerequisiteLesson.LessonTitle
                    })))
                .ReverseMap();
            CreateMap<DogCertificate, DogCertificateResponse>()
                    .ForMember(dest => dest.DogName, opt => opt.MapFrom(src => src.Dog.Name))
                    .ForMember(dest => dest.CertificateName, opt => opt.MapFrom(src => src.Certificate.Name));
            CreateMap<Certificate, CertificateResponse>()
                    .ForMember(dest => dest.CourseId, opt => opt.MapFrom(src => src.Course.Id))
                    .ForMember(dest => dest.CourseName, opt => opt.MapFrom(src => src.Course.Name))
                    .ForMember(dest => dest.CourseDescription, opt => opt.MapFrom(src => src.Course.Description));
            CreateMap<Transaction, TransactionResponse>()
                .ForMember(dest => dest.DogName, opt => opt.MapFrom(src => src.Enrollment.Dog.Name))
                .ForMember(dest => dest.DogId, opt => opt.MapFrom(src => src.Enrollment.Dog.Id))
                .ForMember(dest => dest.CourseName, opt => opt.MapFrom(src => src.Enrollment.Class.Course.Name))
                .ForMember(dest => dest.CourseId, opt => opt.MapFrom(src => src.Enrollment.Class.Course.Id))
                .ForMember(dest => dest.ClassName, opt => opt.MapFrom(src => src.Enrollment.Class.Name))
                .ForMember(dest => dest.ClassId, opt => opt.MapFrom(src => src.Enrollment.Class.Id));
            CreateMap<Class, EnrollClassResponse>()
                .ForMember(dest => dest.ClassId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.ClassName, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.StartingDate, opt => opt.MapFrom(src => src.StartingDate))
                .ForMember(dest => dest.CourseId, opt => opt.MapFrom(src => src.CourseId))
                .ForMember(dest => dest.CourseName, opt => opt.MapFrom(src => src.Course.Name))
                .ForMember(dest => dest.TrainerAssignments, opt => opt.MapFrom(src => src.TrainerAssignments
                    .Select(ta => new AssignedTrainerDTO
                    {
                        Id = ta.TrainerId,
                        Name = ta.Trainer.FullName
                    })))
                .ForMember(dest => dest.TestDate, opt => opt.MapFrom(src => src.PreTests.FirstOrDefault().TestDate));
            CreateMap<WishList, GetWishlistResponse>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.CustomerAccountId, opt => opt.MapFrom(src => src.CustomerId))
                .ForMember(dest => dest.CustomerName, opt => opt.MapFrom(src => src.Customer.FullName))
                .ForMember(dest => dest.RoleName, opt => opt.MapFrom(src => src.Customer.Role.Name))
                .ForMember(dest => dest.CourseId, opt => opt.MapFrom(src => src.CourseId))
                .ForMember(dest => dest.CourseName, opt => opt.MapFrom(src => src.Course.Name));
            CreateMap<Enrollment, GetEnrollmentResponse>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status))
                .ForMember(dest => dest.RequiredNightStay, opt => opt.MapFrom(src => src.RequiredNightStay))
                .ForMember(dest => dest.ClassId, opt => opt.MapFrom(src => src.ClassId))
                .ForMember(dest => dest.ClassName, opt => opt.MapFrom(src => src.Class.Name))
                .ForMember(dest => dest.DogId, opt => opt.MapFrom(src => src.DogId))
                .ForMember(dest => dest.DogName, opt => opt.MapFrom(src => src.Dog.Name))
                .ForMember(dest => dest.CageId, opt => opt.MapFrom(src => src.CageId))
                .ForMember(dest => dest.CageNumber, opt => opt.MapFrom(src => src.Cage.Number))
                .ForMember(dest => dest.StaffId, opt => opt.MapFrom(src => src.StaffId ?? "None"))
                .ForMember(dest => dest.StaffName, opt => opt.MapFrom(src =>
                    (!src.StaffId.IsNullOrEmpty()) ? src.Staff.FullName : "None"));
        }
    }
}
