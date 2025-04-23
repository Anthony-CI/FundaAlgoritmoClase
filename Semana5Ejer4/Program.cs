using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana5Ejer4
{
    class Program
    {
        static void Main(string[] args)
        {

            int n;

            Console.WriteLine("Ingrese un numero");
            n = Convert.ToInt32(Console.ReadLine());
            int cuadrados=0;
            int suma = 0;
            for (int i =1; i <= n; i++) 
            {
                cuadrados = i * i;
                suma += cuadrados ;
                Console.WriteLine("Los cuadrados son " +" "+cuadrados);
            }
            Console.WriteLine("La suma es " + suma);
        }
    }
}
