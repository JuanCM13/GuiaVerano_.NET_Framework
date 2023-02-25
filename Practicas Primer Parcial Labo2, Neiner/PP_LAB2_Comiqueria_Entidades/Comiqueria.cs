using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_LAB2_Comiqueria_Entidades
{
    public class Comiqueria
    {
        private List<Producto> productos;
        private List<Venta> ventas;

        public Producto this[Guid clave]
        {
            get
            {
                Producto aux = null;
                foreach(Producto p in this.productos)
                {
                    if(((Guid)p) == clave)
                    {
                        aux = p;
                        break;
                    }
                }
                return aux;
            }
        }

        public Comiqueria()
        {
            this.productos = new List<Producto>();
            this.ventas = new List<Venta>();
        }

        public static bool operator ==(Comiqueria com , Producto pro)
        {
            bool ret = false;
            if(!(com is null) && !(pro is null))
            {
                foreach(Producto item in com.productos)
                {
                    if(item.Descripcion == pro.Descripcion)
                    {
                        ret = true;
                        break;
                    }
                }
            }
            return ret;
        }

        public static bool operator !=(Comiqueria com, Producto pro)
        {
            return !(com == pro);
        }

        public static Comiqueria operator +(Comiqueria com, Producto pro)
        {
            if (!(com is null) && !(pro is null))
            {
                if(com != pro)
                {
                    com.productos.Add(pro);
                }
            }
            return com;
        }

        public void Vender(Producto p , Int32 cantidad)
        {
            if(!(p is null))
            {
                this.ventas.Add(new Venta(p, cantidad));
            }
        }

        public void Vender(Producto p)
        {
            this.Vender(p, 1);
        }

        public String ListarVentas()
        {
            StringBuilder str = new StringBuilder();

            if(this.ventas.Count > 0)
            {
                this.ventas.Sort(Venta.SortVentasDate);
                foreach(Venta item in this.ventas)
                {
                    str.AppendLine("-------------------------------");
                    str.Append(item.ObtenerDescripcionBreve());
                    str.AppendLine("-------------------------------");
                }
            }
            else
            {
                str.AppendLine("Sin ventas al momento..");
            }
            return str.ToString();
        }

        public Dictionary<Guid,String> ListarProductos()
        {
            Dictionary<Guid, String> retorno = new Dictionary<Guid, string>();

            foreach(Producto item in this.productos)
            {
                retorno.Add(((Guid)item), item.Descripcion);
            }

            return retorno;
        }
    }
}
