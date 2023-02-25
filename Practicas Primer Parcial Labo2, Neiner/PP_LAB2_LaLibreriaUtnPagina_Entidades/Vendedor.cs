using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_LAB2_LaLibreriaUtnPagina_Entidades
{
    public class Vendedor
    {
        private String nombre;
        private List<Publicacion> ventas;

        private Vendedor()
        {
            this.ventas = new List<Publicacion>();
        }

        public Vendedor(String nombre)
            :this()
        {
            this.nombre = nombre;
        }

        public static bool operator +(Vendedor ven , Publicacion pub)
        {
            bool ret = false;
            if(!(ven is null) && !(pub is null))
            {
                if(pub.HayStock)
                {
                    ven.ventas.Add(pub);
                    pub.Stock--;
                    ret = true;
                }
            }
            return ret;
        }

        public String ObtenerInformeDeVentas()
        {
            StringBuilder str = new StringBuilder();
            Double acum = 0;

            str.AppendLine(this.nombre);
            if(this.ventas.Count > 0)
            {
                foreach(Publicacion item in this.ventas)
                {
                    acum += item.Importe;
                    str.AppendLine("--------------------------------------------------------");
                    str.AppendLine($"Publicacion:");
                    str.AppendLine(item.ObtenerInformacio());
                    str.AppendLine("--------------------------------------------------------");
                }

                str.AppendLine($"Ganancia: {acum}");
            }
            else
            {
                str.AppendLine("Sin ventas por el momento..");
            }
            return str.ToString();
        }
    }
}
