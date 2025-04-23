using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Semana_Sintomas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 3; i++)
            {
                Console.Clear();
                Console.Beep(900, 2000);
                Console.WriteLine("hola mundo" + " "+ i);
                Thread.Sleep(1000);
            }

            Console.WriteLine("Sintomas de COVID");
            Console.WriteLine("Usted tiene fiebre (si/no)");
            string respuesta = Console.ReadLine();
            if (respuesta=="si")
            {
                
                Console.WriteLine("Usted tiene dolor de cabeza");
                string respuesta2 = Console.ReadLine();
                if (respuesta2=="si")
                {
                    Console.WriteLine("usted tiene hipogeusia");
                    String respuesta3 = Console.ReadLine();

                    if (respuesta3=="si")
                    {

                        Console.Beep(450, 1000);
                        Console.Beep(900, 2000);
                        Console.Beep(1000, 3000);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Usted tiene COVID");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Beep(900,2000);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Usted tiene infeccion estomacal");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Usted posiblemnte tenga gripe");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Posiblemente no tengas COVID");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
