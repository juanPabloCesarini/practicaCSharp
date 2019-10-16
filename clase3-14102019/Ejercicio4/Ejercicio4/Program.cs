using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0, acumulador = 0, numero;
            double promedio = 0;

            do
            {
                Console.Write("ingresa un número: ");
                numero = int.Parse(Console.ReadLine());
                contador += 1;
                acumulador += numero;
                promedio = acumulador / contador;
            } while (numero != 0);
            Console.Write("El promedio es: {0}", promedio);
            Console.ReadKey();
        }
    }
}
