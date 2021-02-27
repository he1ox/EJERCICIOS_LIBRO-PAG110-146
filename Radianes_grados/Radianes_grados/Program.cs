using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Hacer un programa que transforme de
grados a radianes o de radianes a grados
dependiendo de lo que necesite el
usuario.*/

namespace Radianes_grados
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte eleccion;
            int dato_convertir;


            Console.Write("Selecciona una opcion\n\nConvertir:\n1.Grados->Radianes\n2.Radianes->Grados\n\nOpcion: ");
            eleccion = sbyte.Parse(Console.ReadLine());

            Console.Clear();

            switch (eleccion)
            {
                case 1:
                    Console.Write("Grados a Radianes.\nIngresa el valor en grados: ");
                    dato_convertir = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine($"Valor en radianes es de: {dato_convertir*(Math.PI/180)}");
                    break;
                case 2:
                    Console.Write("Radianes a grados.\nIngresa el valor en radianes: ");
                    dato_convertir = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine($"Valor en grados es de: {dato_convertir * (180/Math.PI)}");
                    break;
                default:
                    Console.WriteLine("No has ingresado un valor correcto.");
                    break;
            }
            Console.ReadKey();
        }
    }
}
