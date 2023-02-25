using System;
using System.Text;

namespace PP_LAB2_Comiqueria_Entidades
{
    public abstract class Producto
    {
        private Guid codigo;
        private String descripcion;
        private Double precio;
        private Int32 stock;

        public String Descripcion
        {
            get { return this.descripcion; }
        }

        public Double Precio
        {
            get { return this.precio; }
        }

        public Int32 Stock
        {
            get { return this.stock; }
            set 
            {
                if(value > -1)
                {
                    this.stock = value;
                }                 
            }
        }

        protected Producto(String descr, Int32 stock, Double precio)
        {
            this.codigo = Guid.NewGuid();
            this.descripcion = descr;
            this.Stock = stock;
            this.precio = precio;
        }

        public static explicit operator Guid(Producto p)
        {
            return p.codigo;
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine($"Descripcion: {this.Descripcion}\nCodigo: {this.codigo}\nPrecio: {this.Precio}\nStock: {this.Stock}");

            return str.ToString();
        }


    }
}
