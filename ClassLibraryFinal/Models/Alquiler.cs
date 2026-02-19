using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryFinal.Models
{
    public class Alquiler
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public int PeliculaId { get; set; }
        public DateTime FechaAlquiler { get; set; }
        



    }
}
