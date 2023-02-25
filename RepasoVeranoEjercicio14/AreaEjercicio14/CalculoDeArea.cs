using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaEjercicio14
{
    public class CalculoDeArea
    {
        public static double CalcularCuadrado(double dato)
        {
            double ret;

            /*
             *  Lado * 4; 
             */

            ret = dato * 4;

            return ret;
        }

        //---------------------------------------------------

        public static double CalcularTriangulo(double basee , double altura)
        {
            double ret;

            /*
             *  Base * altura / 2
             */

            ret = (basee * altura) / 2;

            return ret;
        }

        //---------------------------------------------------

        public static double CalcularCirculo(double radio)
        {
            double ret;

            /*
             * (Pi * radio) / 2
             */

            ret = Math.Pow((Math.PI * radio), 2);

            return ret;
        }
    }
}
