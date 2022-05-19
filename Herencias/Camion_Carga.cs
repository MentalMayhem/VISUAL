using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencias
{
    public class Camion_Carga : Vehiculos
    {
        public double Capacidad_Carga_Kilos { get; set; }
        public string? Tipo_Mercancía { get; set; }
        public  double CargarMercancia_Kilos { get; set; }
        public double DescargarMercancia_Kilos { get; set; }
    }
}
