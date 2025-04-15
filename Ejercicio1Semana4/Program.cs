using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Semana4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.WriteLine("Ingrese el primer número:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número:");
            b = int.Parse(Console.ReadLine());
            if (a>b)
            {
                int cambio;

                cambio = a;
                a = b;
                b = cambio;
                
                Console.WriteLine("a es " + a);
                Console.WriteLine("b es " + b);
            }
        }
    }
}
