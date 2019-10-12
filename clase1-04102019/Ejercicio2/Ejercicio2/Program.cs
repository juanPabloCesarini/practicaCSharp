using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            double horas, precioPorHora, sueldo;
            Console.Write("Ingrese cantidad de horas: ");
            horas = double.Parse(Console.ReadLine());
            Console.Write("Ingrese valor de la hora: ");
            precioPorHora = double.Parse(Console.ReadLine());

            sueldo = horas * precioPorHora;

            Console.WriteLine("El sueldo a abonar es: $ {0}", sueldo);
        }
    }
}
