using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            int nroProd, cantVendida, cantVend1,cantVend2,cantVend3,cantVend4 ;
            double precio, subt1, subt2, subt3, subt4, ventasTotales, factTotal;

            subt1 = 0;
            subt2 = 0;
            subt3 = 0;
            subt4 = 0;
            ventasTotales = 0;
            factTotal = 0;
            cantVend1 = 0;
            cantVend2 = 0;
            cantVend3 = 0;
            cantVend4 = 0;

            Console.Write("Numero de producto: ");
            nroProd = int.Parse(Console.ReadLine());

            while (nroProd != 0)
            {
                Console.Write("Cantidad vendida: ");
                cantVendida = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el precio: ");
                precio = double.Parse(Console.ReadLine());

                switch (nroProd)
                {
                    case 1:
                        cantVend1 = cantVend1 + cantVendida;
                        subt1 = subt1+ cantVendida * precio;
                        break;
                    case 2:
                        cantVend2 = cantVend2 + cantVendida;
                        subt2 = subt2 + cantVendida * precio;
                        break;
                    case 3:
                        cantVend3 = cantVend3 + cantVendida;
                        subt3 = subt3 + cantVendida * precio;
                        break;
                    case 4:
                        cantVend4 = cantVend4 + cantVendida;
                        subt4 = subt4 + cantVendida * precio;
                        break;
                    default:
                        break;
                }
                ventasTotales = cantVend1 + cantVend2 + cantVend3 + cantVend4;
                factTotal = subt1 + subt2 + subt3 + subt4;
                Console.Write("Numero de producto: ");
                nroProd = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Cantidad vendida por numero de producto");
            Console.WriteLine("1 - {0}\n2 - {1}\n3 - {2}\n4 - {3}", cantVend1,cantVend2,cantVend3,cantVend4);
            Console.WriteLine("Facturación por producto");
            Console.WriteLine("1 - {0}\n2 - {1}\n3 - {2}\n4 - {3}", subt1, subt2, subt3, subt4);
            Console.WriteLine("Facturación total: {0}", factTotal);
            Console.ReadKey();
        }
    }
}
