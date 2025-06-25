using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Semana14BCClass2ejer1;


namespace Semana14ConsoleClass2Ejer1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Intercambiar inter = new Intercambiar();

            Console.WriteLine("Ingrese una palabra:");
            string palabra = Console.ReadLine();
            string resultado = inter.IntercambiarCaracter(palabra);
            Console.WriteLine("Palabra modificada: " + resultado);
        }
    }
}
