using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, lim, i, aux;
            Console.WriteLine("Ingrese el número a calcular la sucesion Fibonacci: ");

            lim = int.Parse(Console.ReadLine());

            a = 0; b = 1;

            for (i = 0; i < lim; i++)
            {
                aux = a;
                a = b;
                b = aux + a;
                Console.WriteLine(a);
            }

            Console.ReadKey();
        }
    }
}
