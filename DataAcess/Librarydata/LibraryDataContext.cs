using System;
using System.Collections.Generic;
using System.Text;
using Domain.Interface;
using DataAcess.Repository;

namespace DataAcess.Librarydata
{
   public class LibraryDataContext : ILibrarydata
    {
        private readonly ApplicationContext _context;
        public LibraryDataContext(ApplicationContext context)
        {
            _context = context;
            Users = new UserRepository(_context);
            Books = new BookRepository(_context);
            UserBooks = new UserBooksRepository(_context);
        }
        public IUser Users { get; private set; }
        public IBooks Books { get; private set; }
        public IUserBooks UserBooks { get; private set; }
       

        public int Complete()
        {
            return _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
