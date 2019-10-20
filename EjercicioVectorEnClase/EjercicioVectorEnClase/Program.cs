using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioVectorEnClase
{
    class Program
    {
        public static int[] cargarVector()
        {
            int[] numeros;
            numeros = new int[10];
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write("Ingresar numero: ");
                numeros[i] = int.Parse(Console.ReadLine());

            }

            return numeros;
        }

        public static double promedio(int[] vector)
        {
            int total = 0;
            double prom = 0;
            for (int i = 0; i < vector.Length; i++)
            {
                total = total + vector[i];
                prom = total / vector.Length;
            }
            return prom;
        }
        public static double porcentaje(int num, int[] vector)
        {
            double porc;


            return porc = (num * 100) / vector.Length;
        }
        public static void Main(string[] args)
        {
            int[] vector = cargarVector();
            int pares = 0, impares = 0;
            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] % 2 == 0)
                {
                    pares++;
                }
                else
                {
                    impares++;
                }
            }
            Console.WriteLine("Pares: {0}, Impares {1}", pares, impares);
            Console.WriteLine("Promedio: {0}", promedio(vector));
            Console.WriteLine("Porcentaje pares: {0}, Porcentaje impares {1}", porcentaje(pares, vector), porcentaje(impares, vector));
            Console.ReadKey();

        }
    }
}