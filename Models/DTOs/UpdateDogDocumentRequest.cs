using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs
{
    public class UpdateDogDocumentRequest
    {
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(100, ErrorMessage = "Name cannot exceed 100 characters.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Image URL is required.")]
        public string ImageUrl { get; set; }
        [StringLength(500, ErrorMessage = "Description cannot exceed 500 characters.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Status is required.")]
        [Range(0, 1, ErrorMessage = "Status must be either 0 or 1.")]
        public int Status { get; set; }
        [Required(ErrorMessage = "Issuing Authority is required.")]
        public string IssuingAuthority { get; set; }
        [Required(ErrorMessage = "Issue Date is required.")]
        public DateOnly IssueDate { get; set; }
        [Required(ErrorMessage = "Dog ID is required.")]
        public string DogId { get; set; }
        [Required(ErrorMessage = "Dog Document Type ID is required.")]
        public string DogDocumentTypeId { get; set; }
    }
}
