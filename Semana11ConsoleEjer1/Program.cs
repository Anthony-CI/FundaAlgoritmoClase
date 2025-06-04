using Semana11BCEjer1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Semana11ConsoleEjer1
{
    class Program
    {
        static void Main(string[] args)
        {
            Nota nta = new Nota();

            
            int op;

            Console.WriteLine("Ingrese cantidad de alumnos");
            int numero = int.Parse(Console.ReadLine());
            nta.CantidadAlumnos(numero);


            nta.CalificarT1();
            Thread.Sleep(500);
            nta.CalificarT2();
            Thread.Sleep(500);
            nta.CalificarT3();
            Thread.Sleep(500);
            nta.CalificarEF();
            Thread.Sleep(500);
            do
            {
                Console.WriteLine("Que nota desea ver");
                Console.WriteLine("{1} NotasT1 ||{2} NotasT2 ||{3} NotasT3 ||{4} NotasEF || {5} Promedio || {0} Salir");
                op = int.Parse(Console.ReadLine());
                nta.MostrarNotas(op);
                Console.ReadKey();
                Console.Clear();
            }
            while (op !=0);
            Console.WriteLine("Saliendo ....");




        }
    }
}
