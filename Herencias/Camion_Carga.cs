using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencias
{
    public class Camion_Carga : I_Vehiculos
    {
        public int Capacidad_Carga { get; set; }
        public string? Tipo_Mercancía { get; set; }

        public  double CargarMercancia { get; set; }
        public double DescargarMercancia { get; set; }
    }
}
