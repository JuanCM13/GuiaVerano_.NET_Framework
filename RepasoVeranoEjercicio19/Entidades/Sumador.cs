using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Sumador
    {
        private int cantidadSumas;

        //Constructores sobrecargados

        public Sumador(int a)
        {
            this.cantidadSumas = a;
        }

        public Sumador() : this(0)
        {
            //asumo que aca dentro no va nada, lo llamo con los : desde afuera  :s
        }

        //metodos no sobrecargados

        public int getSumas()
        {
            return this.cantidadSumas;
        }


        //metodos sobrecargados

        public long Sumar(long operadorA , long operadorB)
        {
            this.cantidadSumas++;

            return operadorA + operadorB;
        }

        public string Sumar(string operadorA, string operadorB)
        {
            this.cantidadSumas++;
            string aux;

            aux = operadorA;
            aux += " " + operadorB;

            return aux;
        }

        //casteos funcionales sobrecargados , sobrecarga explicita de (int)

        public static explicit operator int (Sumador obj)
        {
            //return obj.cantidadSumas;
            return obj.getSumas(); //asi reutilizo codigo
        }

        //sobrecarga de operador, en este caso + y |

        /*[acceso] static TipoRetorno operator nombreOperador (Tipo a[, Tipo b])*/

        public static long operator + (Sumador a , Sumador b)
        {
            long opA;
            long opB;

            opA = (int)a; //reutilizo la conversion explicita que me devuelve el (int)
            opB = (int)b;   //al guardarlo en un long que es nmas grande que int, se hace la conversion implicita
                            //del compilador, que convierte ese int que me retorna (int) Sumador, a long...

            return opA + opB; //no reutilizo el metodo sumar(), sino me incrementaria la cantSumas y el ejercicio no lo pide
        }

        public static bool operator | (Sumador a , Sumador b)
        {
            bool ret = false;
            int opA = (int) a;
            int opB = (int)b; ;

            if (opA == opB)
            {
                ret = true;
            }

            return ret;
        }

    }
}
