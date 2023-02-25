using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_LAB2_Libros_Entidades
{
    public class Novela : Libro
    {
        private EGenero genero;

        public Novela(String titulo, Single precio, Autor autor, EGenero genero)
            :base(precio,titulo,autor)
        {
            this.genero = genero;
        }

        public static bool operator ==(Novela n1, Novela n2)
        {
            bool ret = false;
            if(!(n1 is null) && !(n2 is null))
            {
                if(n1 == ((Libro)n2) && n1.genero == n2.genero)
                {
                    ret = true;
                }
            }
            return ret;
        }

        public static bool operator !=(Novela n1, Novela n2)
        {
            return !(n1 == n2);
        }

        public static implicit operator Single(Novela n1)
        {
            if(!(n1 is null))
            {
                return n1.precio;
            }
            return Single.MinValue;
        }

        public override bool Equals(object obj)
        {
            bool ret = false;
            if(obj is Novela)
            {
                ret = (this == ((Novela)obj));                    
            }
            return ret;
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine($"Tipo Libro: {this.GetType().Name}\n{(String)this}\nGenero Novela: {Enum.GetName(this.genero)}");

            return str.ToString();
        }

    }
}
