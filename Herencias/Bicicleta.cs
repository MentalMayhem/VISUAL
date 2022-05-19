using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencias
{
    public class Bicicleta : I_Vehiculos
    {
        public int Cant_Radios { get; set; }

        public string? Tamaño_Llantas { get; set; }

        public string? TipoAsiento { get; set; }

        public string? grosor_Aros { get => grosor_Aros; set => grosor_Aros = value; }
        
    }
}
