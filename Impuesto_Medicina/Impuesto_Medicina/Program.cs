using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Hacer un programa que calcule el
impuesto de un producto, pero coloque
un impuesto del 0% si el producto es
medicina.*/

namespace Impuesto_Medicina
{
    class Program
    {
        static void Main(string[] args)
        {
            string tipo_producto;
            float total_pagar;

            Console.Write("Ingrese el valor del producto a cancelar (sin iva): ");
            total_pagar = float.Parse(Console.ReadLine());


            Console.Clear();

            Console.Write("Ingrese que tipo de producto es: ");
            tipo_producto = Console.ReadLine();

            tipo_producto = tipo_producto.ToLower();
            Console.Clear();

            if (tipo_producto == "medicina")
            {
                Console.WriteLine($"0% Impuestos. \nTotal a cancelar de: Q.{total_pagar}");
            }
            else
            {
                Console.WriteLine($"Precio sin iva Q.{total_pagar}\n12% IVA Q.{total_pagar * 0.12} \nTotal a cancelar es de: Q.{(total_pagar * 0.12) + (total_pagar)}");
            }


            Console.ReadKey();
        }
    }
}
