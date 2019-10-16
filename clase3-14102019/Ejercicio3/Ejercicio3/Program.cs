using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, pos = 0, neg = 0, pares = 0, impares = 0;
            string corte = "s";

            

            while (corte != "n")
            {
                Console.Write("Ingrease el número: ");
                num = int.Parse(Console.ReadLine());
                if (num > 0)
                {
                    pos += 1;
                }
                else
                {
                    neg += 1;
                }
                if (num % 2 == 0)
                {
                    pares += 1;
                }
                else
                {
                    impares += 1;
                }
                

                Console.Write("Continua?? (s/n): ");
                corte = Console.ReadLine();
            }
            Console.WriteLine("Positivos: {0}", pos);
            Console.WriteLine("Negativos: {0}", neg);
            Console.WriteLine("Pares: {0}", pares);
            Console.WriteLine("Impares: {0}", impares);
            Console.ReadKey();
        }
    }
}
