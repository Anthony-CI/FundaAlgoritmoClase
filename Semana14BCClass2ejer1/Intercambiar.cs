using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana14BCClass2ejer1
{
    public  class Intercambiar
    {
        public string IntercambiarCaracter(string palabraOriginal)
        {
            char[] caracteres = palabraOriginal.ToLower().ToCharArray();

            for (int i = 0; i < caracteres.Length; i++)
            {
                if (caracteres[i] == 'a')
                {
                    caracteres[i] = 'e';
                }
            }
            string palabraModificada = new string(caracteres);
            return palabraModificada;
        }
    }
}
