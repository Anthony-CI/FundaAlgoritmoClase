using Semana12Clas1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Semana12Clase1Ejer1Console
{
    class Program
    {
        static void Main(string[] args)
        {
            MetodosArreglos lista = new MetodosArreglos();

            Console.WriteLine("Cuantos nombres quiere ingresar");
            int cantidad = Convert.ToInt32(Console.ReadLine());
            lista.cantidad(cantidad);
            //lista.Insertar("Juan");
            //lista.Insertar("Maria");
            //lista.Insertar("Pedro");
            Console.WriteLine("*******************************************");
            lista.Mostrar();
            Console.ReadKey();
            Console.WriteLine("*******************************************");
            Console.WriteLine("Ingrese nombre a eliminar");
            string eliminarnombre=Console.ReadLine();
            lista.Eliminar(eliminarnombre);
            //lista.Eliminar("Juan");
            Console.WriteLine("*******************************************");
            lista.Mostrar();


        }
    }
}
