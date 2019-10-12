using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3,totalNotas,promedio;

            Console.Write("Ingrese nota HTML: ");
            nota1 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese nota CSS: ");
            nota2 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese nota SQL: ");
            nota3 = double.Parse(Console.ReadLine());

            totalNotas = nota1 + nota2 + nota3;
            promedio = totalNotas / 3;

            if (promedio >= 7)
            {
                Console.Write("APROBADO!!!!");
            }
            else
            {
                Console.Write("NO APROBADO -> RECURSAR!!!");
            }
            Console.ReadKey();
        }
    }
}
