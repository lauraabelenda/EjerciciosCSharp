using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDDR
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Pedir dos números al usuario por teclado y decir que número es el mayor.
             */

            Console.WriteLine("Introduce un número: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce otro número: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            if (numero1 > numero2){
                Console.WriteLine(numero1 + " es mayor que " + numero2);
            }else{
                Console.WriteLine(numero1 + " es menor que " + numero2);
            }
            Console.ReadKey();


            
        }
    }
}
