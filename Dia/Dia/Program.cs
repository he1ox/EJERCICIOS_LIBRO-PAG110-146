using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Hacer un programa que le pida al usuario
un número del 1 al 7 y escriba el nombre
del día que corresponde ese número en la
semana.*/

namespace Dia
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte dato;

            do
            {
                Console.Write("Ingresa un valor entre 1-7: ");
                dato = sbyte.Parse(Console.ReadLine());
            } while (dato > 7 || dato < 1);

            Console.Clear();

            switch (dato)
            {
                case 1:
                    Console.WriteLine($"{dato} corresponde al dia Lunes.");
                    break;
                case 2:
                    Console.WriteLine($"{dato} corresponde al dia Martes.");
                    break;
                case 3:
                    Console.WriteLine($"{dato} corresponde al dia Miercoles.");
                    break;
                case 4:
                    Console.WriteLine($"{dato} corresponde al dia Jueves.");
                    break;
                case 5:
                    Console.WriteLine($"{dato} corresponde al dia Viernes.");
                    break;
                case 6:
                    Console.WriteLine($"{dato} corresponde al dia Sabado.");
                    break;
                case 7:
                    Console.WriteLine($"{dato} corresponde al dia Domingo.");
                    break;
               
            }

            Console.ReadKey();
        }
    }
}
