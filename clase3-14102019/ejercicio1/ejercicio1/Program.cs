using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresar numero: ");
            int num = int.Parse(Console.ReadLine());

            for (int i =0; i<=15; i++)
            {
                Console.WriteLine("{0} x {1} = {2} ", i, num, i * num);
            }
            Console.ReadKey();
        }
    }
}
