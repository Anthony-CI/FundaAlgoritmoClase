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
            lista.Insertar("Juan");
            lista.Insertar("Maria");
            lista.Insertar("Pedro");
            lista.Mostrar();
            Console.ReadKey();
            Console.WriteLine("*******************************************");
            lista.Eliminar("Juan");
            lista.Mostrar();


        }
    }
}
