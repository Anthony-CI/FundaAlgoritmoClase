using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana9Clas2BibliotecaClases
{
    public class Class1
    {
        public void SumarReferencia(double a, double b, ref double resultado)
        {
            resultado = a+b;
            
        }

        public void restarValor(double a, double b, out double respuesta)
        {
            respuesta = a - b;
        }
    }
}
