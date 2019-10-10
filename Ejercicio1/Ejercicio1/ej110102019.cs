using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, suma, resta, producto;
            
            Console.Write("Ingresar primer número: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Ingresar segundo número: ");
            b = int.Parse(Console.ReadLine());

            suma = a + b;
            resta = a - b;
            producto = a * b;

            Console.WriteLine("La suma de {0} + {1} es: {2}", a, b, suma);
            Console.WriteLine("La suma de {0} - {1} es: {2}", a, b, resta);
            Console.WriteLine("La suma de {0} * {1} es: {2}", a, b, producto);
        }
    }
}
