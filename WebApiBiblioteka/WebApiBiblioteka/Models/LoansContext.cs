using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApiBiblioteka.Models
{
    public class LoansContext : DbContext
    {
        public DbSet<Loans> Loans { get; set; }
         
        public LoansContext(DbContextOptions options) : base (options)
        {

        }

    }
}
