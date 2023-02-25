using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorTemperaturas
{
    public class Celsius
    {
        private double temperatura;

        //Constructores

        private Celsius() : this(0)
        {

        }

        public Celsius(double temperatura)
        {
            this.temperatura = temperatura;
        }

        //Metodos

        public double GetCantidad()
        {
            return this.temperatura;
        }

        //Conversiones 

        public static implicit operator Celsius(double temperatura)
        {
            Celsius aux = new Celsius(temperatura);

            return aux;
        }

        public static explicit operator Fahrenheit(Celsius c)
        {
            double resultado;
            Fahrenheit aux;

            resultado = c.GetCantidad() * (9 / (float)5) + 32;
            aux = resultado;

            return aux;
        }

        public static explicit operator Kelvin(Celsius c)
        {
            Fahrenheit aux = (Fahrenheit)c;
            Kelvin result = (Kelvin)aux;

            return result;
        }

        //Sobrecarga de operadores + - 

        //Operador -

        //[acceso] static TipoRetorno operator nombreOperador (Tipo a[, Tipo b])

        // c - f
        public static Celsius operator -(Celsius c, Fahrenheit f)
        {
            double result;
            Celsius aux = (Celsius)f;

            result = c.GetCantidad() - aux.GetCantidad();
            aux = result;

            return aux;
        }

        // c - k
        public static Celsius operator -(Celsius c, Kelvin k)
        {
            double result;
            Celsius aux = (Celsius)k;

            Console.WriteLine("Los grados Kelvin transformados a Cel dan: " + aux.GetCantidad());

            result = c.GetCantidad() - aux.GetCantidad();
            aux = result;

            return aux;
        }

        // c + f
        public static Celsius operator +(Celsius c, Fahrenheit f)
        {
            double result;
            Celsius aux = (Celsius)f;

            result = c.GetCantidad() + aux.GetCantidad();
            aux = result;

            return aux;
        }

        // c + k
        public static Celsius operator +(Celsius c, Kelvin k)
        {
            double result;
            Celsius aux = (Celsius)k;

            result = c.GetCantidad() + aux.GetCantidad();
            aux = result;

            return aux;
        }


        //Operador == !=

        // c == c
        public static bool operator ==(Celsius c, Celsius c2)
        {
            bool result = false;

            if (Math.Round(c.GetCantidad()) == Math.Round(c2.GetCantidad()))
            {
                result = true;
            }

            return result;
        }


        // c != c
        public static bool operator !=(Celsius c, Celsius c2)
        {
            return !(c == c2);
        }


        // c == f
        public static bool operator ==(Celsius c, Fahrenheit f)
        {
            bool result = false;
            Celsius aux = (Celsius)f;

            Console.WriteLine("Los Fahrenheit parseados dieron: " + Math.Round(aux.GetCantidad()));
            if (Math.Round(c.GetCantidad()) == Math.Round(aux.GetCantidad()))
            {
                result = true;
            }

            return result;
        }


        // c != f
        public static bool operator !=(Celsius c, Fahrenheit f)
        {
            return !(c == f);
        }


        // c == k
        public static bool operator ==(Celsius c, Kelvin k)
        {
            bool result = false;
            Celsius aux = (Celsius)k;
            Console.WriteLine($"Celsius: {Math.Round(c.GetCantidad())} Kelvin transformados{Math.Round(aux.GetCantidad())}");

            if (Math.Round(c.GetCantidad()) == Math.Round(aux.GetCantidad()))
            {
                result = true;
            }

            return result;
        }


        // c != k
        public static bool operator !=(Celsius c, Kelvin k)
        {
            return !(c == k);
        }
    }
}
