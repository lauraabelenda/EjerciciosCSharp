using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *Pedir al usuario el precio de un producto
             * (valor positivo) y la forma de pagar (efectivo o tarjeta)
             * si la forma de pago es mediante tarjeta,
             * pedir el numero de cuenta (inventado)
             */


            Console.WriteLine("Introduce precio: ");
            decimal precio;
            precio = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Introduce forma de pago (efectivo o tarjeta): ");
            string pago = Console.ReadLine();

            if (pago == "tarjeta")
            {
                Console.WriteLine("Introduce el número de cuenta");
                int numeroC = Convert.ToInt32(Console.ReadLine());
                Console.Write("Pagado con tarjeta");
            } else if (pago.Equals("efectivo"))
            {
                Console.Write("Pagado con efectivo");
            }
            else
            {
                Console.Write("Método de pago incorrecto");
            }

            Console.ReadKey();

        }
    }
}
