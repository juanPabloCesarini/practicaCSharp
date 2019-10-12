using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.Write("Ingresar número: ");
            numero = int.Parse(Console.ReadLine());

            if (numero < 0)
            {
                Console.WriteLine("ES NEGATIVO");
            }
            else
            {
                Console.WriteLine("ES POSITIVO");
            }
            Console.ReadKey();
        }
    }
}
