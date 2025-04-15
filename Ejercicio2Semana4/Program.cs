using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Semana4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            int p, s;
            Console.WriteLine("Ingrese el primer número:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número:");
            b = int.Parse(Console.ReadLine());
            /* Console.WriteLine("Ingrese el tercer número:");
             c = int.Parse(Console.ReadLine()); */

            if (a > b)
            {
                s = a;
                p = b;
            }
            else
            {
                s = b;
                p = a;
            }

            Console.WriteLine("orden " + p + " " +s);


        }
    }
}
    
           
