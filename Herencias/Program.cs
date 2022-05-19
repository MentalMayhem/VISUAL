using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencias
{
    public class Program
    {
        static void Main(String[] args)
        {
            I_Vehiculos vehiculo;
            vehiculo = new I_Vehiculos();

            vehiculo.IdVehiculo = 1234;
            vehiculo.uso = "Privado o Público";
            vehiculo.TipoMotor = "Gasolina corriente";
            vehiculo.TipoFrenos = "Frenos de Disco hidráulico";
            vehiculo.Mat_Asientos = "Terciopelo";
            vehiculo.Altura = "de 2 a 20 metros";
            vehiculo.Largo_en_Metros = 7;
            vehiculo.Ancho_en_Metros = 5;
            vehiculo.Cilindraje_en_KM = 250;
            vehiculo.Cant_Llantas = "De dos a seis llantas";






        }
    }
}
