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
            int hombres, mujeres, total;
            double porcH, porcM;

            Console.Write("Ingresar cantidad de hombres: ");
            hombres = int.Parse(Console.ReadLine());

            Console.Write("Ingresar cantidad mujeres: ");
            mujeres = int.Parse(Console.ReadLine());

            total = hombres + mujeres;
            porcH = (hombres * 100) / total;
            porcM = (mujeres * 100) / total;

            Console.Write("Total: {0}\nPprcentaje hombres: {1}\nProcentaje mujeres: {2}", total, porcH, porcM);
            Console.ReadKey();
        }
    }
}
