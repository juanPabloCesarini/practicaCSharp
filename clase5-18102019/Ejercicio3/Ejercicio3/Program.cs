using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        public static double sueldoProm(double[] sueldos)
        {
            double sumaSueldo = 0, sdoProm =0;
            for (int i=0; i < sueldos.Length; i++)
            {
                sumaSueldo = sumaSueldo + sueldos[i];
                sdoProm = sumaSueldo / sueldos.Length;
            }
            return sdoProm;
        } 
        public static int sumarEdad(int[] edades)
        {
            int tEdad = 0;
            for (int i=0; i<edades.Length; i++)
            {
                tEdad += edades[i];
            }
            return tEdad;
        
        }
        public static int buscarEmplUno(int[] edades)
        {
            int cantEmpl = 0;
            for (int i = 0; i < edades.Length; i++)
            {
                if (edades[i] > 23 && edades[i] < 40)
                {
                    cantEmpl += 1;
                }
            }
            return cantEmpl;
        }
        public static int buscarEmplDos(int[] edades, double[] sueldos)
        {
                int cantEmpleDos = 0;
                for (int i=0; i < edades.Length; i++)
                {
                    if (edades[i] > 30 && sueldos[i]<1000)
                    {
                        cantEmpleDos += 1;
                    }
                }
            return cantEmpleDos;
        }
        public static int buscarEmplTres(int[] edades, double promEdad)
        {
            int cantEmplMenores = 0;
            for (int i=0; i < edades.Length; i++)
            {
                if (edades[i] < promEdad)
                {
                    cantEmplMenores += 1;
                }
            }
            return cantEmplMenores;
        }

        static void Main(string[] args)
        {
            double[] sueldos = new double[5];
            double promEdad;
            int[] edades = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ingresar sueldos: ");
                sueldos[i] = double.Parse(Console.ReadLine());
                Console.Write("Ingresar edad: ");
                edades[i] = int.Parse(Console.ReadLine());
            }
            promEdad = sumarEdad(edades) / edades.Length;

            Console.WriteLine("Sueldo Promedio: {0}", sueldoProm(sueldos));
            Console.WriteLine("Suma edades: {0}\nEdad promedio: {1}", sumarEdad(edades), promEdad);
            Console.WriteLine("Empleados entre 23 y 40 años: {0}", buscarEmplUno(edades));
            Console.WriteLine("Empleados mayores de 30 con sueldo menor a 1000: {0}", buscarEmplDos(edades, sueldos));
            Console.WriteLine("Empleados con edad menor al promedio: {0}", buscarEmplTres(edades, promEdad));
            Console.ReadKey();
        }
    }
}
