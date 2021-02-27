using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Hacer un programa que le pida al usuario
un número y la computadora responda si
es par o impar. */

namespace Ejercicio_Uno
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int valorUsuario;

                Console.WriteLine("Ingresa un valor entero, por favor:");
                valorUsuario = Convert.ToInt32(Console.ReadLine());

                if (valorUsuario % 2 == 0)
                {
                    Console.WriteLine($"El valor {valorUsuario} ingresado es par.");
                }
                else
                {
                    Console.Write($"El valor {valorUsuario} ingresado es impar. ");
                }
            }
            
            catch(FormatException)
            {
                Console.WriteLine("No has ingresado un valor valido. Vuelve a intentarlo.");
            }

            Console.ReadKey();
        }
    }
}
