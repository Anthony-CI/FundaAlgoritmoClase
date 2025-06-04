using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Semana11BCEjer1Clas2;

namespace Semana11CoEjer1Clas2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Asistencia a = new Asistencia();

            a.MostrarAlumnos();
            a.BuscarAlumnos();
        }
    }
}
