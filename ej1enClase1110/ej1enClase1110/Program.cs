using System;

namespace ej1enClase1110
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.Write("Ingresde primer número: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Ingresde segundo número: ");
            num2 = int.Parse(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine("Son IGUALES");
            }
            else
            {
                if (num1 > num2)
                {
                    Console.WriteLine("{0} es mayor a {1}", num1, num2);
                }
                else
                {
                    Console.WriteLine("{0} es menor a {1}", num1, num2);
                }


            }
            Console.ReadKey();
        }
    }
}
