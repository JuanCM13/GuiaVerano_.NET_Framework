using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorTemperaturas
{
    public class Fahrenheit
    {
        private double temperatura;

        //Constructores sobrecargados

        private Fahrenheit() : this(0)
        {

        }

        public Fahrenheit(double temperatura)
        {
            this.temperatura = temperatura;
        }

        //Metodos

        public double GetCantidad()
        {
            return this.temperatura;
        }

        //Conversiones

        public static implicit operator Fahrenheit(double temperatura)
        {
            Fahrenheit aux = new Fahrenheit(temperatura);

            return aux;
        }

        public static explicit operator Celsius(Fahrenheit f)
        {
            double resultado;
            Celsius aux;

            resultado = (f.GetCantidad() - 32) * (5 / (float)9);
            Console.WriteLine("El resultado ed la conversion dio: " + resultado);
            aux = resultado;

            return aux;
        }

        public static explicit operator Kelvin(Fahrenheit f)
        {
            double resultado;
            Kelvin aux;

            resultado = (f.GetCantidad() + 459.67) * (5 / (float)9);
            aux = resultado;

            return aux;
        }

        //Sobrecarga de operadores + - 

        //Operador -

        //[acceso] static TipoRetorno operator nombreOperador (Tipo a[, Tipo b])

        // f - c
        public static Fahrenheit operator -(Fahrenheit f, Celsius c)
        {
            double result;
            Fahrenheit aux = (Fahrenheit)c;

            result = f.GetCantidad() - aux.GetCantidad();
            aux = result;

            return aux;
        }

        // f - k
        public static Fahrenheit operator -(Fahrenheit f, Kelvin k)
        {
            double result;
            Fahrenheit aux = (Fahrenheit)k;

            result = f.GetCantidad() - aux.GetCantidad();
            aux = result;

            return aux;
        }


        //Operador +

        // f + c
        public static Fahrenheit operator +(Fahrenheit f, Celsius c)
        {
            double result;
            Fahrenheit aux = (Fahrenheit)c;

            result = f.GetCantidad() + aux.GetCantidad();
            aux = result;

            return aux;
        }

        // f + k
        public static Fahrenheit operator +(Fahrenheit f, Kelvin k)
        {
            double result;
            Fahrenheit aux = (Fahrenheit)k;

            result = f.GetCantidad() + aux.GetCantidad();
            aux = result;

            return aux;
        }

        //Operador == !=

        // f == f
        public static bool operator ==(Fahrenheit f, Fahrenheit f2)
        {
            bool result = false;

            if (Math.Round(f.GetCantidad()) == Math.Round(f2.GetCantidad()))
            {
                result = true;
            }

            return result;
        }

        // f != f
        public static bool operator !=(Fahrenheit f, Fahrenheit f2)
        {
            return !(f == f2);
        }

        // f == c

        public static bool operator ==(Fahrenheit f, Celsius c)
        {
            bool result = false;
            Fahrenheit aux = (Fahrenheit)c;

            if (Math.Round(f.GetCantidad()) == Math.Round(aux.GetCantidad()))
            {
                result = true;
            }

            return result;
        }

        // f != c
        public static bool operator !=(Fahrenheit f, Celsius c)
        {
            return !(f == c);
        }


        // f == k
        public static bool operator ==(Fahrenheit f, Kelvin k)
        {
            bool result = false;
            Fahrenheit aux = (Fahrenheit)k;

            if (Math.Round(f.GetCantidad()) == Math.Round(aux.GetCantidad()))
            {
                result = true;
            }

            return result;
        }

        // f != k
        public static bool operator !=(Fahrenheit f, Kelvin k)
        {
            return !(f == k);
        }
    }
}
