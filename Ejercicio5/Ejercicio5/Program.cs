using System;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, total, promedio, p1, p2;
            Console.Write("Ingresar valor A: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Ingresa calor B: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Ingresar varlor C: ");
            c = double.Parse(Console.ReadLine());
            Console.Write("Ingresar varlor D: ");
            d = double.Parse(Console.ReadLine());

            total = a + b + c + d;
            promedio = total / 4;

            p1 = (a * 100) / c;
            p2 = (d * 100) / total;

            Console.WriteLine("El promedio: {0}\nEl porcentaje 1: {1}\nEl porcentaje 2: {2}", promedio, p1, p2);
        }
    }
}
