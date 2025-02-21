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
                .ReverseMap();
            CreateMap<DogBreed, DogBreedResponse>()
                .ForMember(dest => dest.DogNames, opt => opt.MapFrom(src => src.Dogs.Select(d => d.Name).ToList()))
                .ReverseMap();
                
        }
    }
}
