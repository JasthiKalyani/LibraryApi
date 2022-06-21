using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain.Entities;
using Domain.Interface;

namespace DataAcess.Repository
{
  public  class UserBooksRepository : LibraryRepository<UserBooks>, IUserBooks
    {
        public UserBooksRepository(ApplicationContext context) : base(context)
        {
        }
        public IEnumerable<UserBooks> GetUserBooks(int Id)
        {
            return _context.UserBooks.OrderByDescending(d => d.Id).ToList();
        }
    }
}
