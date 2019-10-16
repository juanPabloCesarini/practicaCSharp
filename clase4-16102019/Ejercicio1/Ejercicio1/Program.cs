using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int year, cantBis=0, cantNoBis=0, todos=0;
            double porcBis=0, porcNoBis=0;
            bool seguir=true;
            string si="s";

            while (seguir)
            {
                if (si == "s" || si == "S") { 
                    Console.Write("Ingresar año: ");
                    year = int.Parse(Console.ReadLine());
                    todos += 1;
                    if (((year%2==0) && (year%100!=0)) || (year % 400 == 0)){
                        Console.WriteLine("Es bisiesto");
                        cantBis += 1;
                    }
                    else
                    {
                        Console.WriteLine("No es bisiesto");
                        cantNoBis += 1;
                    }
                    Console.Write("Continúa (s/n)? ");
                    si = Console.ReadLine();
                }
                else
                {
                    seguir = false;
                }
                
            }
            porcBis = (cantBis * 100) / todos;
            porcNoBis = (cantNoBis * 100) / todos;
            Console.WriteLine("Porcentaje bisiestos: {0}, porcentaje normales: {1}", porcBis, porcNoBis);
            Console.ReadKey();
        }
    }
}
