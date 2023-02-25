using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Dolares
    {
        private double cantidad;
        public static double cotizRespectoDolar; //lo pongo public asi me deja llamarlo desde las otras clases
                                                //asumo que es para usar de referencia para las conversiones sino ni idea


        //constructores

        static Dolares()
        {
            Dolares.cotizRespectoDolar = 1;
        }
        
        private Dolares() : this(0)
        {

        }

        public Dolares(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Dolares(double cantidad, double cotizRespectoDolar) : this(cantidad)
        {
            Dolares.cotizRespectoDolar = cotizRespectoDolar;
        }

        //Metodos

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return Dolares.cotizRespectoDolar;
        }

        //Casteos

        public static explicit operator Euro(Dolares d)
        {
            double aux = d.GetCantidad();
            double result = aux / Euro.cotizRespectoDolar;
            Euro cantidadConvertida = new Euro(result);

            return cantidadConvertida;
        }

        public static explicit operator Pesos(Dolares d)
        {
            double aux = d.GetCantidad();
            double result = aux * Pesos.cotizRespectoDolar;
            //Console.WriteLine("Resultado vale..");
            Pesos cantidadConvertida = new Pesos(result);

            return cantidadConvertida;
        }

        public static implicit operator Dolares(double cant)
        {
            //asumo que este convertor implicito, crea un objeto Dolares y le asigna la cantidad? no se entiende
            //una pija la consigna...
            //ej: Dolares newCount = 350; 
            Dolares aux = new Dolares(cant);
            return aux;
        }

        //Sobrecarga de operadores, != , == , - , +

        //[acceso] static TipoRetorno operator nombreOperador (Tipo a[, Tipo b])

        //---------------------------Operador ==
        //---------------------------DOLAR/DOLAR
        public static bool operator == (Dolares d, Dolares d2)
        {
            bool ret;

            ret = false;
            if (d.GetCantidad() == d2.GetCantidad())
            {
                ret = true;
            }

            return ret;
        }

        public static bool operator != (Dolares d, Dolares d2)
        {
            return !(d == d2); //devuelve lo contrario al igual...
        }

        //---------------------------DOLAR/EURO
        public static bool operator == (Dolares d, Euro e)
        {
            bool ret;
            Dolares aux = (Dolares)e;

            ret = false;
            if (d.GetCantidad() == aux.GetCantidad())
            {
                ret = true;
            }

            return ret;
        }

        public static bool operator !=(Dolares d, Euro e)
        {
            return !(d == e); //devuelve lo contrario al igual...
        }


        //---------------------------DOLAR/PESOS
        public static bool operator == (Dolares d, Pesos p)
        {
            bool ret;
            Dolares aux = (Dolares)p;

            ret = false;
            if (d.GetCantidad() == aux.GetCantidad())
            {
                ret = true;
            }

            return ret;
        }

        public static bool operator != (Dolares d, Pesos p)
        {
            return !(d == p); //devuelve lo contrario al igual...
        }

        //--------------------------OPERADOR -
        //--------------------------DOLAR/EURO

        public static Dolares operator - (Dolares d, Euro e)
        {
            double resultado;
            Dolares aux = (Dolares)e;
            Dolares newDivisa;

            resultado = d.GetCantidad() - aux.GetCantidad();

            newDivisa = new Dolares(resultado);

            return newDivisa;
        }

        //--------------------------DOLAR/PESOS

        public static Dolares operator -(Dolares d, Pesos p)
        {
            double resultado;
            Dolares aux = (Dolares)p;
            Dolares newDivisa;

            resultado = d.GetCantidad() - aux.GetCantidad();

            newDivisa = new Dolares(resultado);

            return newDivisa;
        }

        //--------------------------OPERADOR +
        //--------------------------DOLAR/EURO

        public static Dolares operator +(Dolares d, Euro e)
        {
            double resultado;
            Dolares aux = (Dolares)e;
            Dolares newDivisa;

            resultado = d.GetCantidad() + aux.GetCantidad();

            newDivisa = new Dolares(resultado);

            return newDivisa;
        }

        //--------------------------DOLAR/PESOS

        public static Dolares operator +(Dolares d, Pesos p)
        {
            double resultado;
            Dolares aux = (Dolares)p;
            Dolares newDivisa;

            resultado = d.GetCantidad() + aux.GetCantidad();

            newDivisa = new Dolares(resultado);

            return newDivisa;
        }

    }
}
