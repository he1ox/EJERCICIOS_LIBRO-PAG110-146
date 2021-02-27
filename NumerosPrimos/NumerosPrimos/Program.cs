using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Hacer un programa que encuentre los
números primos que existen entre el 1 y
el 1000. */

namespace NumerosPrimos
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n = 2;
            
            int total = 1;

            
            while (total <= 1000)
            {

                bool Primo = true;

                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        Primo = false;
                        break;
                    }

                }

                if (Primo)
                {
                    Console.WriteLine(n);
                    total++;
                }
                
            }
            Console.ReadKey();
        }
    }
}
