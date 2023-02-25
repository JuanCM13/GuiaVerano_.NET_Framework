using System;
using System.Text;

namespace RPP_LABO2_Medicos_Entidades
{
    public abstract class Personal
    {
        protected String apellido;
        protected DateTime horarioIngreso;
        protected Int32 legajo;

        public Personal(String apellido , Int32 legajo)
            :this(apellido , legajo, DateTime.Now)
        {}

        public Personal(String apellido, Int32 legajo, DateTime horario)
        {
            this.apellido = apellido;
            this.legajo = legajo;
            this.horarioIngreso = horario;
        }

        public String Apellido
        {
            get { return this.apellido; }
        }

        public abstract String Info{ get; }
    
        public DateTime Ingreso
        {
            get { return this.horarioIngreso; }
        }

        public Int32 Legajo
        {
            get { return this.legajo; }
        }

        protected virtual String ArmarInfo()
        {
            return (new StringBuilder().Append($"{this.Apellido} , Legajo: {this.Legajo}")).ToString();
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine($"{this.ArmarInfo()} - Ingreso: {this.Ingreso.ToLongTimeString()}");
            return str.ToString();
        }

        public static explicit operator String(Personal p)
        {
            return (p.Legajo).ToString();
        }

        public static bool operator ==(Personal p1, Personal p2)
        {
            bool ret = false;
            if(!(p1 is null) && !(p2 is null))
            {
                if(p1.Apellido == p2.Apellido && ((String)p1) == ((String)p2))
                {
                    ret = true;
                }
            }
            return ret;
        }

        public static bool operator !=(Personal p1, Personal p2)
        {
            return !(p1 == p2);
        }

        public static Int32 OrdenarPorLegajoASC(Personal p1, Personal p2)
        {
            Int32 ret = 0;
            if (!(p1 is null) && !(p2 is null))
            {
                ret = String.Compare(((String)p1), ((String)p2));
            }
            return ret;
        }

        public static Int32 OrdenarPorLegajoDESC(Personal p1, Personal p2)
        {
            return (-1) * (Personal.OrdenarPorLegajoASC(p1 , p2));
        }
    }
}
