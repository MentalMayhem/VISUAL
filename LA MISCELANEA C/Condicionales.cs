using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LA_MISCELANEA_C
{
    internal class Condicionales
    {
            public static void condicionales()
            {
                int ElecOp;

                do
                {


                    Console.WriteLine();    
                    Console.WriteLine("SELECCIONE LA OPCIÓN DESEADA");
                    Console.WriteLine();
                    Console.WriteLine(" 1. Saber si el número es positivo o negativo");
                    Console.WriteLine(" 2. Identificar entre dos números cuál es mayor y cuál es menor");
                    Console.WriteLine(" 3. Identificar entre tres números positivos el mayor y menor");
                    Console.WriteLine(" 4. Sumar o restar dos números dependiendo de cuál sea el mayor");
                    Console.WriteLine(" 5. División entre dos números");
                    Console.WriteLine(" 6. Sumar dos números si uno de ellos es negativo, de lo contrario, multiplicar");
                    Console.WriteLine(" 7. Determinar si un año es bisiesto");
                    Console.WriteLine(" 9. Salir");

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

            public static void Uno()
            {
                Console.WriteLine("Ingrese un numero entero");
                double numeroCon = Convert.ToDouble(Console.ReadLine());
                if (numeroCon > 0)
                {
                    Console.WriteLine($"El numero {numeroCon} es positivo");
                }
                else
                {
                    Console.WriteLine($"El numero {numeroCon} es negativo");
                }

            }

            public static void Dos()
            {

                Console.WriteLine("Ingrese el primer numero");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero");
                double num2 = Convert.ToDouble(Console.ReadLine());
                if (num1 > num2)
                {
                    Console.WriteLine($"El numero {num1} es mayor que {num2}");
                }
                else if (num2 > num1)
                {
                    Console.WriteLine($"El numero {num1} es menor que {num2}");
                }
                else
                {
                    Console.WriteLine($"El numero {num1} es igual que {num2}");
                }

            }

            public static void Tres()
            {
                Console.WriteLine("Ingrese el primer numero");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero");
                double num2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el tercero numero");
                double num3 = Convert.ToDouble(Console.ReadLine());

                if (num1 > num2 && num1 > num3)
                {
                    Console.WriteLine($"El numero es mayor {num1}");
                }
                else if (num2 > num1 && num2 > num3)
                {
                    Console.WriteLine($"El numero es mayor {num2}");
                }
                else
                {
                    Console.WriteLine($"El numero es mayor {num3}");
                }
                Console.WriteLine();

                if (num1 < num2 && num1 < num3)
                {
                    Console.WriteLine($"El numero es menor {num1}");
                }
                else if (num2 < num1 && num2 < num3)
                {
                    Console.WriteLine($"El numero es menor {num2}");
                }
                else
                {
                    Console.WriteLine($"El numero es menor {num3}");
                }
            }

            public static void Cuatro()
            {
                double resul = 0;
                Console.WriteLine("Ingrese el primer numero");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero");
                double num2 = Convert.ToDouble(Console.ReadLine());
                if (num1 < num2)
                {
                    resul = num2 + num1;
                    Console.WriteLine($"{num1} + {num2} = {resul}");
                }
                else
                {
                    resul = num1 - num2;
                    Console.WriteLine($"{num1} - {num2} = {resul}");
                }

            }

            public static void Cinco()
            {
                double resul = 0;
                Console.WriteLine("Ingrese el primer numero");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero");
                double num2 = Convert.ToDouble(Console.ReadLine());
                if (num2 != 0)
                {
                    resul = num1 / num2;
                    Console.WriteLine($"{num1} / {num2} = {resul}");
                }
                else
                {
                    Console.WriteLine("La división no es posible");
                }
            }

            public static void Seis()
            {
                double resul = 0;
                Console.WriteLine("Ingrese el primer numero");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero");
                double num2 = Convert.ToDouble(Console.ReadLine());
                if (num1 < 0 || num2 < 0)
                {
                    resul = num1 + num2;
                    Console.WriteLine($"{num1} + {num2} = {resul}");
                }
                else
                {
                    resul = num1 * num2;
                    Console.WriteLine($"{num1} * {num2} = {resul}");
                }
            }

            public static void Siete()
            {
                Console.WriteLine("Ingrese el año");
                double anio = Convert.ToDouble(Console.ReadLine());

                if (anio % 4 == 0 && anio % 100 != 0 || anio % 400 == 0)
                {
                    Console.WriteLine("Es bisiesto {0}\n", anio);
                }
                else
                {
                    Console.WriteLine("no es bisiesto {0} \n", anio);
                }
            }

    }
}
