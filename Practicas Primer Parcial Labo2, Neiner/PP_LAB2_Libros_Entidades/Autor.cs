using System;

namespace PP_LAB2_Libros_Entidades
{
    public class Autor
    {
        private String apellido;
        private String nombre;

        public Autor(String nom, String ape)
        {
            this.nombre = nom;
            this.apellido = ape;
        }

        public static explicit operator String(Autor a)
        {
            if(!(a is null))
            {
                return a.nombre + " - " + a.apellido;
            }
            return "";
        }

        public static bool operator ==(Autor a1 , Autor a2)
        {
            bool ret = false;
            if(!(a1 is null) && !(a2 is null))
            {
                if(a1.nombre == a2.nombre && a1.apellido == a2.apellido)
                {
                    ret = true;
                }
            }
            return ret;
        }

        public static bool operator !=(Autor a1, Autor a2)
        {
            return !(a1 == a2);
        }
    }
}
