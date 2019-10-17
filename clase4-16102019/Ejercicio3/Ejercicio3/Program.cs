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
            int nroCaja, ticket1M=0,ticket2M=0,ticket3M=0,ticket1T = 0,ticket2T = 0,ticket3T = 0;
            string nombre, turno;
            double importeVenta, totalC1 = 0, totalC2=0, totalC3=0, total=0;

            Console.Write("Nro de caja: ");
            nroCaja = int.Parse(Console.ReadLine());

            while (nroCaja != 0) {
                Console.Write("Turno: ");
                turno = Console.ReadLine();
                Console.Write("Nombre de la Cajera: ");
                nombre = Console.ReadLine();
                Console.Write("Importe de la venta: ");
                importeVenta = double.Parse(Console.ReadLine());
                total += importeVenta;
                switch (turno)
                {
                    case "m":
                        switch (nroCaja)
                    {
                        case 1:
                            ticket1M += 1;
                            totalC1 += importeVenta;
                            break;
                        case 2:
                            ticket2M += 1;
                            totalC2 += importeVenta;
                            break;
                        case 3:
                            ticket3M += 1;
                            totalC3 += importeVenta;
                            break;
                        default:
                            Console.WriteLine("error en nro de caja");
                            goto caja;
                           
                    }
                        break;
                    case "t":
                        switch (nroCaja)
                    {
                        case 1:
                            ticket1T += 1;
                            totalC1 += importeVenta;
                            break;
                        case 2:
                            ticket2T += 1;
                            totalC2 += importeVenta;
                            break;
                        case 3:
                            ticket3T += 1;
                            totalC3 += importeVenta;
                            break;
                        default:
                            goto caja;
                           
                    }
                        break;
                    default:
                        Console.WriteLine("error en turno");
                        break;
                }
                caja:;
                Console.Write("Nro de caja: ");
                nroCaja = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Caja 1 recaudacion: {0}\nCaja 2 recaudacion: {1}\nCaja 3 recaudación: {2}", totalC1, totalC2, totalC3);
            Console.WriteLine("");
            Console.WriteLine("TURNO MAÑANA:\nVentas caja 1: {0}\nVentas caja 2: {1}\nVentas caja 3: {2}", ticket1M, ticket2M, ticket3M);
            Console.WriteLine("TURNO TARDE:\nVentas caja 1: {0}\nVentas caja 2: {1}\nVentas caja 3: {2}", ticket1T, ticket2T, ticket3T);
            Console.WriteLine("");
            Console.WriteLine("Facturacion total: {0}", total);
            Console.ReadKey();
        }
    }
}
