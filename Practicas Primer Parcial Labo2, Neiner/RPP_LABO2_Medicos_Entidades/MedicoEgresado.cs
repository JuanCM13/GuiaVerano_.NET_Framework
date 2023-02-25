using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPP_LABO2_Medicos_Entidades
{
    public class MedicoEgresado : Medico
    {
        private DateTime horarioSalida;

        public MedicoEgresado(Medico medico)
            :base(medico.Apellido , medico.Legajo , medico.Ingreso , medico.Especialidad)
        {
            this.horarioSalida = DateTime.Now;
        }

        public DateTime Egreso
        {
            get { return this.horarioSalida; }
        }

        public override string Info
        {
            get { return this.ArmarInfo(); }
        }

        public Double Jornal
        {
            get { return this.CalcularJornal(); }
        }

        private Double CalcularJornal()
        {
            TimeSpan dif = (this.Egreso - this.Ingreso);
            Double precio = 0;
            switch(this.Especialidad)
            {
                case Especialidad.Cirujano:
                    precio = 90;
                    break;
                case Especialidad.Clinico:
                    precio = 70;
                    break;
                case Especialidad.Pediatra:
                    precio = 40;
                    break;
            }

             return (dif.TotalSeconds * precio);
        }

        protected override string ArmarInfo()
        {
            StringBuilder str = new StringBuilder();

            str.Append($"{base.ToString()} - JORNAL: ${this.Jornal.ToString("#,#.00")}");

            return str.ToString();
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine($"{base.ToString()} - Egreso: {this.Egreso.ToLongDateString()}");

            return str.ToString();
        }
    }
}
