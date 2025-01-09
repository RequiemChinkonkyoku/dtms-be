using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs
{
    public class CreateDogDocumentRequest
    {
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(100, ErrorMessage = "Name must not exceed 100 characters.")]
        public string Name { get; set; }

        [Url(ErrorMessage = "ImageUrl must be a valid URL.")]
        public string ImageUrl { get; set; }

        [StringLength(500, ErrorMessage = "Description must not exceed 500 characters.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "IssuingAuthority is required.")]
        [StringLength(100, ErrorMessage = "IssuingAuthority must not exceed 100 characters.")]
        public string IssuingAuthority { get; set; }

        [Required(ErrorMessage = "IssueDate is required.")]
        public DateOnly IssueDate { get; set; }

        [Required(ErrorMessage = "DogId is required.")]
        public string DogId { get; set; }

        [Required(ErrorMessage = "DogDocumentTypeId is required.")]
        public string DogDocumentTypeId { get; set; }
    }

}
