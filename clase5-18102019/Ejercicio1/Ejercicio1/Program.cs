using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        public static int sumarEdades(int[] vector)
        {
            int suma = 0;
            for(int i=0; i < vector.Length; i++)
            {
                suma += vector[i];
            }
            return suma;
        }
        public static double promediarEdades(int suma, int[] vector)
        {
            double prom = suma / vector.Length;
            return prom; 
        }
        static void Main(string[] args)
        {
            int[] vector = new int[10];
            int men = 0, may = 0, suma=0;

            for (int i =0; i<vector.Length; i++)
            {
                Console.Write("Ingrese edad: ");
                vector[i] = int.Parse(Console.ReadLine());
                if (vector[i] < 18)
                {
                    men += 1;
                }
                else
                {
                    may += 1;
                }

            }
            suma = sumarEdades(vector);
            Console.WriteLine("La suma de edades es: {0}", suma);
            Console.WriteLine("La edad promedio es: {0}", promediarEdades(suma, vector));
            Console.WriteLine("Mayores de 18 años: {0}\nMenores de 18 años: {1}", may, men);
            Console.ReadKey();
        }
    }
}
