using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class UserBooks
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public System.DateTime BookedTime { get; set; }
        public System.DateTime ReturnedDate { get; set; }
        public System.DateTime RenewedDate { get; set; }
        public Nullable<int> Renwed_flag { get; set; }
        public Nullable<int> Rating { get; set; }
        public Nullable<int> Likes { get; set; }
       
    }
}
