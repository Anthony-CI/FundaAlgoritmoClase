using Semana15BCEjer1Class1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana15ConsoleEjer1Class1
{
    class Program
    {
        static void Main(string[] args)
        {

            int cantidad = 100;
            Console.WriteLine("Ingrese cantidad de alumnos");
            cantidad = int.Parse(Console.ReadLine());

            Notas nT= new Notas(cantidad);
            Console.Clear();
            nT.CargarNotasT1();
            Console.Clear();
            nT.CargarNotasT2();
            Console.Clear();
            nT.CargarNotasT3();
            Console.Clear();
            nT.CargarNotasEF();
            Console.Clear();
            nT.MostrarNotas();
        }
    }
}
