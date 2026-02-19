using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryFinal.Data;
using ClassLibraryFinal.Models;
{
    
}

namespace ClassLibraryFinal.Repositories
{
    public class ClienteRepository
    {
        public static void AgregarCliente(Cliente cliente)
            {
                using (var context = new AplicationDbContext())
                {
                    context.cliente.Add(cliente);
                    context.SaveChanges();
                }
        }
    }
}
