using System;
using System.Text;

namespace Entidades.Botellas
{
    public abstract class Botella
    {
        protected Int32 capacidad;
        protected Int32 contenido;
        protected String marca;
        protected Double precio;

        public abstract Double Ganancia { get; }

        public Double PorcentajeContenido 
        {
            get 
            {
                return (this.contenido * 100) / this.capacidad; 
            } 
        } 

        public Botella(String marca, Double precio)
            :this(marca,precio,1000)
        {
        }

        public Botella(String marca, Double precio, Int32 capacidad)
        {
            this.marca = marca;
            this.precio = precio;
            this.capacidad = capacidad;
            this.contenido = capacidad;
        }

        protected abstract void ServirMedida();

        private static String ObtenerDatosBotella(Botella b)
        {
            StringBuilder str = new StringBuilder();
            if(!(b is null))
            {
                str.AppendLine($"Marca: {b.marca}\nContenido: {b.contenido}\nCapacidad: {b.capacidad}\nPrecio: {b.Ganancia}");
            }
            return str.ToString();
        }

        public override string ToString()
        {
            return Botella.ObtenerDatosBotella(this);
        }

        public static explicit operator String(Botella b)
        {
            return b.marca;
        }

        public static bool operator ==(Botella b1, Botella b2)
        {
            bool ret = false;
            if(!(b1 is null) && !(b2 is null))
            {
                if(b1.marca == b2.marca && b1.capacidad == b2.capacidad)
                {
                    ret = true;
                }
            }
            return ret;
        }

        public static bool operator !=(Botella b1, Botella b2)
        {
            return !(b1 == b2);
        }

        public static Botella operator --(Botella b)
        {
            if(!(b is null))
            {
                b.ServirMedida();
            }
            return b;
        }
    }

}
