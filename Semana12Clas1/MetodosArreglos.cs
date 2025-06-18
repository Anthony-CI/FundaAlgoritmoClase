using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana12Clas1
{
    public class MetodosArreglos
    {
        string[] listaAlumnos = new string[0];



        public void cantidad(int cantidad)
        {
            for (int i = 0; i < cantidad; i++) {
                Console.WriteLine("Ingrese Nombre");
                string nombre = Console.ReadLine();
                Insertar(nombre);
            }
        }

        //insertar

        public void Insertar(string nombre)
        {
            Array.Resize(ref listaAlumnos, listaAlumnos.Length + 1);
            int indice = listaAlumnos.Length - 1;
            listaAlumnos[indice] = nombre;
        }
        
        //Mostrar

        public void Mostrar()
        {
            foreach (string item in listaAlumnos)
            {
                Console.WriteLine(item);
            }
        }

        public void Eliminar(string nombreBuscar)
        {
            for (int i = 0; i < listaAlumnos.Length; i++)
            {
                if (listaAlumnos[i] == nombreBuscar)
                {
                    //busca la psocion del buscar
                    for (int j = i; j < listaAlumnos.Length - 1; j++)
                    {
                        listaAlumnos[j] = listaAlumnos[j + 1];
                    }
                    //Eliminar
                    Array.Resize(ref listaAlumnos, listaAlumnos.Length - 1);
                    return;
                }
            }
            Console.WriteLine("No se encontró el nombre a eliminar: " + nombreBuscar);

        }
    }
}
