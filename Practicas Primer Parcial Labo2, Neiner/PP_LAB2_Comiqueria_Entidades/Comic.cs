using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_LAB2_Comiqueria_Entidades
{
    public class Comic : Producto
    {
        private String autor;
        private TipoComic tipo;

        public Comic(String descripcion, Int32 stock, Double precio, String autor, TipoComic tipo)
            :base(descripcion, stock, precio)
        {
            this.autor = autor;
            this.tipo = tipo;
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine($"Comic:\n{base.ToString()}Tipo Comic: {Enum.GetName(this.tipo)}\nAutor: {this.autor}");

            return str.ToString();
        }
    }
}
