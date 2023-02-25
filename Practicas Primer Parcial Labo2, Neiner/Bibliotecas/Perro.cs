using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotecas
{
    public class Perro : Mascota
    {
        private Int32 edad;
        private bool esAlfa;

        public Perro(String nombre, String raza)
            :this(nombre, raza , 0 , false)
        { }

        public Perro(String nombre, String raza, Int32 edad, bool esAlfa)
            :base(nombre, raza)
        {
            this.edad = edad;
            this.esAlfa = esAlfa;
        }

        public static explicit operator Int32(Perro p)
        {
            if(!(p is null))
            {
                return p.edad;
            }
            return Int32.MinValue;
        }

        public static bool operator ==(Perro p1, Perro p2)
        {
            bool ret = false;
            if(!(p1 is null) && !(p2 is null))
            {
                if(p1 == ((Mascota)p2) && ((Int32)p1) == ((Int32)p2))
                {
                    ret = true;
                }
            }
            return ret;
        }

        public static bool operator !=(Perro p1, Perro p2)
        {
            return !(p1 == p2);
        }

        public override string ToString()
        {
            return this.Fichas();
        }

        public override bool Equals(object obj)
        {
            bool ret = false;
            if(obj is Perro)
            {
                ret = (this == ((Perro)obj));
            }
            return ret;
        }

        protected override string Fichas()
        {
            StringBuilder str = new StringBuilder();

            str.Append($"{this.GetType().Name} - {base.DatosCompletos()},");
            if(this.esAlfa)
            {
                str.Append($" alfa de la manada, ");
            }
            str.AppendLine($" edad {this.edad}");

            return str.ToString();
        }

    }
}
