using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola mundo"); //lee la linea
            int a, b, resultado;

            Console.Write("Ingrese primer valor");
            /*a = Convert.ToInt32(Console.ReadLine());*/  a= int.Parse(Console.ReadLine()); // una forma de convertir el valor
            Console.Write("Ingrese segundo numero");
            b = Convert.ToInt32(Console.ReadLine());
            resultado = a + b;
            Console.WriteLine("LAsuma es " + resultado);

            

            //Console.ReadKey(); //DEtiene el programa hasta que se presione una tecla
        }
    }
}
