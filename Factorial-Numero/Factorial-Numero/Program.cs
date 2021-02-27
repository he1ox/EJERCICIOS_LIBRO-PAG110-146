using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial_Numero
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, acum = 1;

            do
            {
                Console.Write("Ingrese un numero para calcular el factorial: ");
                num = Convert.ToInt32(Console.ReadLine());
            } while (num < 0 || num == 0);
            

            for(int i = 1; i <= num; i++)
            {
                acum *= i;
            }

            Console.WriteLine(acum);

            Console.ReadKey();
        }
    }
}
