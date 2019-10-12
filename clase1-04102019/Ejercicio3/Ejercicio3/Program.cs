using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, promedio;
            Console.Write("Nota uno: ");
            nota1 = double.Parse(Console.ReadLine());
            Console.Write("Nota dos: ");
            nota2 = double.Parse(Console.ReadLine());
            Console.Write("Nota tres: ");
            nota3 = double.Parse(Console.ReadLine());

            promedio = (nota1 + nota2 + nota3) / 3;

            Console.WriteLine("EL PROMEDIO ES: {0}", promedio);
        }
    }
}
