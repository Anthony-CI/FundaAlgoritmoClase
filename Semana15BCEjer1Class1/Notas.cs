using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Semana15BCEjer1Class1
{
    public class Notas
    {


        string[] nombres = new string[]
{
    "Ana", "Luis", "Carlos", "Marta", "Juan", "Pedro", "María", "José", "Laura", "Andrés",
    "Elena", "David", "Beatriz", "Francisco", "Lucía", "Fernando", "Carmen", "Manuel", "Paula", "Javier",
    "Sofía", "Rafael", "Cristina", "Miguel", "Teresa", "Antonio", "Adriana", "Raúl", "Isabel", "Sergio",
    "Sandra", "Alberto", "Patricia", "Ricardo", "Marcos", "Alicia", "Óscar", "Silvia", "Eduardo", "Rosa",
    "Víctor", "Nerea", "Ángel", "Raquel", "Diego", "Bea", "José Luis", "Begoña", "Eva", "Julio",
    "Carlos Alberto", "Susana", "César", "Violeta", "Pablo", "Celia", "Juan Carlos", "Ester", "Gonzalo", "Inés",
    "David Alejandro", "Claudia", "Fernando José", "Lidia", "Jaime", "Mercedes", "Ricardo José", "Martín", "Ingrid", "José Antonio",
    "Tania", "Samuel", "Lorena", "Miguel Ángel", "Juan Antonio", "Mónica", "Santiago", "Antonio José", "Irene", "Alicia María",
    "José Manuel", "Bárbara", "Francisco Javier", "Martín Antonio", "Germán", "Amparo", "Alba", "Teresa María", "Francisco José", "Beatriz María",
    "Gabriel", "Nicolás", "Ana María", "Marta Isabel", "Félix", "Ángela", "Jorge", "Isabel María", "Antonio Juan", "Salvador",
    "Carmen María", "Sonia", "Elena María", "Alfredo", "Cecilia", "Lorena María", "Enrique", "Patricia María", "Adrián", "Irene María",
    "Rocío", "Pedro José", "Miguel Ángel José", "Susana María", "Celia María", "Ricardo Javier", "Pablo José", "Esther", "César Augusto", "Julia",
    "Luis Miguel", "Alba María", "Guadalupe", "Álvaro", "Berta", "Josefa", "Antonio Miguel", "Ximena", "Raúl José", "José Enrique",
    "Andrea", "José Luis María", "Rita", "Vanessa", "Gema", "Patricia González", "Beatriz Isabel", "Oscar Luis", "María del Carmen", "Joaquín",
    "David Javier", "Alicia Isabel", "Ramón", "Antonio Jesús", "Valeria", "Víctor Manuel", "Carlos Javier", "María José", "Vicente", "Emma",
    "Juan José", "David José", "Helena", "Martín José", "Manuel José", "Marta María", "Antonio Francisco", "David Miguel", "Miriam", "Carolina",
    "Martín Javier", "Ángeles", "José Carlos", "Laura Isabel", "Carlos José", "Antonio Alberto", "Adriana María", "Eva María", "Alfonso", "Margarita",
    "Luis Carlos", "Sara", "Oscar", "Cristian", "Marta Teresa", "Antonio Jesús", "Ana Teresa", "Vicente José", "Montserrat", "Joaquín María",
    "Juan José María", "Manuel Antonio", "Cecilia María", "Adrián José", "María José Teresa", "José María", "Mercedes María", "José Javier", "María Dolores", "Beatriz Teresa",
    "Sandra María", "José Francisco", "Paola", "Javier Antonio", "Lourdes", "Alba Teresa", "Iris", "Cristina María", "Antonio Juan José", "Rosa María",
    "José Eduardo", "Paola María", "Simón", "Esteban", "Gabriela", "Rafael José", "Marina", "Sofia María", "Ismael", "Álvaro José",
    "Raúl Antonio", "Daniela", "Antonia", "Eduardo José", "Jorge Luis", "José Ángel", "María Elena", "Luz", "Felipe", "Pedro Antonio",
    "Eva Teresa", "Álex", "Tomás", "Héctor", "José Antonio María", "Araceli", "Eva Isabel", "David Jesús", "Montserrat María", "Ángela María",
    "Carlos Miguel", "Miriam María", "Mario", "Francisca", "Beatriz Teresa María", "Pedro José María", "Jorge Antonio", "Lorena Teresa", "Sonia María", "Rocío María",
    "Carlos Andrés", "Nina", "José David", "Ángel José", "Vicente Miguel", "Héctor Luis", "Emilia", "Alfredo José", "Isabel Teresa", "Encarna",
    "Antonio Manuel", "Laura Teresa", "Félix José", "Víctor Alberto", "Joaquín José", "María Luisa", "Carlos Fernando", "Santiago José", "Blanca", "David Alberto",
    "Manuel José María", "Carlos Antonio", "Nerea María", "Juan Pedro", "José Luis Antonio", "Silvia María", "Elisabeth", "Francisco Javier José", "Iñaki", "Antonio José María"
};



        int[,] notas;
        string[] lista_alumnos;

        public Notas(int n)
        {

            notas = new int[n, 4];
            lista_alumnos = new string[n];
            GenerarAllumnos();
        }


        public void GenerarAllumnos()
        {
            Random r = new Random();
            for (int i = 0; i < lista_alumnos.Length; i++)
            {
                int indice = r.Next(0,200);
                lista_alumnos[i] = nombres[indice];
            }
        }

        public void CargarNotasT1()
        {
            int col = 0;
            Random r= new Random();
            Console.WriteLine(":::::Registro de Notas T1:::::::::::::::::::");
            
            for (int i = 0; i < notas.GetLength(0); i++)
            {

                int nota = r.Next(0,21);
                Console.WriteLine(lista_alumnos[i]+ ": " + nota);

                notas[i, col] = nota;
                Thread.Sleep(1000);
                /*
                //Ingresar las notas manualmente
                Console.WriteLine(lista_alumnos[i] + ": ");
                int not= int.Parse(Console.ReadLine());
                notas[i,col] = not;
                */
            }

        }


        public void CargarNotasT2()
        {
            int col = 1;
            Random r = new Random();
            Console.WriteLine(":::::Registro de Notas T2:::::::::::::::::::");

            for (int i = 0; i < notas.GetLength(0); i++)
            {

                int nota = r.Next(0, 21);
                Console.WriteLine(lista_alumnos[i] + ": " + nota);

                notas[i, col] = nota;
                Thread.Sleep(1000);
            }

        }

        public void CargarNotasT3()
        {
            int col = 2;
            Random r = new Random();
            Console.WriteLine(":::::Registro de Notas T3:::::::::::::::::::");

            for (int i = 0; i < notas.GetLength(0); i++)
            {

                int nota = r.Next(0, 21);
                Console.WriteLine(lista_alumnos[i] + ": " + nota);

                notas[i, col] = nota;
                Thread.Sleep(1000);
            }

        }

        public void CargarNotasEF()
        {
            int col = 3;
            Random r = new Random();
            Console.WriteLine(":::::Registro de Notas EF:::::::::::::::::::");

            for (int i = 0; i < notas.GetLength(0); i++)
            {

                int nota = r.Next(0, 21);
                Console.WriteLine(lista_alumnos[i] + ": " + nota);

                notas[i, col] = nota;
                Thread.Sleep(1000);

            }

        }

        public void MostrarNotas()
        {
            // i = fila;
            // j=col;

            Console.WriteLine("\tT1\tT2\tT3\tEF\t");
            for (int i = 0; i < notas.GetLength(0); i++)
            {
                Console.Write(lista_alumnos[i] + "\t");
                //por cada fila
                for (int j = 0; j < notas.GetLength(1); j++)
                {
                    Console.Write(notas[i,j]+"\t");
                }
                Console.WriteLine();
            }



        }

    }
}
