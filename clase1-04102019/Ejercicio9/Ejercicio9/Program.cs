using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre, apellido;
            int edad;

            Console.Write("Nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Apellido: ");
            apellido = Console.ReadLine();
            Console.Write("Edad: ");
            edad = int.Parse(Console.ReadLine());

            if (edad >= 18)
            {
                Console.WriteLine("{0} {1}, es mayor", nombre, apellido);
            }
            else
            {
                Console.WriteLine("{0} {1}, es menor", nombre, apellido);
            }
            Console.ReadKey();
        }
    }
}
