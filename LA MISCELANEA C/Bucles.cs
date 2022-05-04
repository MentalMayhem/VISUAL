using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LA_MISCELANEA_C
{
    internal class Bucles
    {
        public void bucles ()
        {
            int ElecOp;

            do
            {
                Console.WriteLine();
                Console.WriteLine("SELECCIONE LA OPCIÓN DESEADA");
                Console.WriteLine();
                Console.WriteLine(" 1. Imprimir todos los multiplos  de 3 que hay entre 1 y 100 \n 2. Imprimir todos los impares entre 0 y 100" +
                    " \n 3. Imprimir los números pares del 1 al 100" +
                    "\n 4. imprimir por pantalla los cuadrados de los números del 1 al 30 \n 5. Sumar los cuadrados de los cien primeros números naturales");
                Console.WriteLine(" 6. Según dos números naturales, el primero menor que el segundo, generar y mostrar todos los números comprendidos entre ellos" +
                    " en secuencia ascendente. \n 7. Sumar todos los números que se digitan por teclado mientras no sea cero." +
                    "");
                Console.WriteLine(" 9. SALIR");

                ElecOp = Convert.ToInt32(Console.ReadLine());


                switch (ElecOp)
                {
                    case 1:
                        Console.WriteLine();
                        Uno();
                        Console.WriteLine();

                        break;
                    case 2:
                        Console.WriteLine();
                        Dos();
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.WriteLine();
                        Tres();
                        Console.WriteLine();
                        break;
                    case 4:
                        Console.WriteLine();
                        Cuatro();
                        Console.WriteLine();
                        break;
                    case 5:
                        Console.WriteLine();
                        Cinco();
                        Console.WriteLine();
                        break;
                    case 6:
                        Console.WriteLine();
                        Seis();
                        Console.WriteLine();
                        break;
                    case 7:
                        Console.WriteLine();
                        Siete();
                        Console.WriteLine();
                        break;
                    case 9:
                        Console.WriteLine("Saliendo del programa");
                        break;
                    default:
                        {
                            Console.WriteLine("Opcion no válida");
                        }
                        break;
                }

            } while (ElecOp != 9);

            Console.ReadKey();
        }

        Variables variables = new Variables(0, 0, 0, 0);
        public void Uno()
        {
            try
            {
                Console.WriteLine("Los múltiplos de 3 son: ");
                for (int i = 3; i < 100; i += 3)
                {
                    Console.WriteLine(i);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("ALGO HA SALIDO MAL ");

            }
           

        }

        public void Dos()
        {
            try
            {
                Console.WriteLine("Estos son los números impares entre 0 y 100:");

                for (int i = 1; i < 100; i += 2)
                {
                    Console.WriteLine(i);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("ALGO HA SALIDO MAL ");

            }
               
        }

        public void Tres()
        {
            try
            {
                Console.WriteLine("Estos son los números pares entre 1 y 100:");

                for (int i = 2; i < 100; i += 2)
                {
                    Console.WriteLine(i);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("ALGO HA SALIDO MAL ");
            }
            
        }

        public void Cuatro()
        {
            try
            {
                Console.WriteLine("Estos son los cuadrados de los números del uno al treinta:");

                for (int i = 1; i <= 30; i++)
                {
                    int cuadrados = (int)Math.Pow(i, 2);
                    Console.WriteLine($"El cuadrado de {i} es {cuadrados}");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("ALGO HA SALIDO MAL ");
            }
            
        }

        public void Cinco()
        {
            try
            {
                Console.WriteLine("Esta es la suma de los cuadrados de los cien primeros  naturales");
                int suma = 0;
                for (int i = 1; i <= 100; i++)
                {
                    int cuadrado = (int)Math.Pow(i, 2);
                    suma = suma + cuadrado;
                    Console.WriteLine($"El cuadrado de {i} es {cuadrado}");
                }
                Console.WriteLine($"El resultado de la suma es {suma}");
            }
            catch (FormatException)
            {
                Console.WriteLine("ALGO HA SALIDO MAL");
            }
            
        }

        public void Seis()
        {
            Console.WriteLine("¡¡¡RECUERDE QUE EL PRIMER NÚMERO DEBE SER MENOR QUE EL SEGUNDO!!!");
            Console.WriteLine("Ingrese el primer número");
            int num1 = 0;
            try
            {
                num1 = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException error)
            {
                Console.WriteLine("El valor ingresado no es válido.\nIngrese un valor de tipo numérico", error);
                Console.ReadKey();
            }
            Console.WriteLine("Ingrese el segundo número");
            int num2 = 0;
            try
            {
                num2 = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException error)
            {
                Console.WriteLine("El valor ingresado no es válido.\nIngrese un valor de tipo numérico", error);
                Console.ReadKey();
            }
            Console.WriteLine($"Los números comprendidos entre {num1} y {num2} son:");
            for (int i = num1; i <= num2; i++)
            {
                Console.WriteLine(i);
            }
        }

        public void Siete()
        {
            do
            {
                Console.WriteLine("Ingrese el número que va a sumar");
                variables.num1 = 0;
              try
                {
                    variables.num1 = Convert.ToInt32(Console.ReadLine());
                }
              catch (FormatException)
                {
                    Console.WriteLine("El valor ingresado no es válido.\nIngrese un valor de tipo numérico");
                    Console.ReadKey();
                }
                variables.num2 = variables.num2 + variables.num1;
                Console.WriteLine($"La suma hasta el momento es: {variables.num2}");
            } while (variables.num2 != 0);
        }


    }
}


