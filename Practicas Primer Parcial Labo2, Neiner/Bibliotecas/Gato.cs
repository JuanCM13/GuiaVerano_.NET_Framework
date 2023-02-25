using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotecas
{
    public class Gato : Mascota
    {
        public Gato(String nombre , String raza)
            :base(nombre , raza)
        {}

        public static bool operator ==(Gato g1, Gato g2)
        {
            bool ret = false;
            if(!(g1 is null) && !(g2 is null))
            {
                ret = (g1 == ((Mascota)g2));
            }
            return ret;
        }

        public static bool operator !=(Gato g1, Gato g2)
        {
            return !(g1 == g2);
        }

        public override string ToString()
        {
            return this.Fichas();
        }

        public override bool Equals(object obj)
        {
            bool ret = false;
            if(obj is Gato)
            {
                ret = (this == ((Gato)obj));
            }
            return ret;
        }

        protected override string Fichas()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine($"{this.GetType().Name} - {this.DatosCompletos()}");
            
            return str.ToString();
        }
    }
}
