using ClassLibraryFinal.Data;
using ClassLibraryFinal.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryFinal.Repositories
{
    public class AlquilerRepository
    {
        public static void AgregarAlquiler(Alquiler alquiler)
        {
            using (var context = new AplicationDbContext())
            {
                context.alquiler.Add(alquiler);
                context.SaveChanges();
            }
        }

        public static void VerAlquieresFecha(DateTime fecha)
        {
            using (var context = new AplicationDbContext())
            {
                var alquileres = context.alquiler
                    .Include(a => a.Cliente)
                    .Include(a => a.Pelicula)
                    .Where(a => a.FechaAlquiler.Date == fecha.Date)
                    .ToList();

                if (alquileres.Count > 0)
                {
                    Console.WriteLine($"Alquileres para la fecha {fecha.ToShortDateString()}:");
                    foreach (var alquiler in alquileres)
                    {
                        Console.WriteLine($"- Alquiler ID: {alquiler.Id}, Cliente: {alquiler.Cliente.Nombre}, Película: {alquiler.Pelicula.Titulo}, Fecha: {alquiler.FechaAlquiler}");
                    }
                }
                else
                {
                    Console.WriteLine($"No hay alquileres para la fecha {fecha.ToShortDateString()}.");
                }
            }
        }
        public static void GenerarReporteGenero(DateTime fecha)
        {
            using (var context = new AplicationDbContext())
            {
                var reporte = context.alquiler
                    .Include(a => a.Pelicula) // Traer la relación
                    .Where(a => a.FechaAlquiler.Date == fecha.Date)
                    .GroupBy(a => a.Pelicula.Genero)
                    .Select(g => new
                    {
                        Genero = g.Key,
                        CantidadAlquileres = g.Count()
                    })
                    .ToList();

                if (reporte.Count > 0)
                {
                    Console.WriteLine($"Reporte de alquileres por género para la fecha {fecha.ToShortDateString()}:");
                    foreach (var item in reporte)
                    {
                        Console.WriteLine($"- Género: {item.Genero}, Cantidad de Alquileres: {item.CantidadAlquileres}");
                    }
                }
                else
                {
                    Console.WriteLine($"No hay alquileres para la fecha {fecha.ToShortDateString()}.");
                }
            }
        }
    }
}
