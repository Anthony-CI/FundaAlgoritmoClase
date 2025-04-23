using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_Ejer2
{
    class Program
    {
        static void Main(string[] args)
        {
            char estado_civil;
            Console.WriteLine("Ingresa estado");
            //el casteo es diferente al parseo
            //parseo -> convierte de un string a un int
            //casteo -> convierte de un doblea un int a nivel de numero
            estado_civil = Convert.ToChar(Console.ReadLine().ToLower());//combertir de mayusculas a minusculas
            switch (estado_civil)
            {
                case 's': //dos casos a la vez
                case 'S':
                    Console.WriteLine("soltero");
                    break;
                case 'c':
                case 'C':
                    Console.WriteLine("Casado");
                    break;
                case 'v':
                    Console.WriteLine("Viudo");
                    break;
                case 'd':
                    Console.WriteLine("Divorciado");
                    break;
                default:
                    Console.WriteLine("Estado civil no valido");
                    break;
            }
        }
    }
}
