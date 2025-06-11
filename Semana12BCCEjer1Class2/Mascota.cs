using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana12BCCEjer1Class2
{
    public class Mascota
    {
        int[] numero = { 91, 32, 23, 14, 1, 11, };
        string[] nombreMascota = { "pipo","dulce","cody","queso" };

        public void Mostrar()
        {
            for (int i = 0; i < numero.Length; i++)
            {
                Console.WriteLine(numero[i]);
            }
        }

        public void MostrarMascota()
        {
            for (int i = 0; i < nombreMascota.Length; i++) {
                Console.WriteLine(nombreMascota[i]);
            }
        }


        public void OrdenarMascota()
        {
            for (int i = 0; i < nombreMascota.Length; i++) {
                for (int j = 0; j < nombreMascota.Length - 1; j++) { 
                   string m1 = nombreMascota[j];
                   string m2 = nombreMascota[j+ 1];

                    if (m1[0] > m2[0])
                    {
                        string aux = nombreMascota[j];
                        nombreMascota[j] = nombreMascota[j + 1];
                        nombreMascota[j+1]= aux;
                    }

                }
            }
        }

        public void Ordenar()
        {
            for (int i = 0; i < numero.Length; i++)
            {
                for (int j = 0; j < numero.Length - 1; j++)
                {
                    if (numero[j] > numero[j + 1])
                    {
                        int axu = numero[j];
                        numero[j] = numero[j + 1];
                        numero[j + 1] = axu;
                    }
                }
            }

        }

        public void ElimnarMascota(string nombre)
        {
            for (int i = 0;i < nombreMascota.Length; i++)
            {
                if (nombre == nombreMascota[i])
                {
                    for(int j = i;j < nombreMascota.Length - 1; j++)
                    {
                        nombreMascota[j] = nombreMascota[j + 1];
                    }
                    Array.Resize(ref nombreMascota, nombreMascota.Length - 1);
                    //nombreMascota[nombreMascota.Length - 1] = "";
                    return;
                }

            }
            Console.WriteLine("Nombre no encoentrado");
        }
    }


}
