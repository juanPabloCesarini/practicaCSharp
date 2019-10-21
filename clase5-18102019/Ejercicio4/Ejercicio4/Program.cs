using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        public static double promedio(double[] alumnos)
        {
            double prom = 0, suma=0;
            for (int i=0; i < alumnos.Length; i++)
            {
                suma = suma + alumnos[i];
                prom = suma / alumnos.Length;
            }
            return prom;
        }
        public static int aplazados(double[] alumnos)
        {
            int apla = 0;
            for (int i=0; i<alumnos.Length; i++)
            {
                if (alumnos[i] < 4)
                {
                    apla += 1;
                }
            }
            return apla;
        }
        public static int promocionados(double[] alumnos)
        {
            int aprobados = 0;
            for (int i =0; i<alumnos.Length; i++)
            {
                if (alumnos[i] >= 4)
                {
                    aprobados += 1;
                }
            }
            return aprobados;
        }
        public static int diez(double[] alumnos)
        {
            int X = 0;
            for (int i=0; i < alumnos.Length; i++)
            {
                if (alumnos[i] == 10)
                {
                    X += 1;
                }
            }
            return X;
        }
        static void Main(string[] args)
        {
            int al = 0, res1=0,res2=0,res3=0;
            double nota = 0, notaProm = 0; ;
            Console.Write("Ingresar cantidad de alumnos: ");
            al = int.Parse(Console.ReadLine());
            double[] alumnos = new double[al];
            for (int i=0; i < alumnos.Length; i++)
            {
                Console.Write("Ingresar nota: ");
                nota = double.Parse(Console.ReadLine());
                alumnos[i] = nota;
            }
            notaProm = promedio(alumnos);
            res1 = aplazados(alumnos);
            res2 = promocionados(alumnos);
            res3 = diez(alumnos);
            Console.WriteLine("Nota promedio: {0}", notaProm);
            Console.WriteLine("Aplazados: {0}\nPromocionados: {1}\nCon 10: {2}", res1, res2, res3);
            Console.ReadKey();
        }
    }
}
