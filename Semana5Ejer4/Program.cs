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
            int suma = 0;
            for (int i =1; i <= n; i++) 
            {
                suma = suma +( i * i);
                Console.WriteLine(suma);
            }
        }
    }
}
