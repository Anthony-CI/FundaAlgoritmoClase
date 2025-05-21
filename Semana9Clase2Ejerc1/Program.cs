using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Semana9Clas2BibliotecaClases;

namespace Semana9Clase2Ejerc1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 nombre = new Class1();
            double resultado = 0;
            nombre.SumarReferencia(10,10,ref resultado);
            Console.WriteLine(resultado);
            double respuesta;
            nombre.restarValor(20,10, out respuesta);
            Console.WriteLine(respuesta);
            Calculadora cal = new Calculadora();
            cal.multiplicar(10,10);
        }
    }
}
