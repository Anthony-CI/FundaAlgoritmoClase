using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Semana12BCCEjer1Class2;

namespace Semana12ConsoleEjer1Class2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mascota mas= new Mascota();

            mas.Mostrar();
            Console.ReadKey();
            Console.WriteLine("*********");
            mas.Ordenar();
            mas.Mostrar();

            Console.WriteLine("**************");
            string ejemplo = "queso";
            Console.WriteLine(ejemplo[0]);

            Console.WriteLine("******************");
            mas.MostrarMascota();
            Console.ReadKey();
            Console.WriteLine("*********");
            mas.OrdenarMascota();
            mas.MostrarMascota();

            Console.WriteLine("*********************");
            Console.WriteLine("Ingrese nombre de la mascota a eliminar");
            string nombre =Console.ReadLine();
            mas.ElimnarMascota(nombre);
            Console.WriteLine("******************************");
            mas.MostrarMascota();



        }
    }
}
