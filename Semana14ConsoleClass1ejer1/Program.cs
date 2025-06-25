using Semana14BCClass1Ejer1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Semana14ConsoleClass1ejer1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ManipulacionCaracteres mC = new ManipulacionCaracteres();
            /*
            char llave;
            Console.Write("Ingrese el texto a encriptar: ");
            string txttOriginal = Console.ReadLine();
            Console.WriteLine("Ingrese llave:  ");
            llave = char.Parse(Console.ReadLine());
            string txtEncriptado = mC.Encriptar(txttOriginal, llave);
            Console.WriteLine("Texto encriptado: " + txtEncriptado);
            
            Console.Write("Ingrese su llave:  ");
            llave = char.Parse(Console.ReadLine());
            Console.WriteLine("Texto original es " + mC.Desencriptar(txtEncriptado, llave));
            */

            Console.Write("Ingrese el texto a contar vocales: ");
            string texto = Console.ReadLine();
            string respuesta = mC.ContarVocales(texto);
            Console.WriteLine(respuesta);

            Console.Write("Ingrese el texto a invertir: ");
            string textoInvertir = Console.ReadLine();
            string textoInvertido = mC.Invertir(textoInvertir);
            Console.WriteLine("Texto invertido: " + textoInvertido);

            Console.Write("Ingrese el texto a verificar si es palindromo: ");
            string textoPalindromo = Console.ReadLine();
            string resultadoPalindromo = mC.Palindromo(textoPalindromo);
            Console.WriteLine(resultadoPalindromo);
        }
    }
}
