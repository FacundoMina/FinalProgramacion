
using ClassLibraryFinal.Models;
using ClassLibraryFinal.Repositories;
using System;


do
{
    Console.WriteLine("=================================================");
    Console.WriteLine("\tBienvenido al Videoclub");
    Console.WriteLine("=================================================");
    Console.WriteLine();
    Console.WriteLine("1. Agregar película");
    Console.WriteLine("2. Registrar Cliente");
    Console.WriteLine("3. Alquilar película");
    Console.WriteLine("4. Ver Alquileres de la fecha");
    Console.WriteLine("5. Generar Reporte de Alquiler por Genero");
    Console.WriteLine("6. Salir");
    Console.WriteLine();
    Console.Write("Seleccione una opcion: ");
    string opcion = Console.ReadLine();
    Console.Clear();

    if (opcion == "1")
    {
        Console.Write("Ingrese el título de la película: ");
        string titulo = Console.ReadLine();
        Console.Write("Ingrese el género de la película: ");
        string genero = Console.ReadLine();
        Console.WriteLine("Ingrese Duracion de la pelicula en minutos: ");
        int duracion = int.Parse(Console.ReadLine());
        Console.Write("¿La película está disponible? (s/n): ");
        bool disponible = Console.ReadLine().ToLower() == "s";
        var pelicula = new Pelicula
        {
            Titulo = titulo,
            Genero = genero,
            Duracion = duracion,
            Disponible = disponible
        };
        PeliculaRepository.AgregarPelicula(pelicula);
        Console.WriteLine("Película agregada exitosamente.");
    }
    if (opcion == "2")
    {
        Console.Write("Ingrese el nombre del cliente: ");
        string nombre = Console.ReadLine();
        Console.Write("Ingrese el documento del cliente: ");
        string documento = Console.ReadLine();
        Console.Write("Ingrese el correo electrónico del cliente: ");
        string correo = Console.ReadLine();
        var cliente = new Cliente
        {
            Nombre = nombre,
            Documento = documento,
            Correo = correo
        };
        ClienteRepository.AgregarCliente(cliente);
        Console.WriteLine("Cliente registrado exitosamente.");
    }
    if (opcion == "3")
    {
        Console.Write("Ingrese el ID del cliente: ");
        int clienteId = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el ID de la película: ");
        int peliculaId = int.Parse(Console.ReadLine());
        var alquiler = new Alquiler
        {
            ClienteId = clienteId,
            PeliculaId = peliculaId,
            FechaAlquiler = DateTime.Now
        };
        AlquilerRepository.AgregarAlquiler(alquiler);
        Console.WriteLine("Película alquilada exitosamente.");
    }
    if (opcion == "4")
    {
        Console.Write("Ingrese la fecha para ver los alquileres (yyyy-MM-dd): ");
        DateTime fecha = DateTime.Parse(Console.ReadLine());
        AlquilerRepository.VerAlquieresFecha(fecha);
    }
    if (opcion == "5")
    {
        Console.Write("Ingrese el género para generar el reporte: ");
        string genero = Console.ReadLine();
        AlquilerRepository.GenerarReporteGenero(DateTime.Now);
    }
    if (opcion == "6")
    {
        Console.WriteLine("Gracias por usar el Videoclub. ¡Hasta luego!");
        break;
    }

} while (true);


