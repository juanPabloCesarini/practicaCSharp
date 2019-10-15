using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int atletas, edad;
            double tiempo, tiempoMin = 9999, tiempoMax = 0, porcC = 0, porcJ=0, porcV=0, tiempoProm = 0, tiempoTot = 0;
            double tPromCad = 0, tPromJuv = 0, tPromVet = 0, tiempoCad=0,tiempoJuv=0,tiempoVet=0, cadetes = 0, juveniles = 0, veteranos = 0;
            string apellido, apellidoMin="", apellidoMax="";

            Console.Write("ingrese cantidad de atletas: ");
            atletas = int.Parse(Console.ReadLine());

            for (int i = 0; i < atletas; i++)
            {
                Console.WriteLine("Ingrese el apellido: ");
                apellido = Console.ReadLine();
                Console.WriteLine("ingrese edad: ");
                edad = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el tiempo: ");
                tiempo = double.Parse(Console.ReadLine());
                tiempoTot = tiempoTot + tiempo;
                tiempoProm = tiempoTot / atletas;
                if (tiempo < tiempoMin)
                {
                    tiempoMin = tiempo;
                    apellidoMin = apellido;
                }
                if (tiempo > tiempoMax)
                {
                    tiempoMax = tiempo;
                    apellidoMax = apellido;
                }
                if (edad >= 12 && edad<=18)
                {
                    cadetes += 1;
                    tiempoCad = tiempoCad + tiempo;
                    tPromCad = tiempoCad / cadetes;
                }
                if (edad >=19 && edad <= 30)
                {
                    juveniles += 1;
                    tiempoJuv = tiempoJuv + tiempo;
                    tPromJuv = tiempoJuv / juveniles;
                }
                if (edad > 30)
                {
                    veteranos += 1;
                    tiempoVet = tiempoVet + tiempo;
                    tPromVet = tiempoVet / veteranos;
                }
            }
            porcC = (cadetes * 100) / atletas;
            porcJ = (juveniles * 100) / atletas;
            porcV = (veteranos * 100) / atletas;
            Console.WriteLine("Tiempos Por Categorias");
            Console.WriteLine("Cadetes: {0}, Juveniles: {1}, Veteranos: {2}", tPromCad, tPromJuv, tPromVet);
            Console.WriteLine("Cantidad de catetes: {0}, cantidad de juveniles {1}, cantidad de veteranos {2}", cadetes, juveniles, veteranos);
            Console.WriteLine("El tiempo promedio de la competencia es {0}", tiempoProm);
            Console.WriteLine("Porcenaje de cadetes {0}, porcentaje de juveniles {1}, porcentaje de veteranos {2}", porcC,porcJ,porcV);
            Console.WriteLine("El ganador de la competencia fue: {0} con {1}\nEl perdedor fue: {2} con {3}", apellidoMin, tiempoMin, apellidoMax, tiempoMax);
            Console.ReadKey();
        }
    }   
}
