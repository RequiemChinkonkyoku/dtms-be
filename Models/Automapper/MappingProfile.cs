using AutoMapper;
using Models.DTOs.Blog;
using Models.DTOs.Certification;
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
            .Select(ownership => ownership.CustomerProfile.FullName)
            .FirstOrDefault() : "No Owner")) 
            .ForMember(dest => dest.CustomerProfileId, opt => opt.MapFrom(src =>
        src.DogOwnerships != null && src.DogOwnerships.Any() ?
        src.DogOwnerships
            .Where(ownership => ownership.ToDate == null)
            .Select(ownership => ownership.CustomerProfileId)
            .FirstOrDefault() : null)) 
            .ReverseMap();
            CreateMap<DogBreed, DogBreedResponse>()
                    .ForMember(dest => dest.DogNames, opt => opt.MapFrom(src => src.Dogs.Select(d => d.Name).ToList()))
                    .ReverseMap();
            CreateMap<DogOwnership, DogOwnershipResponse>()
                    .ForMember(dest => dest.CustomerFullName, opt => opt.MapFrom(src => src.CustomerProfile.FullName))
                    .ForMember(dest => dest.DogName, opt => opt.MapFrom(src => src.Dog.Name))
                    .ReverseMap();
        }
    }
}
