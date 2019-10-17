using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            string sexo, trabaja, estudia, si="si";
            int edad, cantTrab=0, cantNini=0,cantEstudiaMas18=0, todos=0;
            double porcTrab = 0;
            bool seguir=true;

            while (seguir)
            {
                if (si == "si")
                {
                    Console.Write("Sexo: ");
                    sexo = Console.ReadLine();
                    Console.Write("Trabaja: ");
                    trabaja = Console.ReadLine();
                    Console.Write("Estudia: ");
                    estudia = Console.ReadLine();
                    Console.Write("Edad: ");
                    edad = int.Parse(Console.ReadLine());
                    todos += 1;
                    if (trabaja == "si")
                    {
                        cantTrab += 1;
                    }
                    else
                    {
                        if (estudia != "si")
                        {
                            cantNini += 1;
                        }
                        else
                        {
                            if (edad > 18)
                            {
                                cantEstudiaMas18 += 1;
                            }
                        }
                    }
                    Console.Write("Continúa si/no?:");
                    si = Console.ReadLine();

                }
                else
                {
                    seguir = false;
                }
                
            }
            porcTrab = (cantTrab * 100) / todos;
            Console.WriteLine("No trabajan ni estudian: {0}", cantNini);
            Console.WriteLine("Porcentaje que trabajan: {0}", porcTrab);
            Console.WriteLine("Mayores de 18 que estudian: {0}", cantEstudiaMas18);
            Console.ReadKey();
        }
    }
}
