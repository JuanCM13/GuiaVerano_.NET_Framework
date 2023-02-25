using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_LAB2_LaLibreriaUtnPagina_Entidades
{
    public class Biografia : Publicacion
    {
        public Biografia(String nombre)
            :base(nombre)
        {}

        public Biografia(String nombre,Int32 stock)
            :base(nombre,stock)
        {}

        public Biografia(String nombre, Int32 stock, Single valor)
            :base(nombre, stock,valor)
        {}

        protected override bool EsColor
        {
            get { return false; }
        }

        public override bool HayStock
        {
            get { return this.Stock > 0 ? true : false; }
        }

        public static explicit operator Biografia(String nombre)
        {
            return new Biografia(nombre);
        }
    }
}
