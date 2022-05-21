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

            autobus.Marca = "VOLVO";
            autobus.Ruta = "30 KM por día";
            autobus.SubirPasajeros = 30;
            autobus.BajarPasajeros = 30;

            Console.WriteLine("---------Propiedades del Autobus----------");
            Console.WriteLine("Matricula: "+autobus.IdVehiculo);
            Console.WriteLine("Es de uso: "+autobus.uso);
            Console.WriteLine("Gasolina de tipo: "+autobus.TipoGasolina);
            Console.WriteLine("Frenos de tipo: "+autobus.TipoFrenos);
            Console.WriteLine("Material de asientos: "+autobus.Mat_Asientos);
            Console.WriteLine("Tiene "+autobus.Largo_en_Metros+" Metros de largo");
            Console.WriteLine("Tiene " + autobus.Ancho_en_Metros + " Metros de ancho");
            Console.WriteLine("Posee "+autobus.Cant_Llantas);
            Console.WriteLine("Su cilindraje tiene un máximo de: "+autobus.Cilindraje_en_KM);

            Console.WriteLine("Es de la marca: "+autobus.Marca);
            Console.WriteLine("El autobus recorre: "+autobus.Ruta);
            Console.WriteLine("El autobus puede subir un máximo de: "+autobus.SubirPasajeros+" pasajeros");
            Console.WriteLine("El autobus puede bajar un máximo de: "+ autobus.BajarPasajeros + " pasajeros");
            Console.WriteLine("-----------------------------------------");
            Console.ReadLine();

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

            Console.WriteLine("---------Propiedades del automovil----------");
            Console.WriteLine("Matricula: " + automovil.IdVehiculo);
            Console.WriteLine("Es de uso: " + automovil.uso);
            Console.WriteLine("Gasolina de tipo: " + automovil.TipoGasolina);
            Console.WriteLine("Frenos de tipo: " + automovil.TipoFrenos);
            Console.WriteLine("Material de asientos: " + automovil.Mat_Asientos);
            Console.WriteLine("Tiene " + automovil.Largo_en_Metros + " Metros de largo");
            Console.WriteLine("Tiene " + automovil.Ancho_en_Metros + " Metros de ancho");
            Console.WriteLine("Posee " + automovil.Cant_Llantas);
            Console.WriteLine("Su cilindraje tiene un máximo de: " + autobus.Cilindraje_en_KM);

            Console.WriteLine("Es de la marca: " + automovil.Marca);
            Console.WriteLine("El modelo del auto es: "+automovil.Modelo);
            Console.WriteLine("El auto es un "+automovil.Tipo);
            Console.WriteLine("Su carrocería es de "+automovil.Carrocería);
            Console.WriteLine("-----------------------------------------");
            Console.ReadLine();

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

            bicicleta.Marca = "WeThePeople BMX";
            bicicleta.Cant_Radios = 36;
            bicicleta.TipoAsiento = "Asiento Pivotal";
            bicicleta.Grosor_Aros = "40mm";

            Console.WriteLine("---------Propiedades de la Bicicleta----------");
            Console.WriteLine("Matricula: " + bicicleta.IdVehiculo);
            Console.WriteLine("Es de uso: " + bicicleta.uso);
            Console.WriteLine("Frenos de tipo: " + bicicleta.TipoFrenos);
            Console.WriteLine("Material de asientos: " + bicicleta.Mat_Asientos);
            Console.WriteLine("Su altura es de: "+bicicleta.Altura);
            Console.WriteLine("Tiene " + bicicleta.Largo_en_Metros + " Metros de largo");
            Console.WriteLine("Tiene " + bicicleta.Ancho_en_Metros + " Metros de ancho");
            Console.WriteLine("Posee " + bicicleta.Cant_Llantas);

            Console.WriteLine("Es de la marca: "+bicicleta.Marca);
            Console.WriteLine("Las llantas necesitan "+bicicleta.Cant_Radios+" para funcionar");
            Console.WriteLine("El tipo de asiento de la bibicleta es: "+bicicleta.TipoAsiento);
            Console.WriteLine("Los aros tienen un grosor de: "+bicicleta.Grosor_Aros);
            Console.WriteLine("-----------------------------------------");
            Console.ReadLine();

            Camion_Carga camion_Carga;
            camion_Carga = new Camion_Carga();

            camion_Carga.IdVehiculo = 102938;
            camion_Carga.uso = "Público";
            camion_Carga.TipoGasolina = "Corriente";
            camion_Carga.TipoFrenos = "Frenos Mecánicos";
            camion_Carga.Mat_Asientos = "Terciopelo";
            camion_Carga.Altura = "3.5 metros";
            camion_Carga.Largo_en_Metros = 4.85;
            camion_Carga.Ancho_en_Metros = 5.34;
            camion_Carga.Cilindraje_en_KM = 80;
            camion_Carga.Cant_Llantas = "Seis llantas";

            camion_Carga.Marca = "Kenworth";
            camion_Carga.Capacidad_Carga_Kilos = 6000;
            camion_Carga.Tipo_Mercancía = "Contrbando";
            camion_Carga.CargarMercancia_Kilos = 3000;
            camion_Carga.DescargarMercancia_Kilos = 3000;

            Console.WriteLine("---------Propiedades del Camion de Carga----------");
            Console.WriteLine("Matricula: " + camion_Carga.IdVehiculo);
            Console.WriteLine("Es de uso: " + camion_Carga.uso);
            Console.WriteLine("Gasolina de tipo: " + camion_Carga.TipoGasolina);
            Console.WriteLine("Frenos de tipo: " + camion_Carga.TipoFrenos);
            Console.WriteLine("Material de asientos: " + camion_Carga.Mat_Asientos);
            Console.WriteLine("Su altura es de: "+camion_Carga.Altura);
            Console.WriteLine("Tiene " + camion_Carga.Largo_en_Metros + " Metros de largo");
            Console.WriteLine("Tiene " + camion_Carga.Ancho_en_Metros + " Metros de ancho");
            Console.WriteLine("Posee " + camion_Carga.Cant_Llantas);

            Console.WriteLine("Es de la marca: "+camion_Carga.Marca);
            Console.WriteLine("Tiene un capacidad máxima de "+camion_Carga.Capacidad_Carga_Kilos+" Kilos de peso");
            Console.WriteLine("Transporta mercancia de tipo: "+camion_Carga.Tipo_Mercancía);
            Console.WriteLine("El camión va a cargar: "+camion_Carga.CargarMercancia_Kilos+" Kilos en mercancía");
            Console.WriteLine("El camión va a descargar: " + camion_Carga.DescargarMercancia_Kilos + " Kilos en mercancía");
            Console.WriteLine("-----------------------------------------");
            Console.ReadLine();

            Moto moto;
            moto = new Moto();

            moto.IdVehiculo = 102938;
            moto.uso = "Privado";
            moto.TipoGasolina = "Extra";
            moto.TipoFrenos = "Frenos de Disco Hidráulico";
            moto.Mat_Asientos = "Cuero";
            moto.Altura = "1.57 metros";
            moto.Largo_en_Metros = 1.95;
            moto.Ancho_en_Metros = 1.0;
            moto.Cilindraje_en_KM = 1900;
            moto.Cant_Llantas = "Dos llantas";

            moto.Marca = "Ducati";
            moto.Tiempos = 4;
            moto.Limitador = true;

            Console.WriteLine("---------Propiedades de la Moto----------");
            Console.WriteLine("Matricula: " + moto.IdVehiculo);
            Console.WriteLine("Es de uso: " + moto.uso);
            Console.WriteLine("Gasolina de tipo: " + moto.TipoGasolina);
            Console.WriteLine("Frenos de tipo: " + moto.TipoFrenos);
            Console.WriteLine("Material de asientos: " + moto.Mat_Asientos);
            Console.WriteLine("Su altura es de: "+moto.Altura);
            Console.WriteLine("Tiene " + moto.Largo_en_Metros + " Metros de largo");
            Console.WriteLine("Tiene " + moto.Ancho_en_Metros + " Metros de ancho");
            Console.WriteLine("Posee " + moto.Cant_Llantas);
            Console.WriteLine("Su cilindraje tiene un máximo de: " + moto.Cilindraje_en_KM);

            Console.WriteLine("Es de la marca: " + moto.Marca);
            Console.WriteLine("La moto es de"+moto.Tiempos+" tiempos");
            Console.WriteLine("¿Posee un limitador?: "+moto.Limitador);
            Console.WriteLine("-----------------------------------------");
            Console.ReadLine();

        }
    }
}
