using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_LABORATORIO_II_2022
{
    public enum EGama { Baja , Media , Alta }
    public class Celular : Producto
    {
        public EGama gama;

        public Celular(String modelo, Fabricante fab, EGama gama)
            : base(modelo, fab)
        {
            this.gama = gama;
        }

        public static bool operator ==(Celular c1, Celular c2)
        {
            if(!(c1 is null) && !(c2 is null))
            {
                return c1.gama == c2.gama && c1 == ((Producto)c2);
            }
            return false;
        }

        public static bool operator !=(Celular c1, Celular c2)
        {
            return !(c1 == c2);
        }

        public static implicit operator Double(Celular c)
        {
            if(!(c is null))
            {
                return c.Precio;
            }
            return -1;
        }

        public override bool Equals(object obj)
        {
            if(obj is Celular)
            {
                return this == ((Celular)obj);
            }
            return false;
        }

        public override string ToString()
        {
            return new StringBuilder().AppendLine((String)((Producto)this) + $"Gama: {Enum.GetName(this.gama)}").ToString();
        }
    }
}
