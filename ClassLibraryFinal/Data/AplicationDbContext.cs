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
        public DbSet<Cliente> cliente { get; set; }
        public DbSet<Pelicula> pelicula { get; set; }
        public DbSet<Alquiler> alquiler { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=LAPTOP-B9HDS386;Database=SuerteDB;Trusted_Connection=True;TrustServerCertificate=True;"

            );
        }
    }
}
