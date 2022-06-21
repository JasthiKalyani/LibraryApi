using System;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;


namespace DataAcess 
{
    public class ApplicationContext : DbContext
{
    public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
    {
    }
        public  DbSet<Users> Users { get; set; }

        public  DbSet<Books> Books { get; set; }

        public  DbSet<UserBooks> UserBooks { get; set; }
    }

}
