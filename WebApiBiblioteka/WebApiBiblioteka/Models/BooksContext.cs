using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApiBiblioteka.Models
{
    public class BooksContext : DbContext
    {
        public DbSet<Books> Books { get; set; }

        public BooksContext(DbContextOptions options) : base(options)
        {

        }

    }
}
