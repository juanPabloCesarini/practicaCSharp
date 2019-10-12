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
            int dia, mes;

            Console.Write("Ingresar día: "); dia = int.Parse(Console.ReadLine());
            Console.Write("Ingresar mes: "); mes = int.Parse(Console.ReadLine());

            switch (dia)
            {
                case 1:
                    Console.WriteLine("Lunes");
                    break;
                case 2:
                    Console.WriteLine("Martes");
                    break;
                case 3:
                    Console.WriteLine("Miércoles");
                    break;
                case 4:
                    Console.WriteLine("Jueves");
                    break;
                case 5:
                    Console.WriteLine("Viernes");
                    break;
                case 6:
                    Console.WriteLine("Sábado");
                    break;
                case 7:
                    Console.WriteLine("Domingo");
                    break;
                default:
                    Console.WriteLine("--ERROR--");
                    break;
            }
            if (mes<=1 && mes <= 3)
            {
                Console.WriteLine("Primer Trimestre");
            }
            else
            {
                if (mes>3 && mes <= 6)
                {
                    Console.WriteLine("Segundo Trimestre");
                }
                else
                {
                    if (mes>6 && mes <= 9)
                    {
                        Console.WriteLine("Tercer Trimestre");
                    }
                    else
                    {
                        if (mes>9 && mes <= 12)
                        {
                            Console.WriteLine("Cuarto Trimestre");
                        }
                        else
                        {
                            Console.WriteLine("--ERROR--");
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
