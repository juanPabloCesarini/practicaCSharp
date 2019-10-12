using System;

namespace ej2enClase1110
{
    class Program
    {
        static void Main(string[] args)
        {
            int nroEmpleado, totalRegistros, empleadosA, empleadosB, empleadosC, empleadosD;
            string cat;
            totalRegistros = 0;
            empleadosA = 0;
            empleadosB = 0;
            empleadosC = 0;
            empleadosD = 0;

            Console.Write("Ingrese nro de Empleado: ");
            nroEmpleado = int.Parse(Console.ReadLine());

            while (nroEmpleado != 0)
            {
                Console.Write("Ingrese la categoria: ");
                cat = Console.ReadLine();
                totalRegistros += 1;
                switch (cat)
                {
                    case "a":
                        empleadosA += 1;
                        break;
                    case "A":
                        empleadosA += 1;
                        break;
                    case "b":
                        empleadosB += 1;
                        break;
                    case "B":
                        empleadosB += 1;
                        break;
                    case "c":
                        empleadosC += 1;
                        break;
                    case "C":
                        empleadosC += 1;
                        break;
                    case "d":
                        empleadosD += 1;
                        break;
                    case "D":
                        empleadosD += 1;
                        break;
                    default:
                        Console.WriteLine("ERROR!!");
                        break;

                }
                Console.Write("Ingrese nro de Empleado: ");
                nroEmpleado = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Toital Ingredados {0}", totalRegistros);
            Console.WriteLine("Total Empleados A: {0}\ntotal empleados B: {1}\ntotal empleados C: {2}\ntotal empleados D: {3}", empleadosA, empleadosB, empleadosC, empleadosD);
            Console.ReadKey();
        }
        
        
    }
}
