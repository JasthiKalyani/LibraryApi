using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;

namespace Domain.Interface
{
  public interface IBooks : ILibrary<Books>
    {
        IEnumerable<Books> GetBooks(int count);
    }
   
}
