﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Recorre los números del 1 al 100.
             * Muestra los números pares. Usar el tipo de bucle que quieras.
             */

            for (int i = 2; i <= 100; i+=2)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
