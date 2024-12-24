using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class Notification : BaseEntity
    {
        public string Title { get; set; }
        public string Message { get; set; }
        public bool IsRead { get; set; }

        public string ReceiverId { get; set; }
        public Account ReceiverAccount { get; set; }
    }
}
