using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_LAB2_Libros_Entidades
{
    public class Manual : Libro
    {
        private ETipo tipo;

        public Manual(String titulo, String apellido, String nombre, Single precio, ETipo tipo)
            :base(titulo,apellido,nombre,precio)
        {
            this.tipo = tipo;
        }

        public static bool operator ==(Manual m1, Manual m2)
        {
            bool ret = false;
            if(!(m1 is null) && !(m2 is null))
            {
                if(m1 == ((Libro)m2) && m1.tipo == m2.tipo)
                {
                    ret = true;
                }
            }
            return ret;
        }

        public static bool operator !=(Manual m1, Manual m2)
        {
            return !(m1 == m2);
        }

        public static explicit operator Single(Manual m)
        {
            if(!(m is null))
            {
                return m.precio;
            }
            return Single.MinValue;
        }

        public override bool Equals(object obj)
        {
            bool ret = false;
            if(obj is Manual)
            {
                ret = (this == ((Manual)obj));
            }
            return ret;
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine($"Tipo Libro: {this.GetType().Name}\n{(String)this}\nTipo Manual: {Enum.GetName(this.tipo)}");

            return str.ToString();
        }
    }
}
