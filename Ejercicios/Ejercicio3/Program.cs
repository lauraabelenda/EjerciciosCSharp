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
             * Pedir por consola tu nombre y tu edad y mostrar el siguiente mensaje: 
             * “Te llamas ” <nombre> ” y tienes ” <años> ” años”
             */
            string nombre, edad;

            Console.WriteLine("Introduce tú nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Introduce tú nombre: ");
            edad = Console.ReadLine();

            int anos = Convert.ToInt32(edad);

            Console.WriteLine("Te llamas " + nombre + " y tienes " + anos + " años");
            Console.ReadKey();

        }
    }
}
