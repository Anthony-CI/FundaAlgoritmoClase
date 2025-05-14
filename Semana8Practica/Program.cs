using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana8Practica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese sueldo");

        }

        static double  CalculandoSueldo(double sueldo)
        {


            if (sueldo <= 1500)
            {
                double porsentaje = (sueldo * 10) / 100;
                Console.WriteLine("el 10 % es:" + " " + porsentaje);
                double nuevoSueldo = sueldo - porsentaje;
                Console.WriteLine("El nuevo sueldo es:" + " " + nuevoSueldo);
                return nuevoSueldo;
            }
            else
            {
                if (sueldo > 1500 && sueldo <= 3000)
                {

                    double nuevoSueldo = sueldo - 1500;

                    double porcentaje = (nuevoSueldo * 5 / 100);

                    Console.WriteLine("el 5 % de impuesto a pgara es " + " " + porcentaje);

                    double nuevoSueldo1 = sueldo - porcentaje;

                    Console.WriteLine("El nuevo sueldo a pagar es:" + " " + nuevoSueldo1);



                }
                else
                {

                    if (sueldo > 3000)
                    {
                        double nuevoSueldo = sueldo - 3000;

                        double porcentaje = (nuevoSueldo * 3 / 100);

                        Console.WriteLine("el 3 % de impuesto a pgara es " + " " + porcentaje);

                        double nuevoSueldo1 = sueldo - porcentaje;

                        Console.WriteLine("El nuevo sueldo a pagar es:" + " " + nuevoSueldo1);

                    }


                }
            }


            return 0;
        }



    }
}
