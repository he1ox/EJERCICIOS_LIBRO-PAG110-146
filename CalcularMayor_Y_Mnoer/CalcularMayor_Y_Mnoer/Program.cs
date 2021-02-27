using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Hacer un programa que calcule el
promedio de edad de un grupo de
personas y diga cuál es la de edad más
grande y cuál es la más joven.*/


namespace CalcularMayor_Y_Mnoer
{
    class Program
    {
        static void Main(string[] args)
        {
            int nCantidad,edades,edad_mayor = 0, edad_menor = 0;



            Console.Write("Ingrese la cantidad del grupo de personas: ");
            nCantidad = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i< nCantidad; i++)
            {
                Console.Write($"Ingresa la edad {i}: ");
                edades = Convert.ToInt32(Console.ReadLine());
                if( i == 0 )
                {
                    edad_menor = edades;
                    edad_mayor = edades;
                }

                else if ( i != 0)
                {
                    if (edades < edad_menor)
                    {
                        edad_menor = edades;
                    }

                    if (edades > edad_mayor)
                    {
                        edad_mayor = edades;
                    }
                }
            }

            Console.Clear();

            Console.WriteLine($"La edad mayor es de: {edad_mayor}");
            Console.WriteLine($"La edad menor es de: {edad_menor}");

            Console.ReadKey();
        }
    }
}
