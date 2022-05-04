using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LA_MISCELANEA_C
{
    internal class Condicionales
    {
            public void condicionales()
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
        Variables variables = new Variables(0, 0, 0, 0);
        public void Uno()
            {
            try
            {
                Console.WriteLine("Ingrese un numero entero");
                variables.num1 = Convert.ToDouble(Console.ReadLine());
                if (variables.num1 > 0)
                {
                    Console.WriteLine($"El numero {variables.num1} es positivo");
                }
                else
                {
                    Console.WriteLine($"El numero {variables.num1} es negativo");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Ingrese un valor correcto");
            }
              

            }

       public void Dos()
            {
            try
            {
                Console.WriteLine("Ingrese el primer numero");
                variables.num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero");
                variables.num2 = Convert.ToDouble(Console.ReadLine());
                if (variables.num1 > variables.num2)
                {
                    Console.WriteLine($"El numero {variables.num1} es mayor que {variables.num2}");
                }
                else if (variables.num2 > variables.num1)
                {
                    Console.WriteLine($"El numero {variables.num1} es menor que {variables.num2}");
                }
                else
                {
                    Console.WriteLine($"El numero {variables.num1} es igual que {variables.num2}");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Ingrese un valor correctop");

            }
                

            }

       public void Tres()
            {
            try
            {
                Console.WriteLine("Ingrese el primer numero");
                variables.num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero");
                variables.num2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el tercero numero");
                variables.num3 = Convert.ToDouble(Console.ReadLine());

                if (variables.num1 > variables.num2 && variables.num1 > variables.num3)
                {
                    Console.WriteLine($"El numero es mayor {variables.num1}");
                }
                else if (variables.num2 > variables.num1 && variables.num2 > variables.num3)
                {
                    Console.WriteLine($"El numero es mayor {variables.num2}");
                }
                else
                {
                    Console.WriteLine($"El numero es mayor {variables.num3}");
                }
                Console.WriteLine();

                if (variables.num1 < variables.num2 && variables.num1 < variables.num3)
                {
                    Console.WriteLine($"El numero es menor {variables.num1}");
                }
                else if (variables.num2 < variables.num1 && variables.num2 < variables.num3)
                {
                    Console.WriteLine($"El numero es menor {variables.num2}");
                }
                else
                {
                    Console.WriteLine($"El numero es menor {variables.num3}");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Ingrese un valor correcto ");
            }
               
            }

       public void Cuatro()
            {
            try
            {
                Console.WriteLine("Ingrese el primer numero");
                variables.num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero");
                variables.num2 = Convert.ToDouble(Console.ReadLine());
                if (variables.num1 < variables.num2)
                {
                    variables.num3 = variables.num2 + variables.num1;
                    Console.WriteLine($"{variables.num1} + {variables.num2} = {variables.num3}");
                }
                else
                {
                    variables.num3 = variables.num1 - variables.num2;
                    Console.WriteLine($"{variables.num1} - {variables.num2} = {variables.num3}");
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
                Console.WriteLine("Ingrese el primer numero");
                variables.num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero");
                variables.num2 = Convert.ToDouble(Console.ReadLine());
                if (variables.num2 != 0)
                {
                    variables.num3 = variables.num1 / variables.num2;
                    Console.WriteLine($"{variables.num1} / {variables.num2} = {variables.num3}");
                }
                else
                {
                    Console.WriteLine("La división no es posible");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Ingrese un valor que sea correcto");
            }
               
            }

       public void Seis()
            {
            try
            {
                Console.WriteLine("Ingrese el primer numero");
                variables.num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero");
                variables.num2 = Convert.ToDouble(Console.ReadLine());
                if (variables.num1 < 0 || variables.num2 < 0)
                {
                    variables.num3 = variables.num1 + variables.num2;
                    Console.WriteLine($"{variables.num1} + {variables.num2} = {variables.num3}");
                }
                else
                {
                    variables.num3 = variables.num1 * variables.num2;
                    Console.WriteLine($"{variables.num1} * {variables.num2} = {variables.num3}");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Ingrese un valor correcto");
                Console.ReadKey();
            }
                
            }

       public void Siete()
            {
            try
            {
                Console.WriteLine("Ingrese el año");
                variables.num1 = Convert.ToDouble(Console.ReadLine());

                if (variables.num1 % 4 == 0 && variables.num1 % 100 != 0 || variables.num1 % 400 == 0)
                {
                    Console.WriteLine("Es bisiesto {0}\n", variables.num1);
                }
                else
                {
                    Console.WriteLine("no es bisiesto {0} \n", variables.num1);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("ALGO HA SALIDO MAL ");
            }
              
            }

    }
}
