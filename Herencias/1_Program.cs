using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencias
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Vehiculos vehiculo;
            vehiculo = new Vehiculos();

            vehiculo.IdVehiculo = 0;
            vehiculo.uso = "Privado o Público";
            vehiculo.TipoGasolina = "Corriente o Extra";
            vehiculo.TipoFrenos = "Frenos de Disco hidráulico o Mecánicos";
            vehiculo.Mat_Asientos = "Terciopelo o Cuero";
            vehiculo.Altura = "de 2 a 8 metros";
            vehiculo.Largo_en_Metros = 0;
            vehiculo.Ancho_en_Metros = 0;
            vehiculo.Cilindraje_en_KM = 0;
            vehiculo.Cant_Llantas = "De dos a seis llantas";

            Autobus autobus;
            autobus = new Autobus();

            autobus.IdVehiculo = 19023472;
            autobus.uso = "Público";
            autobus.TipoGasolina = "Corriente";
            autobus.TipoFrenos = "Frenos Mecánicos";
            autobus.Mat_Asientos = "Terciopelo";
            autobus.Largo_en_Metros = 15;
            autobus.Ancho_en_Metros = 7;
            autobus.Cant_Llantas = "De cuatro a seis llantas";
            autobus.Cilindraje_en_KM = 160;

            autobus.Ruta = "30 KM por día";
            autobus.SubirPasajeros = 30;
            autobus.BajarPasajeros = 30;

            Automovil automovil;
            automovil = new Automovil();

            automovil.IdVehiculo = 4204201;
            automovil.uso = "Privado";
            automovil.TipoGasolina = "Corriente ";
            automovil.TipoFrenos = "Frenos de Disco hidráulico";
            automovil.Mat_Asientos = "Terciopelo";
            automovil.Altura = "de 1 a 2 metros";
            automovil.Largo_en_Metros = 3.4;
            automovil.Ancho_en_Metros = 2.8;
            automovil.Cilindraje_en_KM = 280.5;
            automovil.Cant_Llantas = "Cuatro llantas";

            automovil.Marca = "Lamorghini";
            automovil.Modelo = "Aventador LP-2009";
            automovil.Tipo = "Super Deportivo";
            automovil.Carrocería = "Fibra de Carbono";

            Bicicleta bicicleta;
            bicicleta = new Bicicleta();

            bicicleta.IdVehiculo = 450641;
            bicicleta.uso = "Privado";
            bicicleta.TipoFrenos = "No tiene";
            bicicleta.Mat_Asientos = "Cuero";
            bicicleta.Altura = "1.5 metros";
            bicicleta.Largo_en_Metros = 0.85;
            bicicleta.Ancho_en_Metros = 0.34;
            bicicleta.Cant_Llantas = "Dos llantas";

            bicicleta.Cant_Radios = 36;
            bicicleta.TipoAsiento = "Asiento Pivotal";
            bicicleta.Grosor_Aros = "40mm";

            Camion_Carga camion_Carga;
            camion_Carga = new Camion_Carga();

            camion_Carga.IdVehiculo = 102938;
            camion_Carga.uso = "Público";
            camion_Carga.TipoFrenos = "Frenos Mecánicos";
            camion_Carga.Mat_Asientos = "Terciopelo";
            camion_Carga.Altura = "3.5 metros";
            camion_Carga.Largo_en_Metros = 4.85;
            camion_Carga.Ancho_en_Metros = 5.34;
            camion_Carga.Cilindraje_en_KM = 80;
            camion_Carga.Cant_Llantas = "Seis llantas";

            camion_Carga.Capacidad_Carga_Kilos = 6000;
            camion_Carga.Tipo_Mercancía = "Contrbando";
            camion_Carga.CargarMercancia_Kilos = 6000;
            camion_Carga.DescargarMercancia_Kilos = 6000;

            Moto moto;
            moto = new Moto();

            moto.IdVehiculo = 102938;
            moto.uso = "Privado";
            moto.TipoFrenos = "Frenos de Disco Hidráulico";
            moto.Mat_Asientos = "Cuero";
            moto.Altura = "1.57 metros";
            moto.Largo_en_Metros = 1.95;
            moto.Ancho_en_Metros = 1.0;
            moto.Cilindraje_en_KM = 1900;
            moto.Cant_Llantas = "Dos llantas"; 

            moto.Tiempos = 4;
            moto.Limitador = true;

        }
    }
}
