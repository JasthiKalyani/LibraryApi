using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interface
{
   public interface ILibrarydata : IDisposable
    {
        IUser Users { get; }
        IBooks Books { get; }
        IUserBooks UserBooks { get; }
        int Complete();
    }
}
