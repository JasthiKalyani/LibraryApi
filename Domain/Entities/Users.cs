using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Users
    {
         public int Id { get; set; }
        public string UserName { get; set; }
        public string Pwd { get; set; }
        public Nullable<int> Is_admin { get; set; }
       
    }
}
