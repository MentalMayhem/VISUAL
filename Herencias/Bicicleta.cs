using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencias
{
    public class Bicicleta : Vehiculos
    {
        public int Cant_Radios { get; set; }

        public string? Tamaño_Llantas { get; set; }

        public string? TipoAsiento { get; set; }

        public string? Grosor_Aros { get; set; }
        
    }
}
