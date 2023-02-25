using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneda
{
    public class Euro
    {
        private double cantidad;
        public static double cotizRespectoDolar;

        //constructores

        static Euro()
        {
            Euro.cotizRespectoDolar = 1.08;
        }
        private Euro() : this(0)
        {

        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, double cotizRespectoDolar) : this(cantidad)
        {
            Euro.cotizRespectoDolar = cotizRespectoDolar;
        }

        //Metodos

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return Euro.cotizRespectoDolar;
        }

        //Casteos

        public static explicit operator Dolares(Euro e)
        {
            double aux = e.GetCantidad();
            double result = aux * Euro.cotizRespectoDolar;
            Dolares cantidadConvertida = result;

            return cantidadConvertida;
        }

        public static explicit operator Pesos(Euro e)
        {
            Dolares aux = (Dolares)e;
            double enDolares = aux.GetCantidad();
            //Console.WriteLine("En dolares vale:" + enDolares);
            double resultado = enDolares * Pesos.cotizRespectoDolar;
            Pesos cantidadConvertida = resultado;
            /*
            double aux = e.GetCantidad(); 
            double auxEnDolares = aux * Euro.cotizRespectoDolar;
            double result = auxEnDolares * Pesos.cotizRespectoDolar;
            Pesos cantidadConvertida = new Pesos(result);
            */
            return cantidadConvertida;
        }

        public static implicit operator Euro(double cant)
        {
            //asumo que este convertor implicito, crea un objeto Dolares y le asigna la cantidad? no se entiende
            //una pija la consigna...
            //ej: Dolares newCount = 350; 
            Euro aux = new Euro(cant);
            return aux;
        }

        //Sobrecarga de operadores, != , == , - , +

        //[acceso] static TipoRetorno operator nombreOperador (Tipo a[, Tipo b])

        //---------------------------Operador ==
        //---------------------------EURO/EURO
        public static bool operator ==(Euro e, Euro e2)
        {
            bool ret;

            ret = false;
            if (e.GetCantidad() == e2.GetCantidad())
            {
                ret = true;
            }

            return ret;
        }

        public static bool operator !=(Euro e, Euro e2)
        {
            return !(e == e2); //devuelve lo contrario al igual...
        }

        //---------------------------EURO/DOLAR
        public static bool operator ==(Euro e, Dolares d)
        {
            bool ret;
            Euro aux = (Euro)d;

            ret = false;
            if (e.GetCantidad() == aux.GetCantidad())
            {
                ret = true;
            }

            return ret;
        }

        public static bool operator !=(Euro e, Dolares d)
        {
            return !(e == d); //devuelve lo contrario al igual...
        }


        //---------------------------EURO/PESOS
        public static bool operator ==(Euro e, Pesos p)
        {
            bool ret;
            Euro aux = (Euro)p;

            ret = false;
            if (e.GetCantidad() == aux.GetCantidad())
            {
                ret = true;
            }

            return ret;
        }

        public static bool operator !=(Euro e, Pesos p)
        {
            return !(e == p); //devuelve lo contrario al igual...
        }

        //--------------------------OPERADOR -
        //--------------------------EURO/DOLAR

        public static Euro operator -(Euro e, Dolares d)
        {
            double resultado;
            Euro aux = (Euro)d;
            Euro newDivisa;

            resultado = e.GetCantidad() - aux.GetCantidad();

            newDivisa = new Euro(resultado);

            return newDivisa;
        }

        //--------------------------EURO/PESOS

        public static Euro operator -(Euro e, Pesos p)
        {
            double resultado;
            Euro aux = (Euro)p;
            Euro newDivisa;

            resultado = e.GetCantidad() - aux.GetCantidad();

            newDivisa = new Euro(resultado);

            return newDivisa;
        }

        //--------------------------OPERADOR +
        //--------------------------EURO/DOLAR

        public static Euro operator +(Euro e, Dolares d)
        {
            double resultado;
            Euro aux = (Euro)d;
            Euro newDivisa;

            resultado = e.GetCantidad() + aux.GetCantidad();

            newDivisa = new Euro(resultado);

            return newDivisa;
        }

        //--------------------------EURO/PESOS

        public static Euro operator +(Euro e, Pesos p)
        {
            double resultado;
            Euro aux = (Euro)p;
            Euro newDivisa;

            resultado = e.GetCantidad() + aux.GetCantidad();

            newDivisa = new Euro(resultado);

            return newDivisa;
        }
    }
}
