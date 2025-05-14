using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Semana8Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {

            //primera forma 
            factorial1();

            Console.WriteLine("*******************");
            //Segunda forma -> manioular el resultado devuleto por la funcion factorial2
            BigInteger resultado =factorial2();
            resultado = resultado / 2;
            Console.WriteLine("El factorial /2 es: " + resultado);

            Console.WriteLine("*******************");
            //Tercera forma -> pasar el resultado por valor
            int n;
            Console.WriteLine("Ingrese un numero: ");
            n = int.Parse(Console.ReadLine());
            factorial3(n);

            Console.WriteLine("*******************");

            //Cuarta forma -> pasar el resultado por valor
            int x;
            Console.WriteLine("Ingrese un numero: ");
            x = int.Parse(Console.ReadLine());
            BigInteger respuesta = factorial4(x);
            Console.WriteLine("El factorial es: " + respuesta);


        }

        static void factorial1()
        {
            int numero;
            Console.WriteLine("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());

            BigInteger factorial = 1;
            for (int i = 1; i <= numero; i++)
            {

                factorial *= i;
                //factorial= factorial*i;
            }
            Console.WriteLine("El factorial es " + factorial);
        }

        static BigInteger factorial2()
        {
            int numero;
            Console.WriteLine("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());

            BigInteger factorial = 1;
            for (int i = 1; i <= numero; i++)
            {

                //factorial *= i;
                factorial= factorial*i;
            }
            return factorial;
        }

        static void factorial3(int numero)
        {
            

            BigInteger factorial = 1;
            for (int i = 1; i <= numero; i++)
            {

                //factorial *= i;
                factorial = factorial * i;
            }
            Console.WriteLine("El factorial es " + factorial);
        }


        static BigInteger factorial4(int numero)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= numero; i++)
            {

                //factorial *= i;
                factorial = factorial * i;
            }
            return factorial;
        }

    }
}
