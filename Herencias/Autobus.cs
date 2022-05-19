using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencias
{
    public class Autobus : Vehiculos
    {
        public string? Ruta { get; set; }

        public int SubirPasajeros { get; set; }

        public int BajarPasajeros {get; set; }
        
    }

}
