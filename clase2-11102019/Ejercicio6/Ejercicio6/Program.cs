using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int codEmpleado,cantEmpleados;
            string categoria;
            double sueldo, sueldoTotal, sueldoCatA,sueldoCatB,sueldoCatC,promSueldo;

            Console.Write("Ingresar código de empleado: ");
            codEmpleado = int.Parse(Console.ReadLine());
            
            cantEmpleados = 0;
            sueldoTotal = 0;
            sueldoCatA = 0;
            sueldoCatB = 0;
            sueldoCatC = 0;

            while (codEmpleado != 0)
            {
                Console.Write("Categoría: ");
                categoria = Console.ReadLine();
                Console.Write("Sueldo: ");
                sueldo = double.Parse(Console.ReadLine());

                if(categoria == "gerente" || categoria == "empleado"){
                    sueldoCatA = sueldoCatA + sueldo + 150;
                }
                if(categoria =="cadete" || categoria == "adm")
                {
                    sueldoCatB = sueldoCatB + sueldo + 170;
                }
                if(categoria=="vendedor" || categoria == "cobrador")
                {
                    sueldoCatC = sueldoCatC + sueldo + 100;
                }
                sueldoTotal = sueldoTotal + sueldoCatA + sueldoCatB + sueldoCatC;
                cantEmpleados += 1;
                Console.Write("Ingresar código de empleado: ");
                codEmpleado = int.Parse(Console.ReadLine());
            }
            promSueldo = sueldoTotal / cantEmpleados;
            Console.WriteLine("Sueldo gerente o empleado: {0}\nSueldo cadete o adm: {1}\nSueldo vendedor o cobrador: {2}", sueldoCatA, sueldoCatB, sueldoCatC);
            Console.WriteLine("Total de empleados {0}\nPromedio de Sueldos: {1}", cantEmpleados, promSueldo);
            Console.ReadKey();
        }
    }
}
