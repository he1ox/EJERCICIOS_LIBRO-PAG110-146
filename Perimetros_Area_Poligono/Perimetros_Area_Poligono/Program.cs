using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* Hacer una programa que pueda calcular
el perímetro y el área de cualquier
polígono regular, pero que le pregunte al
usuario qué desea calcular.*/

namespace Perimetros_Area_Poligono
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte opcion;
            float length,ap;
            int n;


            //Siendo n el numero de lados del poligono. length la longitud de los lados. ap la apotema.


            Console.Write("Que desea calcular: \n1.Perimetro\n2.Area\nElije: ");

            opcion = sbyte.Parse(Console.ReadLine());

            Console.Clear();

            switch (opcion)
            {
                case 1:
                    Console.Write("PERIMETRO\nCuantos lados tiene el poligono?: ");
                    n = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Cual es el la longitud de cada lado (cada lado mide lo mismo): ");
                    length = float.Parse(Console.ReadLine());

                    Console.Clear();
                    Console.WriteLine($"El perimetro del poligono regular de {n} lados, con longitud de {length}, es de: {n*length}");

                    break;

                case 2:
                    Console.Write("AREA\nCuantos lados tiene el poligono?: ");
                    n = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Cual es el la longitud de cada lado (cada lado mide lo mismo): ");
                    length = float.Parse(Console.ReadLine());

                    Console.Write("Cual es el valor del apotema: ");
                    ap = float.Parse(Console.ReadLine());

                    Console.Write($"El area es: {(n*length*ap)/2}^2");


                    break;

                default:
                    Console.WriteLine("Valor no especificado.");
                    break;
            }

            Console.ReadKey();
        }
    }
}
