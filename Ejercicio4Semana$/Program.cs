using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4Semana_
{
    class Program
    {
        static void Main(string[] args)
        {
            char caracter;

            Console.WriteLine("ingrese caracter");
            caracter = Console.ReadLine()[0];

            if (caracter == 's')
            {
               
                Console.WriteLine("soltero");

            }
            if (caracter == 'c')
            {

                Console.WriteLine("casado");

            }
            if (caracter == 'v')
            {

                Console.WriteLine("viudo");

            }
            if (caracter == 'd')
            {

                Console.WriteLine("divorsiado");

            }
            if (caracter !='s' && caracter != 'c' && caracter != 'v' && caracter != 'd')
            {
                Console.WriteLine("sin especificar");
            }


        }
    }
}
