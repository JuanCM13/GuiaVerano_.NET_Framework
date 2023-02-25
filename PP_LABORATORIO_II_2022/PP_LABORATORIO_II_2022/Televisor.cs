using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_LABORATORIO_II_2022
{
    public class Televisor : Producto
    {
        public ETipo tipo;

        public Televisor(String modelo, String marca, EPais pais, ETipo tipo)
            : base(modelo, marca, pais)
        {
            this.tipo = tipo;
        }

        public static bool operator ==(Televisor t1, Televisor t2)
        {
            if (!(t1 is null) && !(t2 is null))
            {
                return t1.tipo == t2.tipo && t1 == ((Producto)t2);
            }
            return false;
        }

        public static bool operator !=(Televisor t1, Televisor t2)
        {
            return !(t1 == t2);
        }

        public static explicit operator Double(Televisor t)
        {
            if(!(t is null))
            {
                return t.Precio;
            }
            return -1;
        }

        public override bool Equals(object obj)
        {
            if(obj is Televisor)
            {
                return this == ((Televisor)obj);
            }
            return false;
        }

        public override string ToString()
        {
            return new StringBuilder().AppendLine((String)((Producto)this) + $"Tipo: {Enum.GetName(this.tipo)}").ToString();
        }
    }
}
