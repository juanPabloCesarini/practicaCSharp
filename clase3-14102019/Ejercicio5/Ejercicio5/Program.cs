using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1=0, num2=0, resultado=0, opc;

           /* Console.Write("Número 1: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Número 2: ");
            num2 = int.Parse(Console.ReadLine());*/

            

            do
            {
                Console.WriteLine("1-Suma\n2-Resta\n3-Multiplicar\n4-División\n5-Salir");
                Console.Write("Elegí tu opcion: ");
                opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        Console.Write("Número 1: ");
                        num1 = int.Parse(Console.ReadLine());
                        Console.Write("Número 2: ");
                        num2 = int.Parse(Console.ReadLine());
                        resultado = num1 + num2;
                        Console.WriteLine("el resultado de {0} + {1} es {2}", num1, num2, resultado);
                        break;
                        
                    case 2:
                        Console.Write("Número 1: ");
                        num1 = int.Parse(Console.ReadLine());
                        Console.Write("Número 2: ");
                        num2 = int.Parse(Console.ReadLine());
                        resultado = num1 - num2;
                        Console.WriteLine("el resultado de {0} - {1} es {2}", num1, num2, resultado);
                        break;

                    case 3:
                        Console.Write("Número 1: ");
                        num1 = int.Parse(Console.ReadLine());
                        Console.Write("Número 2: ");
                        num2 = int.Parse(Console.ReadLine());
                        resultado = num1 * num2;
                        Console.WriteLine("el resultado de {0} * {1} es {2}", num1, num2, resultado);
                        break;

                    case 4:
                        Console.Write("Número 1: ");
                        num1 = int.Parse(Console.ReadLine());
                        Console.Write("Número 2: ");
                        num2 = int.Parse(Console.ReadLine());
                             
                        if (num2 == 0)
                        {
                            Console.WriteLine("No se puede dividir por 0");
                        }
                        else
                        {
                            resultado = num1 / num2;
                            Console.WriteLine("el resultado de {0} / {1} es {2}", num1, num2, resultado);
                        }
                        break;
                    case 5:
                        Console.WriteLine("--FIN--");
                        break;

                }
            
            
            } while (opc != 5);
            
            Console.ReadKey();
        }
    }
}
