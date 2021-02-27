using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Hacer un programa que muestre la tabla
de multiplicar del 1 al 10 de cualquier
número.*/

namespace Tabla_Multiplicar
{
    class Program
    {
        static void Main(string[] args)
        {
            int dato;

            Console.WriteLine("Ingresa el numero de la tabla que desees consultar:");
            dato = int.Parse(Console.ReadLine());

            Console.Clear();

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(dato + "x" + i + "=" + (i * dato));
            }

            Console.ReadKey();
        }
    }
}

