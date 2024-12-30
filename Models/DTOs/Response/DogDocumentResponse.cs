namespace Models.DTOs.Response
{
    public class DogDocumentResponse
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }
        public string IssuingAuthority { get; set; }
        public DateOnly IssueDate { get; set; }
        public DateTime UploadTime { get; set; }

        public string DogId { get; set; }

        public DogDocumentTypeResponse DogDocumentType { get; set; }
    }
}
