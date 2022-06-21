using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain.Entities;
using Domain.Interface;

namespace DataAcess.Repository
{
    public class BookRepository : LibraryRepository<Books>, IBooks
    {
        public BookRepository(ApplicationContext context) : base(context)
        {
        }
        public IEnumerable<Books> GetBooks(int count)
        {
            return _context.Books.OrderByDescending(d => d.Id).ToList();
        }
    }
    
}
