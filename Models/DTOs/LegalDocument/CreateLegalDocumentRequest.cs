using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs.LegalDocument
{
    public class CreateLegalDocumentRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }

        public string CustomerProfileId { get; set; }
    }
}
