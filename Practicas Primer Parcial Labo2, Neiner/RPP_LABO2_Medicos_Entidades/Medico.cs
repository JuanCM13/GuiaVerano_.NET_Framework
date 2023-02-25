using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPP_LABO2_Medicos_Entidades
{
    public class Medico : Personal
    {
        private Especialidad especialidad;

        public Medico(String apellido , Int32 legajo, DateTime ingreso, Especialidad espe)
            :base(apellido , legajo , ingreso)
        {
            this.especialidad = espe;
        }

        public Especialidad Especialidad
        {
            get { return this.especialidad; }
        }

        public override string Info
        {
            get { return this.ArmarInfo(); }
        }   

        protected override string ArmarInfo()
        {
            StringBuilder str = new StringBuilder();
            str.Append($"Doctor {base.ArmarInfo()}, Especialidad: {Enum.GetName(this.Especialidad)}");

            return str.ToString();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
