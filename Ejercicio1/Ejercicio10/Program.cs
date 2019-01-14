using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *  Recorre los números del 1 al 100. 
             *  Muestra los números pares o divisibles entre 3.
             */

            for (int i = 1; i <= 100; i++)
            {
                if (i%2 == 0 || i%3==0)
                {
                    Console.WriteLine(i);
                }

            }
            Console.ReadKey();
        }
    }
}
