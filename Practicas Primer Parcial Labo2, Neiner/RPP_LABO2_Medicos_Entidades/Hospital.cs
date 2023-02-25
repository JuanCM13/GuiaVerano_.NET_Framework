using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPP_LABO2_Medicos_Entidades
{
    public class Hospital
    {
        private String nombre;
        private List<Personal> personal;

        private Hospital()
        {
            this.personal = new List<Personal>();
        }

        private Hospital(String nombre)
            :this()
        {
            this.nombre = nombre;
        }

        public Int32 CantidadPersonal
        {
            get { return this.personal.Count; }
        }

        public Personal this[Int32 i]
        {
            get 
            {
                if(i < 0 || i > this.CantidadPersonal -1)
                {
                    return null;
                }
                else
                {
                    return this.personal[i];
                }                
            }
        }

        public static implicit operator Hospital(String nombre)
        {
            return new Hospital(nombre);
        }

        public static Int32 operator |(Hospital h, Personal p)
        {
            Int32 ret = -1;
            Int32 i;
            if(!(h is null) && !(p is null))
            {
                i = 0;
                foreach (Personal item in h.personal)
                {
                    if(item == p)
                    {
                        ret = i;
                        break;
                    }
                    i++;
                }
            }
            return ret;
        }

        public static Hospital operator +(Hospital h, Personal p)
        {
            if((h | p ) == -1)
            {
                h.personal.Add(p);
            }
            return h;
        }

        public static Hospital operator -(Hospital h, Personal p)
        {
            Int32 index = (h | p);

            if(index > -1)
            {
                h.personal.RemoveAt(index);
            }
            return h;
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine($"Hospital: {this.nombre}\nCcantidad Personal: {this.CantidadPersonal}\n");
            if(this.CantidadPersonal > 0)
            {
                foreach(Personal p in this.personal)
                {
                    str.AppendLine(p.ToString());
                }
            }
            return str.ToString();
        }

    }
}
