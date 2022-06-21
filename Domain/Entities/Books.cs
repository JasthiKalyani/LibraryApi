using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Books
    {
         public int Id { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }
        public string genre { get; set; }
        public string Description { get; set; }

    }
}
