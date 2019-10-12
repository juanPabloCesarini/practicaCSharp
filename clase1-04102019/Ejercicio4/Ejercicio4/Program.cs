using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int ganados, empatados, totalG,totalE,puntos;
            Console.Write("Cantidad de partidos ganados: ");
            ganados = int.Parse(Console.ReadLine());
            Console.Write("Cantidad de partidos empatados: ");
            empatados = int.Parse(Console.ReadLine());
           
            totalG = ganados * 3;
            totalE = empatados * 1;
            puntos = totalG + totalE;

            Console.WriteLine("El total del puntaje es: {0}", puntos);
        }
    }
}
