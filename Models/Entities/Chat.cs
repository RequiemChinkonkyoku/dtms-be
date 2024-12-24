using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class Chat : BaseEntity
    {
        public string Message { get; set; }
        public bool IsRead { get; set; }

        public string SenderId { get; set; }
        public Account SenderAccount { get; set; }

        public string ReceiverId { get; set; }
        public Account ReceiverAccount { get; set; }
    }
}
