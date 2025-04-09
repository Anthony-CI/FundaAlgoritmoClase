using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        /* ULTIMO EJERCICIO DE LA PRACTICA*/
        static void Main(string[] args)
        {
            int a, b, c;
            double raizCuadrada;

            Console.WriteLine("Ingrese valor a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese valor b: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese valor c: ");
            c = int.Parse(Console.ReadLine());

            /* logica*/

            raizCuadrada = Math.Sqrt((b * b) - (4*(a * c)));

            Console.WriteLine("el resultado es " + raizCuadrada);

            /* Resultado*/


        }
    }
}
