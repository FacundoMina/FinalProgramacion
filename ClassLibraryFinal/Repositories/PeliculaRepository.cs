using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryFinal.Data;
using ClassLibraryFinal.Models;

namespace ClassLibraryFinal.Repositories
{
    public class PeliculaRepository
    {
        public static void AgregarPelicula(Pelicula pelicula)
        {
            using (var context = new AplicationDbContext())
            {
                context.pelicula.Add(pelicula);
                context.SaveChanges();
            }
        }


    public static void VerDisponibilidad(int peliculaId)
        {
            using (var context = new AplicationDbContext())
            {
                var pelicula = context.pelicula.Find(peliculaId);
                if (pelicula != null)
                {
                    Console.WriteLine($"La película '{pelicula.Titulo}' está {(pelicula.Disponible ? "disponible" : "no disponible")}.");
                }
                else
                {
                    Console.WriteLine("Película no encontrada.");
                }
            }
        }
    }

}
