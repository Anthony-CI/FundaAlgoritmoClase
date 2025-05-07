using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer2Semana7
{
    internal class Program
    {

        //Un cliente de banco realiza sucesivos retiros desde un cajero.Si posee 1.000 nuevos soles al inicio de
        //las operaciones, escriba un programa que le permita retirar dinero mientras tenga fondos.

        static void Main(string[] args)
        {
            int saldo = 1000, opcion;
            
            
            
            do
            {
                Console.Clear();
                Console.WriteLine("Tu saldo es " + ": " + saldo);
                Console.WriteLine("1 : Retirar dinero");
                Console.WriteLine("2 : salir");
                opcion= Convert.ToInt32(Console.ReadLine());

                if (opcion==1)
                {
                    int retiro = 0;
                        Console.WriteLine("Ingrese cantidad a retirar");
                        retiro = Convert.ToInt32(Console.ReadLine());
                    if (retiro<saldo)
                    {
                        saldo = saldo - retiro;
                        
                    }
                    else
                    {
                        Console.WriteLine("saldo insuficiente"); Console.ReadKey();
                    }


                        

                }
                else
                {
                    if (opcion==2)
                    {

                    }
                    else
                    {
                        Console.WriteLine("opcion no valida");
                    }
                }

            } while (opcion!=2);
        }
    }
}
