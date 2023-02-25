using System;
using System.Text;

namespace PP_LAB2_LaLibreriaUtnPagina_Entidades
{
    public abstract class Publicacion
    {
        protected Single importe;
        protected String nombre;
        protected Int32 stock;

        public Publicacion(String nombre, Int32 stock)
            :this(nombre)
        {
            this.stock = stock;
        }

        public Publicacion(String nombre)
        {
            this.nombre = nombre;
        }

        public Publicacion(String nombre, Int32 stock , Single importe)
            :this(nombre,stock)
        {
            this.importe = importe;
        }

        protected abstract bool EsColor
        {
            get;
        }

        public virtual bool HayStock
        {
            get 
            {
                if(this.Stock > 0 && this.Importe > 0)
                {
                    return true;
                }
                return false;
            }
        }

        public Single Importe
        {
            get { return this.importe; }
        }

        public Int32 Stock
        {
            get { return this.stock; }
            set { this.stock = value > 0 ? value : 0; }
        }

        public override string ToString()
        {
            return this.nombre;
        }

        public String ObtenerInformacio()
        {
            StringBuilder str = new StringBuilder();
            String aux = this.EsColor ? "Si" : "No";

            str.Append($"Nombre: {this.nombre}\n");
            str.AppendLine($"Stock: {this.Stock}");
            str.AppendFormat("Es Color: {0}\n", aux);
            str.AppendLine($"Importe: {this.Importe}");

            return str.ToString();
        }
    }
}
