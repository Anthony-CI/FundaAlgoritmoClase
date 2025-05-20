using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana9Ejercicio1
{
    class Perimetros
    {
        public double PerimetroCuadrado(double lado)
        {
            return lado * 4;
        }

        public double PerimetroTriangulo(double lado1, double lado2, double lado3)
        {
            return lado1 + lado2 + lado3;
        }

        public double PerimetroCirculo(double radio)
        {
            return 2 * Math.PI * radio;
        }

        public double PerimetroTrapecio(double baseMayor, double baseMenor, double lado1, double lado2)
        {
            return baseMayor + baseMenor + lado1 + lado2;
        }

        public double PerimetroRombo(double lado)
        {
            return lado * 4;
        }

        public void PerimetroRectangulo(double baseR, double altura, ref double r)
        {
            // El ref se usa para que el resultado se almacene en la variable r
            r = (baseR+altura) * 2;
        }
    }
}
