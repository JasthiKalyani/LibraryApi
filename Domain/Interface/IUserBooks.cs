using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;

namespace Domain.Interface
{
   public interface IUserBooks : ILibrary<UserBooks>
    {
        IEnumerable<UserBooks> GetUserBooks(int Id);
    }
 }
