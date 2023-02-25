using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monedas
{
    public class Pesos
    {

        public double cantidad;
        public static double cotizRespectoDolar;

        //constructores

        static Pesos()
        {
            Pesos.cotizRespectoDolar = 66;
        }

        public Pesos() : this(0)
        {

        }

        public Pesos(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Pesos(double cantidad, double cotizRespectoDolar) : this(cantidad)
        {
            Pesos.cotizRespectoDolar = cotizRespectoDolar;
        }

        //Metodos

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return Pesos.cotizRespectoDolar;
        }

        public void setCotizacion(double cotizacion)
        {
            Pesos.cotizRespectoDolar = cotizacion;
        }

        //Casteos

        public static explicit operator Dolares(Pesos p)
        {
            double aux = p.GetCantidad();
            double result = aux / Pesos.cotizRespectoDolar;
            Dolares cantidadConvertida = result;

            return cantidadConvertida;
        }

        public static explicit operator Euro(Pesos p)
        {
            Dolares aux = (Dolares)p;
            double enDolares = aux.GetCantidad();
            double result = enDolares / Euro.GetCotizacion();
            Euro cantidadConvertida = result;

            /*double aux = p.GetCantidad();
            double auxEnDolares = aux * Pesos.cotizRespectoDolar;
            double result = auxEnDolares *  Euro.cotizRespectoDolar;
            Euro cantidadConvertida = new Euro(result);*/

            return cantidadConvertida;
        }

        public static implicit operator Pesos(double cant)
        {
            //asumo que este convertor implicito, crea un objeto Dolares y le asigna la cantidad? no se entiende
            //una pija la consigna...
            //ej: Dolares newCount = 350; 
            Pesos aux = new Pesos(cant);
            return aux;
        }

        //Sobrecarga de operadores, != , == , - , +

        //[acceso] static TipoRetorno operator nombreOperador (Tipo a[, Tipo b])

        //---------------------------Operador ==
        //---------------------------PESOS/PESOS
        public static bool operator ==(Pesos p, Pesos p2)
        {
            bool ret;

            ret = false;
            if (p.GetCantidad() == p2.GetCantidad())
            {
                ret = true;
            }

            return ret;
        }

        public static bool operator !=(Pesos p, Pesos p2)
        {
            return !(p == p2); //devuelve lo contrario al igual...
        }

        //---------------------------PESOS/EURO
        public static bool operator ==(Pesos p, Euro e)
        {
            bool ret;
            Pesos aux = (Pesos)e;

            ret = false;
            if (p.GetCantidad() == aux.GetCantidad())
            {
                ret = true;
            }

            return ret;
        }

        public static bool operator !=(Pesos p, Euro e)
        {
            return !(p == e); //devuelve lo contrario al igual...
        }

        //---------------------------PESOS/DOLAR
        public static bool operator ==(Pesos p, Dolares d)
        {
            bool ret;
            Pesos aux = (Pesos)d;

            Console.WriteLine($"La cantidad de pesos a dolar es de: {aux.GetCantidad()}");

            ret = false;
            if (p.GetCantidad() == aux.GetCantidad())
            {
                ret = true;
            }

            return ret;
        }

        public static bool operator !=(Pesos p, Dolares d)
        {
            return !(p == d); //devuelve lo contrario al igual...
        }

        //--------------------------OPERADOR -
        //--------------------------PESOS/EURO

        public static Pesos operator -(Pesos p, Euro e)
        {
            double resultado;
            Pesos aux = (Pesos)e;
            Pesos newDivisa;

            resultado = p.GetCantidad() - aux.GetCantidad();

            newDivisa = new Pesos(resultado);

            return newDivisa;
        }


        //--------------------------PESOS/DOLAR

        public static Pesos operator -(Pesos p, Dolares d)
        {
            double resultado;
            Pesos aux = (Pesos)d;
            Pesos newDivisa;

            resultado = p.GetCantidad() - aux.GetCantidad();

            newDivisa = new Pesos(resultado);

            return newDivisa;
        }


        //--------------------------OPERADOR +
        //--------------------------PESOS/EURO

        public static Pesos operator +(Pesos p, Euro e)
        {
            double resultado;
            Pesos aux = (Pesos)e;
            Pesos newDivisa;

            resultado = p.GetCantidad() + aux.GetCantidad();

            newDivisa = new Pesos(resultado);

            return newDivisa;
        }

        //--------------------------PESOS/DOLAR

        public static Pesos operator +(Pesos p, Dolares d)
        {
            double resultado;
            Pesos aux = (Pesos)d;
            Pesos newDivisa;

            resultado = p.GetCantidad() + aux.GetCantidad();

            newDivisa = new Pesos(resultado);

            return newDivisa;
        }
    }       
}
