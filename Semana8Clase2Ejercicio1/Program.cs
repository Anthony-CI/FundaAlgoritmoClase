using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Semana8Clase2Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animar();
        }

        static void Animar()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("░▒▓la calculadora iniciara en: ░▒▓");
            Console.Beep(600,700);
            Thread.Sleep(400);
            Console.Clear();
            Console.WriteLine("░▒▓3░▒▓");
            Console.Beep(600,700);
            Thread.Sleep(400);
            Console.Clear();
            Console.WriteLine("░▒▓2░▒▓");
            Console.Beep(600, 700);
            Thread.Sleep(400);
            Console.Clear();
            Console.WriteLine("░▒▓1░▒▓");
            Console.Beep(600, 700);
            Thread.Sleep(400);
            Console.Clear();
            Console.ResetColor();
            Calculadora();

        }

        static void Calculadora()
        {
            int opcion;
            do
            {
                Console.WriteLine(" 1 : Sumar");
                Console.WriteLine("2 : Restar");
                Console.WriteLine("3 : Multiplicar");
                Console.WriteLine("4 : Dividir");
                Console.WriteLine("0 : Salir");
                opcion=int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 0:  Console.WriteLine("Saliendo");
                        break;
                    case 1: //suma
                        Sumar();
                        break;

                    case 2: //resta
                        float r = Resta();
                        Console.WriteLine("la resta es :" + r);
                        break;

                    case 3://multiplicacion
                        Console.WriteLine("ingrese primer numero");
                        float n1 = float.Parse(Console.ReadLine());
                        Console.WriteLine("ingrese segundo numero");
                        float n2 = float.Parse(Console.ReadLine());
                        float rm = Multiplicar(n1,n2);
                        Console.WriteLine("La multiplicacion es: " + rm);

                        break;

                    case 4: //Divicion
                        break;

                    default:// opcion no valida
                        Console.WriteLine("Opcion no valida");
                        break;
                }
                Console.ReadKey();

            } while (opcion!=0);
        }

        static void Sumar()
        {
            Console.WriteLine("ingrese primer numero");
            float n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("ingrese segundo numero");
            float n2 = float.Parse(Console.ReadLine());

            float Sumar = n1 + n2;
            Console.WriteLine("La suma es :" + Sumar);
        }

        static float Resta()
        {
            Console.WriteLine("ingrese primer numero");
            float n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("ingrese segundo numero");
            float n2 = float.Parse(Console.ReadLine());
            float Restar = n1 - n2;
            return Restar;
        }

        static float Multiplicar(float x,float y)
        {
            float resultado = x * y;
            return resultado;
        }

    }
}
