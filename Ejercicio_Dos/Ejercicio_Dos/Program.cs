using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Hacer un programa que calcule el
resultado de un número elevado a
cualquier potencia.*/

namespace Ejercicio_Dos
{
    class Program
    {

        static void Main(string[] args)
        {
            int Base, Exponente;

            Console.WriteLine("Ingresa la base de la operacion: ");
            Base = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Ahora ingrese el exponente a elevarlo.");
            Exponente = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.WriteLine($"Base: {Base}, Exponente {Exponente}. -> {Base}^{Exponente}\nResultado: {Math.Pow(Base,Exponente)}");

            Console.ReadKey();
        }
    }
}
