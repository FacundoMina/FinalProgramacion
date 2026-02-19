using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ClassLibraryFinal.Models;

namespace ClassLibraryFinal.Data
{
    public class AplicationDbContext : DbContext
    {
        public DbSet<Class1> Class1s { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=LAPTOP-B9HDS386;Database=SuerteDB;Trusted_Connection=True;TrustServerCertificate=True;"

            );
        }
    }
}
