using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain.Entities;
using Domain.Interface;

namespace DataAcess.Repository
{
    public class UserRepository : LibraryRepository<Users>, IUser
    {
        public UserRepository(ApplicationContext context) : base(context)
        {
        }
        public IEnumerable<Users> GetUsers(int count)
        {
            return _context.Users.OrderByDescending(d => d.Id).ToList();
        }
    }
}
