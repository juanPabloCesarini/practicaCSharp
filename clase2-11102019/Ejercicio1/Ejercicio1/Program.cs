using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.Write("Ingresar primer número: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Ingresar segundo número: ");
            num2 = int.Parse(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine("LOS NUMEROS SON IGUALES");
            }
            else
            {
                if (num1 > num2)
                {
                    Console.WriteLine("{0} es mayor que {1}", num1, num2);
                }
                else
                {
                    Console.WriteLine("{0} es menor que {1}", num1, num2);
                }
            }
            Console.ReadKey();
        }
    }
}
