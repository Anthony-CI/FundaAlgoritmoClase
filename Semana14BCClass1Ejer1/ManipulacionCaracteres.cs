using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana14BCClass1Ejer1
{
    public class ManipulacionCaracteres
    {
        public string Encriptar(string str, char llave)
        {
            string encriptado = "";

            for (int i = 0; i < str.Length; i++)
            {
                char L = (char)((int)str[i] + llave);
                encriptado += L;
            }
            return encriptado;
        }

        public string Desencriptar(string str, char llave)
        {
            string encriptado = "";

            for (int i = 0; i < str.Length; i++)
            {
                char L = (char)((int)str[i] - llave);
                encriptado += L;
            }
            return encriptado;
        }

        public string ContarVocales(string palabra)
        {
            int contador = 0;

            string vocal =palabra.ToLower();

            foreach (char c in vocal)
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    contador++;
                }
            }
           

            return "Total de vocales: " + contador;
        }

        public string Invertir(string str)
        {
            string invertido = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                invertido += str[i];
            }
            return invertido;

        }

        public string Palindromo(string str)
        {
            string invertida = Invertir(str);

            if (str.ToLower() == invertida.ToLower())
            {
                return "Palindromo";
            }
            else
            {
                return "No es un palindromo";
            }
        }
        

    }
}
