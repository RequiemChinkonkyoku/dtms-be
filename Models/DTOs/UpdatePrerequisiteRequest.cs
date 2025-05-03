using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs
{
    public class UpdatePrerequisiteRequest
    {
        public List<string> PrerequisiteCourseIds { get; set; }
    }
}
