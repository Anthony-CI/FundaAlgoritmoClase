using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana5Ejer1
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
            estado_civil = Convert.ToChar(Console.ReadLine());

            if (estado_civil == 's' || estado_civil=='S')
            {
                Console.WriteLine("soltero");
            }
            else
            {
                if (estado_civil=='c')
                {
                    Console.WriteLine("Casado");
                }
                else
                {
                    if (estado_civil == 'v')
                    {
                        Console.WriteLine("Viudo");
                    }
                    else
                    {
                        if (estado_civil == 'd')
                        {
                            Console.WriteLine("Divorciado");
                        }
                        else
                        {
                            Console.WriteLine("Estado civil no valido");
                        }
                    }
                }

            }

            

        }
    }
}
