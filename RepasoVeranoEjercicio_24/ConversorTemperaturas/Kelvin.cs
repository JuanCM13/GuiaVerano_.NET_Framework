using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorTemperaturas
{
    public class Kelvin
    {
        private double temperatura;

        //Constructores

        private Kelvin() : this(0)
        {

        }

        public Kelvin(double temperatura)
        {
            this.temperatura = temperatura;
        }

        //Metodos

        public double GetCantidad()
        {
            return this.temperatura;
        }

        //Conversiones 

        public static implicit operator Kelvin(double temperatura)
        {
            Kelvin aux = new Kelvin(temperatura);

            return aux;
        }

        public static explicit operator Fahrenheit(Kelvin k)
        {
            double result;
            Fahrenheit aux;

            result = k.GetCantidad() * 9 / (float)5 - 459.67;
            //Console.WriteLine("Esta poronga tendria que dar 212.. da " +result);
            aux = result;

            return aux;
        }

        public static explicit operator Celsius(Kelvin k)
        {
            Fahrenheit aux = (Fahrenheit)k;
            Celsius result = (Celsius)aux;

            return result;
        }

        //Sobrecarga de operadores + - 

        //Operador -

        //[acceso] static TipoRetorno operator nombreOperador (Tipo a[, Tipo b])

        // k - f
        public static Kelvin operator -(Kelvin k, Fahrenheit f)
        {
            double result;
            Kelvin aux = (Kelvin)f;

            result = k.GetCantidad() - aux.GetCantidad();
            aux = result;

            return aux;
        }

        // k - c
        public static Kelvin operator -(Kelvin k, Celsius c)
        {
            double result;
            Kelvin aux = (Kelvin)c;

            result = k.GetCantidad() - aux.GetCantidad();
            aux = result;

            return aux;
        }

        //Operador +

        // k + f
        public static Kelvin operator +(Kelvin k, Fahrenheit f)
        {
            double result;
            Kelvin aux = (Kelvin)f;

            result = k.GetCantidad() + aux.GetCantidad();
            aux = result;

            return aux;
        }

        // k + c
        public static Kelvin operator +(Kelvin k, Celsius c)
        {
            double result;
            Kelvin aux = (Kelvin)c;

            result = k.GetCantidad() + aux.GetCantidad();
            aux = result;

            return aux;
        }


        //Operador == !=

        // k == k
        public static bool operator ==(Kelvin k, Kelvin k2)
        {
            bool result = false;

            if (Math.Round(k.GetCantidad()) == Math.Round(k2.GetCantidad()))
            {
                result = true;
            }

            return result;
        }


        // k != k
        public static bool operator !=(Kelvin k, Kelvin k2)
        {
            return !(k == k2);
        }


        // k == f
        public static bool operator ==(Kelvin k, Fahrenheit f)
        {
            bool result = false;
            Kelvin aux = (Kelvin)f;

            if (Math.Round(k.GetCantidad()) == Math.Round(aux.GetCantidad()))
            {
                result = true;
            }

            return result;
        }

        // k != f
        public static bool operator !=(Kelvin k, Fahrenheit f)
        {
            return !(k == f);
        }


        // k == c
        public static bool operator ==(Kelvin k, Celsius c)
        {
            bool result = false;
            Kelvin aux = (Kelvin)c;

            if (Math.Round(k.GetCantidad()) == Math.Round(aux.GetCantidad()))
            {
                result = true;
            }

            return result;
        }


        // k != c
        public static bool operator !=(Kelvin k, Celsius c)
        {
            return !(k == c);
        }
    }
}
