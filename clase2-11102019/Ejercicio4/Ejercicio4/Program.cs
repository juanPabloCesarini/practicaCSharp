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
            int DNI, edad, cantS, cantN;
            double salario;
            string casado;
            cantS = 0;
            cantN = 0;
            Console.Write("DNI: ");
            DNI = int.Parse(Console.ReadLine());

            while (DNI != 0)
            {
                Console.Write("Estado civil Casado 'S' - Soltero 'N': ");
                casado = Console.ReadLine();
                Console.Write("Edad: ");
                edad = int.Parse(Console.ReadLine());
                Console.Write("Salario: ");
                salario = double.Parse(Console.ReadLine());

                if (casado == "S" && edad>=18 && salario > 10000)
                {
                    cantS += 1;
                }
                else
                {
                    cantN += 1;
                }
                Console.Write("DNI: ");
                DNI = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Pueden obtener el crédito: {0}\nSe pierden el crédito {1}", cantS, cantN);
            Console.ReadKey();
        }
    }
}
