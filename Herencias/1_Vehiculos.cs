using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencias
{
    public class I_Vehiculos
    {
        public int IdVehiculo { get; set; }
        public string? uso { get; set; }
        public string? TipoMotor { get; set; }
        public string? TipoFrenos { get; set; }
        public string? Mat_Asientos { get; set; }
        public string? Altura { get; set; }
        public int Ancho_en_Metros { get; set; }
        public int Largo_en_Metros { get; set; }
        public double Cilindraje_en_KM { get; set; }
        public string? Cant_Llantas { get; set; }
        public string? Encender { get; set; }
        public string? Apagar { get; set; }
        public double Acelerar { get; set; }
        public double Desacelerar { get; set; }
        public string? Transportar { get; set; }
        public string? Girar { get; set; }

    }
}
