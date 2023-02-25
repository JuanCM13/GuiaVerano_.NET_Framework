using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_LAB2_LaLibreriaUtnPagina_Entidades
{
    public class Comic : Publicacion
    {
        private bool esColor;

        public Comic(String nombre, bool esColor, Int32 stock, Single precio)
            :base(nombre , stock , precio)
        {
            this.esColor = esColor;
        }

        protected override bool EsColor
        {
            get { return this.esColor; }
        }
    }
}
