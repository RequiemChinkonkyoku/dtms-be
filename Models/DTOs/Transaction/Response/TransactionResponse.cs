using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs.Transaction.Response
{
    public class TransactionResponse
    {
        public string Id { get; set; }
        public string EnrollmentId { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime PaymentDate { get; set; }

        public string DogId { get; set; }
        public string DogName { get; set; }

        public string CourseId { get; set; }
        public string CourseName { get; set; }

        public string ClassId { get; set; }
        public string ClassName { get; set; }

    }
}
