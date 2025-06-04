using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana11BCEjer1
{
    public class Nota
    {

        static int canAlun = 0;

        int[] notasT1 = new int[canAlun];
        int[] notasT2 = new int[canAlun];
        int[] notasT3 = new int[canAlun];
        int[] notasEF = new int[canAlun];



        public void CantidadAlumnos(int n)
        {
            canAlun = n;
            notasT1 = new int[n];
            notasT2 = new int[n];
            notasT3 = new int[n];
            notasEF = new int[n];
        }



        //T1
        public void CalificarT1()
        {
            Random rnd = new Random();
            for (int i = 0; i < notasT1.Length; i++)
            {
                notasT1[i] = rnd.Next(0, 21);
            }
        }

        private void MostrarT1()
        {
            for (int i = 0; i < notasT1.Length; i++)
            {
                Console.WriteLine(notasT1[i]);
            }
        }

        //T2
        public void CalificarT2()
        {
            Random rnd = new Random();
            for (int i = 0; i < notasT2.Length; i++)
            {
                notasT2[i] = rnd.Next(0, 21);
            }
        }

        private void MostrarT2()
        {
            for (int i = 0; i < notasT2.Length; i++)
            {
                Console.WriteLine(notasT2[i]);
            }
        }

        //T3
        public void CalificarT3()
        {
            Random rnd = new Random();
            for (int i = 0; i < notasT3.Length; i++)
            {
                notasT3[i] = rnd.Next(0, 21);
            }
        }

        private void MostrarT3()
        {
            for (int i = 0; i < notasT3.Length; i++)
            {
                Console.WriteLine(notasT3[i]);
            }
        }

        //EF
        public void CalificarEF()
        {
            Random rnd = new Random();
            for (int i = 0; i < notasEF.Length; i++)
            {
                notasEF[i] = rnd.Next(0, 21);
            }
        }

        private void MostrarEF()
        {
            for (int i = 0; i < notasEF.Length; i++)
            {
                Console.WriteLine(notasEF[i]);
            }
        }

        public void MostrarNotas(int n)
        {
            switch (n)
            {
                case 1:
                    Console.WriteLine("Notas de T1:");
                    MostrarT1();
                    break;
                case 2:
                    Console.WriteLine("Notas de T2:");
                    MostrarT2();
                    break;
                case 3:
                    Console.WriteLine("Notas de T3:");
                    MostrarT3();
                    break;
                case 4:
                    Console.WriteLine("Notas de EF:");
                    MostrarEF();
                    break;
                case 5:
                    
                    for (int i = 0; i < canAlun; i++)
                    {
                        double prom = (notasT1[i]+0.10)+ (notasT2[i] + 0.2) + (notasT2[i] + 0.3) + (notasEF[i] + 0.4);
                    Console.WriteLine($"Alumno {i + 1}: T1: {notasT1[i]}, T2: {notasT2[i]}, T3: {notasT3[i]}, EF: {notasEF[i]}, Promedio: {prom}");
                    }
                    
                    break;
                default:
                    break;
            }
        }
    }
}
