using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraEjercicio15
{
    public class Calculador
    {
        public static float Calcular(float a, float b, char operando , out int retControl)
        {
            float ret = 0;
            retControl = 1; //si esta todo okey



            switch(operando)
            {
                case '+':
                    ret = a + b;
                break;
                case '-':
                    ret = a - b;
                break;
                case '*':
                    ret = a * b;
                break;
                case '/':

                    if(Validar(b))
                    {
                        ret = a / b;
                    }
                    else
                    {
                        retControl = -1; //no se puede dividir por cero..
                    }
                    
                break;
            } 

            return ret;
        }

        private static bool Validar(float b)
        {
            bool ret = false;

            if(b != 0)
            {
                ret = true;
            }

            return ret;
        }
    }
}
