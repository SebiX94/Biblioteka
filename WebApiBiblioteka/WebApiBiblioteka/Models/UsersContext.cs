using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApiBiblioteka.Models
{
    public class UsersContext : DbContext
    {
        public DbSet<Users> Users { get; set; }
         
        public UsersContext(DbContextOptions options) : base (options)
        {

        }

    }
}
