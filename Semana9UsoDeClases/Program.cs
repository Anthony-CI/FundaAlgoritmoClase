using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Semana9Ejercicio1;

namespace Semana9UsoDeClases
{
    class Program
    {
        static void Main(string[] args)
        {
            //Paso por valor 
            Areas a = new Areas();
            double r1 = a.AreaCirculo(10.5);
            Console.WriteLine("El area del circulo es: " + r1);
            double ar = a.AreaRectangulo(10.5, 10);
            Console.WriteLine("El area del rectangulo es: " + ar);

            Perimetros p = new Perimetros();

            //Paso por referencia 
            double Pre =0;
            p.PerimetroRectangulo(10, 20, ref Pre);
            Console.WriteLine("El perimetro del Rectangulo es: " + Pre);
        }
    }
}
