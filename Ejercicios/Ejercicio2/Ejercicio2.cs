using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDDR
{
    class Ejercicio2
    {
        static void Main(string[] args)
        {
            /*
             * Pedir por consola un nombre de persona y 
             * el nombre de una ciudad (no hace falta que sean 
             * reales o comprobarlos) y mostrar por pantalla, el siguiente 
             * mensaje “Hola ” <nombre> ” bienvenido a ” <ciudad>
             */
            string nombre, ciudad;

            Console.WriteLine("Introduce tú nombre ");
            nombre = Console.ReadLine();
            Console.WriteLine("Introduce ciudad ");
            ciudad = Console.ReadLine();

            Console.WriteLine("Hola " + nombre + " bienvenido a " +  ciudad);
            Console.ReadKey();

        }
    }
}
