using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            string corte, genero;
            int edad,cantH,cantM,cantContrat,cantNoContrat,cantTotal, edadTotal;
            double peso, altura, edadProm, porcContrat, porcNoContrat;
            corte = "S";
            cantH = 0;
            cantM = 0;
            cantContrat = 0;
            cantNoContrat = 0;
            cantTotal = 0;
            edadTotal = 0;
            
            while (corte == "S")
            {
                Console.Write("Genero: ");
                genero = Console.ReadLine();
                Console.Write("Edad: ");
                edad = int.Parse(Console.ReadLine());
                Console.Write("Altura: ");
                altura = double.Parse(Console.ReadLine());
                Console.Write("Peso: ");
                peso = double.Parse(Console.ReadLine());
                edadTotal += edad;
               
                if (genero == "H")
                {
                    cantH += 1;
                    if(edad<=25 && altura>1.75 && peso < 70)
                    {
                        cantContrat += 1;
                    }
                    else
                    {
                        cantNoContrat += 1;
                    }
                }
                else
                {
                    cantM += 1;
                }
                cantTotal += 1;
                Console.Write("Desea continuar S/N: ");
                corte = Console.ReadLine();
            }
            edadProm = edadTotal / cantTotal;
            cantNoContrat += cantM;
            porcContrat = (cantContrat * 100) / cantTotal;
            porcNoContrat = (cantNoContrat * 100) / cantTotal;

            Console.WriteLine("Modelos Contratados: {0} - Modelos descartados: {1}", cantContrat, cantNoContrat);
            Console.WriteLine("Cantidad de hombres: {0} - Cantidad de mujeres: {1}", cantH, cantM);
            Console.WriteLine("Promedio edades: {0}", edadProm);
            Console.WriteLine("Porcentaje de contratados {0} - Porcentaje de descartados {1}", porcContrat, porcNoContrat);
            Console.ReadKey();




        }
    }
}
