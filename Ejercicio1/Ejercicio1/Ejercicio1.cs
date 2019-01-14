using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDDR
{
    class Ejercicio1
    {
        static void Main(string[] args)
        {

            /*
             * Crear 3 variables numéricas con el valor que 
             * tu quieras y en otra variable numérica guardar el valor de 
             * la suma de las 3 anteriores. Mostrar por consola. 
             * 
             */
            int i = 0;
            int x = 2;
            int z = 3;
            int resultado;

            resultado = i + x + z;
            Console.WriteLine("El resultado de la suma de es : {0} ", resultado);
            Console.ReadKey();

        }
    }
}
