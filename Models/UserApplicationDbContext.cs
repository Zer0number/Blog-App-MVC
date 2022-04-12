using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.Models
{
    public class UserApplicationDbContext : IdentityDbContext<User>
    {
        public DbSet<User> IdentityUsers { get; set; }
        public UserApplicationDbContext(DbContextOptions<UserApplicationDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
