using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int atletas, cadetes, juveniles, veteranos, edad;
            double tiempo, tiempoMin, tiempoMax, porcCateg, promPorCat, atletasAux;
            string apellido;

            Console.Write("ingrese cantidad de atletas: ");
            atletas = int.Parse(Console.ReadLine());

            for (int i = 0; i <= atletas; i++)
            {
                Console.WriteLine("Ingrese el apellido: ");
                apellido = Console.ReadLine();
                Console.WriteLine("ingrese edad: ");
            }
            Console.ReadKey();
        }
    }   
}
