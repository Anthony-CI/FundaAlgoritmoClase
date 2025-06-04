using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana11BCEjer1Clas2
{
    public class Asistencia
    {
        //string[] ListaAlumnos = new string[4];
        string[] ListaAlumnos = {"pepito Assencio","luis Herrera","carlos Reyes", "pepito Assencio" };

        public void MostrarAlumnos()
        {
            for (int i = 0; i < ListaAlumnos.Length; i++)
            {
                Console.WriteLine(ListaAlumnos[i]);
            }
        }

        public void BuscarAlumnos()
        {
            Console.WriteLine("Ingrese nombre a buscar");
            string nombreBuscado = Console.ReadLine();
            bool encontrado = false;
            for (int i = 0; i < ListaAlumnos.Length; i++)
            {
                if (nombreBuscado == ListaAlumnos[i])
                {
                    Console.WriteLine("Encontrado" + " " + "En la posicion:" + " "+ (i) + " " + ListaAlumnos[i]);
                    encontrado = true;

                }
            }
            if (encontrado== false) {
                Console.WriteLine("No encontrado " + nombreBuscado);
            }
           
        }

    }
}
