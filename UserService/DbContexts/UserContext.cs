using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.Models;

namespace UserService.DbContexts
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    UserId = 1,
                    Name = "John",
                    Age = 23,
                    Email = "john23@gmail.com"
                },
                new User
                {
                    UserId = 2,
                    Name = "Vijay",
                    Age = 33,
                    Email = "vijay33@gmail.com"
                },
                new User
                {
                    UserId = 3,
                    Name = "Amit",
                    Age = 30,
                    Email = "amit30@gmail.com"
                }
            );
        }
    }
}
