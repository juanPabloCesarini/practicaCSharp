using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Program
    {
        public static int[] cargarVector()
        {
            int[] vector = new int[10];
            for (int i=0; i<vector.Length; i++)
            {
                Console.WriteLine("Ingresar numero: ");
                vector[i] = int.Parse(Console.ReadLine());
            }
            return vector;
        }

        public static double promPositivos(int cantPos,int sumPos)
        {
            double prom = sumPos / cantPos;
            return prom;
        }

        public static double porcNegyCeros(int ceros, int neg, int elem)
        {
            double porc = ((ceros + neg) * 100) / elem;
            return porc;
        }

        static void Main(string[] args)
        {
            int[] numeros = cargarVector();
            int elem = numeros.Length;
            int pos=0,neg = 0,ceros=0, acumPos=0;
            for (int i=0; i<numeros.Length; i++)
            {
                if (numeros[i] > 0)
                {
                    
                    pos += 1;
                    acumPos += numeros[i];
                }
                else
                {
                    if (numeros[i] != 0)
                    {
                        neg += 1;
                    }
                    else
                    {
                        ceros += 1;
                    }
                }
            }
            double promedio = promPositivos(pos, acumPos);
            double porcentaje = porcNegyCeros(ceros, neg, elem);

            Console.WriteLine("Cantidad de positivos: {0}\nCantidad de negaticoa: {1}\nCantidad de ceros: {2}", pos, neg, ceros);
            Console.WriteLine("Promedio de positivos: {0}",promedio);
            Console.WriteLine("El porcentaje de negativos y ceros: {0}", porcentaje);
            Console.ReadKey();
        }
    }
}
