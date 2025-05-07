using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Ejer1Semana7
{
    internal class Program
    {
       //Un programa que genere un número aleatorio menor a 10 (que no lo muestre) hasta que el usuario
       //intente adivinarlo(indicando si el numero ingresado es mayor o menor al generado), enviar un mensaje,
       //cuando acierte en texto color verde, el fondo cambie de color y se emitia un sonido


        static void Main(string[] args)
        {
            int numero = 0;

            //generar numeros aleatorios
            Random r = new Random(); //declarar una variable r 
            int numeroAleatorio = r.Next(1,10); ;//almacena numero entre 1-10
            //Console.WriteLine("numero generado" +" : "+numeroAleatorio);
            int dificultad = 0;
            Console.Write("Selecione dificultad" + " " + "1 Facil" + " "+" 2 Dificil");
            dificultad= Convert.ToInt32(Console.ReadLine());


            if (dificultad == 1)
            {
                Console.WriteLine("Dificultad facill");
            }
            else
            {
                if (dificultad == 2)
                {
                    Console.WriteLine("Dificil");
                }
            }





            //int intentos = 1;

            //do
            //{
            //    Console.WriteLine("intente adivinar el numero");
            //    numero = Convert.ToInt32(Console.ReadLine());
            //    if (numero == numeroAleatorio)
            //    {
            //        Console.ForegroundColor = ConsoleColor.Green;
            //        Console.BackgroundColor = ConsoleColor.Yellow;
            //        Console.Beep(900, 500);
            //        Console.WriteLine("Adivinaste");
            //        Console.ForegroundColor = ConsoleColor.White;
            //        Console.BackgroundColor = ConsoleColor.Black;

            //    }
            //    else
            //    {
            //        intentos++;
            //        if (numeroAleatorio > numero)
            //        {
            //            Console.WriteLine("El numero es mayor");
            //        }
            //        else
            //        {
            //            if (numeroAleatorio < numero)
            //            {
            //                Console.WriteLine("el numero es menor");
            //            }
            //        }
            //    }
            //}
            //while (numeroAleatorio != numero && intentos <= 4);

            //Console.WriteLine("perdiste");
            //Console.WriteLine("numero generado era" + " : " + numeroAleatorio);
        }
    }
}
