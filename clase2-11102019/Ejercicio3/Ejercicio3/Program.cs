using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int nroEmpleado, cantEmpleados, emplA, emplB, emplC, emplD;
            string categ;

            cantEmpleados = 0;
            emplA = 0;
            emplB = 0;
            emplC = 0;
            emplD = 0;
            
            Console.Write("Ingrese nro de empleado: ");
            nroEmpleado = int.Parse(Console.ReadLine());

            while (nroEmpleado != 0){
                Console.Write("Ingrese la categoría: ");
                categ = Console.ReadLine();
                switch (categ)
                {
                    case "a":
                        emplA += 1;
                        break;
                    case "b":
                        emplB += 1;
                        break;
                    case "c":
                        emplC += 1;
                        break;
                    case "d":
                        emplD += 1;
                        break;
                    default:
                        Console.WriteLine("Error en categoría");
                        break;
                }
                cantEmpleados += 1;
                Console.Write("Ingrese nro de empleado: ");
                nroEmpleado = int.Parse(Console.ReadLine());
            }
            Console.Write("Total de empleados: {0}\nCategoría A: {1}\nCategoría B: {2}\nCategoría C: {3}\nCategoría D: {4}", cantEmpleados, emplA, emplB, emplC, emplD);
            Console.ReadKey();



        }
    }
}
