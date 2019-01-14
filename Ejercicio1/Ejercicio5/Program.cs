using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Pedir el nombre de la semana al usuario y 
             * decirle si es fin de semana o no.  En caso de error, indicarlo.
             */
            Console.WriteLine("Escribe el día de la semana: ");
            string dia = Console.ReadLine();

            switch (dia)
            {
                case("lunes"):
                case("martes"):
                case("miercoles"):
                case("jueves"):
                case("viernes"):
                    Console.Write("No es fin de semana");
                    break;
                case ("sabado"):
                case ("domingo"):
                    Console.WriteLine("Es fin de semana");
                    break;

                default:
                    Console.WriteLine("Dia no correcto");
                    break;
            }

            Console.ReadLine();


        }
    }
}
