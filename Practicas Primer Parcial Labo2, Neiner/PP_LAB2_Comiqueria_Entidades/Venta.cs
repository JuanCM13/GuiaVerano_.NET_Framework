using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_LAB2_Comiqueria_Entidades
{
    public sealed class Venta
    {
        private DateTime fecha;
        private static Int32 porcentajeIva;
        private Double precioFinal;
        private Producto producto;

        internal DateTime Fecha
        {
            get { return this.fecha; }
        }

        static Venta()
        {
            Venta.porcentajeIva = 21;
        }

        internal Venta(Producto producto, Int32 cantidad)
        {
            this.producto = producto;
            this.Vender(cantidad);
        }

        private void Vender(Int32 cantidad)
        {
            this.producto.Stock -= cantidad;
            this.fecha = DateTime.Now;
            Venta.CalcularPrecioFinal(producto.Precio, cantidad);
        }

        public static Double CalcularPrecioFinal(Double precioUnidad, Int32 cantidad)
        {
            Double aux = cantidad * precioUnidad;
            aux += ((aux * Venta.porcentajeIva) / 100);

            return aux;
        }

        public String ObtenerDescripcionBreve()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine($"{this.Fecha} -- {this.producto.Descripcion} -- {this.precioFinal.ToString("#.#,00")} ");

            return str.ToString();
        }

        public static Int32 SortVentasDate(Venta v1, Venta v2)
        {
            Int32 ret = 0;
            if(!(v1 is null) && !(v2 is null))
            {
                if(v1.Fecha < v2.Fecha)
                {
                    ret = 1;
                }
                else
                {
                    if (v1.Fecha > v2.Fecha)
                    {
                        ret = -1;
                    }
                }
            }
            return ret;
        }

    }
}
