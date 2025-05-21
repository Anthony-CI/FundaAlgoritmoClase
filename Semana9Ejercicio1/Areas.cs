using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana9Ejercicio1
{
    public class Areas
    {

        public double AreaCirculo(double r) {
            
            double area;
            area = Math.PI * Math.Pow(r, 2);
            return area;
        }

        public double AreaTriangulo(double b, double h) {

            double area = (b * h) / 2;
            return area;
        }

        public double AreaRectangulo(double b, double h) {

            return b*h;
        }

    }
}
