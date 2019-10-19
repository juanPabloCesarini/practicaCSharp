using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploFunciones
{
    class Program
    {
        public static double suma(double n1, double n2)
        {
            return n1 + n2;
        }

        public static double resta(double n1, double n2)
        {
            return n1 - n2;
        }

        public static double prod(double n1, double n2)
        {
            return n1 * n2;
        }

        public static double div(double n1, double n2)
        {
            return n1 / n2;
        }

        public static double pot(double n1, double n2)
        {
            return Math.Pow(n1, n2);
        }
        public static double raiz(double n1, double n2)
        {
            return Math.Pow(n1,(1/n2));
        }

        static void Main(string[] args)
        {
            int opc;
            double sum=0, rest=0, mult=0, divis=0, elev=0, ra=0, n1,n2;
            
            do {
                Console.Clear();
                Console.WriteLine("MENU PRINCIPAL");
                Console.Write("1 - Suma\n2 - Resta\n3 - Producto\n4 - División\n5 - Potencia\n6 - Raiz\n7 - Salir\n");
                Console.Write("Opción --> ");
                opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        Console.Write("ingrese num 1: ");
                        n1 = double.Parse(Console.ReadLine());
                        Console.Write("ingrese num 2: ");
                        n2 = double.Parse(Console.ReadLine());
                        sum = suma(n1, n2);
                        Console.WriteLine("la suma de {0} y {1} es {2}", n1, n2, sum);
                        Console.WriteLine("Presione una tecla para continuar");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Write("ingrese num 1: ");
                        n1 = double.Parse(Console.ReadLine());
                        Console.Write("ingrese num 2: ");
                        n2 = double.Parse(Console.ReadLine());
                        rest = resta(n1, n2);
                        Console.WriteLine("la resta de {0} y {1} es {2}", n1, n2, rest);
                        Console.WriteLine("Presione una tecla para continuar");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Write("ingrese num 1: ");
                        n1 = double.Parse(Console.ReadLine());
                        Console.Write("ingrese num 2: ");
                        n2 = double.Parse(Console.ReadLine());
                        mult = prod(n1, n2);
                        Console.WriteLine("la multiplicación de {0} y {1} es {2}", n1, n2, mult);
                        Console.WriteLine("Presione una tecla para continuar");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Write("ingrese num 1: ");
                        n1 = double.Parse(Console.ReadLine());
                        Console.Write("ingrese num 2: ");
                        n2 = double.Parse(Console.ReadLine());
                        divis = div(n1, n2);
                        Console.WriteLine("la división de {0} y {1} es {2}", n1, n2, divis);
                        Console.WriteLine("Presione una tecla para continuar");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Write("ingrese num 1: ");
                        n1 = double.Parse(Console.ReadLine());
                        Console.Write("ingrese num 2: ");
                        n2 = double.Parse(Console.ReadLine());
                        elev = pot(n1, n2);
                        Console.WriteLine("la potencia de {0} y {1} es {2}", n1, n2, elev);
                        Console.WriteLine("Presione una tecla para continuar");
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.Write("ingrese num 1: ");
                        n1 = double.Parse(Console.ReadLine());
                        Console.Write("ingrese num 2: ");
                        n2 = double.Parse(Console.ReadLine());
                        ra = raiz(n1,n2);
                        Console.WriteLine("la raiz de {0} es {1}", n1, ra);
                        Console.WriteLine("Presione una tecla para continuar");
                        Console.ReadKey();
                        break;
                    case 7:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Gracias por usar la CALCULOCA DE JUANPY");
                        break;
                    default:
                        break;
                }
                
            } while (opc != 7);
            Console.ReadKey();
        }
    }
}
