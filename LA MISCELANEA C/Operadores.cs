using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LA_MISCELANEA_C
{
    internal class Operadores
    {
        
        public void operadores()
        {
            int ElecOp;

            do
            {

                Console.WriteLine();
                Console.WriteLine("SELECCIONE LA OPCIÓN DESEADA");
                Console.WriteLine();
                Console.WriteLine(" 1. Area de un triángulo \n 2. Suma de dos números \n 3. Cuadrado de un número" +
                    "\n 4. Conversión de euros a dólares \n 5. Área y perímetro de un cuadrado en base a sus lados");
                Console.WriteLine(" 6. Area y volumen de un cilindro \n 7. Longitud y área de un circulo en base a su radio" +
                    "\n 8. Promedio de tres números");
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
                    case 8:
                        Console.WriteLine();
                        Ocho();
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
                Console.WriteLine("Ingrese la base del triangulo");
                variables.num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese la altura del triangulo");
                variables.num2 = Convert.ToDouble(Console.ReadLine());
                variables.num3 = variables.num1 * variables.num2 / 2;
                Console.WriteLine("El resultado es:" + variables.num3);
            }
            catch (FormatException )
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
                variables.num3 = variables.num1 + variables.num2;
                Console.WriteLine("El resultado es:" + variables.num3);
            }
            catch (FormatException)
            {
                Console.WriteLine("Ingrese un valor correcto");
            }

        }

        public void Tres()
        {
            try
            {
                Console.WriteLine("Ingrese el numero");
                variables.num1 = Convert.ToDouble(Console.ReadLine());
                variables.num2 = variables.num1 * variables.num1;
                Console.WriteLine("El resultado es:" + variables.num2);
            }
            catch (FormatException)
            {
                Console.WriteLine("Ingrese un valor correcto");

            }
        }

        public void Cuatro()
        {
            try
            {
                Console.WriteLine("Ingrese el numero de euros que desea convertir");
                variables.num1 = Convert.ToDouble(Console.ReadLine());
                variables.num2 = variables.num1 * 0.94;
                Console.WriteLine("Euros = €" + variables.num1 + " Equivalen a $" + variables.num2 + " Dolares");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ingrese un valor correcto");
            }
        }

        public void Cinco()
        {
            try
            {
                Console.WriteLine("Ingrese un lado del cuadrado");
                variables.num1 = Convert.ToDouble(Console.ReadLine());
                variables.num2 = Math.Pow(variables.num1, 2);
                variables.num3 = variables.num1 * 4;
                Console.WriteLine("El area del cuadrado es: " + variables.num2);
                Console.WriteLine("El perimetro del cuadrado es: " + variables.num3);
            }
            catch (FormatException)
            {
                Console.WriteLine("Ingrese un valor correcto");
                
            }
           
        }

        public void Seis()
        {
            try
            {
                Console.WriteLine("Ingrese el radio del cilindro");
                variables.num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese la altura del cilindro");
                variables.num2 = Convert.ToDouble(Console.ReadLine());
                variables.num3 = Math.PI * Math.Pow(variables.num1, 2) * variables.num2;
                variables.num4 = (2 * (Math.PI) * variables.num1 * variables.num2) + (2 * (Math.PI) * Math.Pow(variables.num1, 2));
                Console.WriteLine("El volumen del cilindro es: " + variables.num3);
                Console.WriteLine("El area del cilindro es: " + variables.num4);
            }
            catch (FormatException)
            {
                Console.WriteLine("Ingrese un valor correcto");
                
            }
            
        }

        public void Siete()
        {
            try
            {
                Console.WriteLine("Ingrese el radio del circulo");
                variables.num1 = Convert.ToDouble(Console.ReadLine());
                variables.num2 = 2 * Math.PI * variables.num1;
                variables.num3 = Math.PI * Math.Pow(variables.num1, 2);
                Console.WriteLine("La longitud de la circunferencia es: " + variables.num2);
                Console.WriteLine("El area del circulo es: " + variables.num3);
            }
            catch (FormatException)
            {
                Console.WriteLine("Ingrese un valor correcto");
            }
            
        }

        public void Ocho()
        {
            try
            {
                Console.WriteLine("Ingrese el primer numero");
                variables.num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero");
                variables.num2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el tercer numero");
                variables.num3 = Convert.ToDouble(Console.ReadLine());
                variables.num4 = (variables.num1 + variables.num2 + variables.num3) / 3;
                Console.WriteLine("El promedio de los tres numeros es: " + variables.num4);
            }
            catch (FormatException)
            {
                Console.WriteLine("Ingrese un valor correcto");
                
            }
            
        }

    }
}
