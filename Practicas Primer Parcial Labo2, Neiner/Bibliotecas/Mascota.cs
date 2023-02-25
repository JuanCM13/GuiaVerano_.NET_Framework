using System;
using System.Text;

namespace Bibliotecas
{
    public abstract class Mascota
    {
        private String nombre;
        private String raza;

        public Mascota(String nombre, String raza)
        {
            this.nombre = nombre;
            this.raza = raza;
        }

        public String Nombre
        {
            get { return this.nombre; }
        }

        public String Raza
        {
            get { return this.raza; }
        }

        public static bool operator ==(Mascota m1, Mascota m2)
        {
            bool ret = false;
            if(!(m1 is null) && !(m2 is null))
            {
                if(m1.Nombre == m2.Nombre && m1.Raza == m2.Raza)
                {
                    ret = true;
                }
            }
            return ret;
        }

        public static bool operator !=(Mascota m1, Mascota m2)
        {
            return !(m1 == m2);
        }

        protected String DatosCompletos()
        {
            StringBuilder str = new StringBuilder();

            str.Append($"{this.Nombre} - {this.Raza}");

            return str.ToString();
        }

        protected abstract String Fichas();

    }
}
