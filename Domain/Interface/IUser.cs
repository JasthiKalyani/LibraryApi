using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;

namespace Domain.Interface
{
  public interface IUser : ILibrary<Users>
    {
        IEnumerable<Users> GetUsers(int Id);
        //IEnumerable<Users> GetUsers();
    }

}
