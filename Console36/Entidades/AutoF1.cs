using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AutoF1 :VehiculoCarrera
    {
        private short caballosFuerza;

        //props

        public short CaballoFuerza
        {
            get { return this.caballosFuerza; }
            set { this.caballosFuerza = value; }
        }

        //constructors
        public AutoF1(short numero, string escuderia) : base(numero , escuderia)
        {
        }

        public AutoF1(short numero, string escuderia, short cabFuerza) :this(numero , escuderia)
        {
            this.CaballoFuerza = cabFuerza;
        }

        //operator overload
        public static bool operator ==(AutoF1 a, AutoF1 b)
        {
            if (Object.ReferenceEquals(a, null) && Object.ReferenceEquals(b, null))
            {
                if (( (VehiculoCarrera) a == (VehiculoCarrera) b) && (a.CaballoFuerza == b.CaballoFuerza))
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(AutoF1 a, AutoF1 b)
        {
            return !(a == b);
        }

        //meths
        public string MostrarDatosAuto()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine($"Vehiculo: F1\n{this.MostrarDatos()}\nCaballos Fuerza: {this.CaballoFuerza}cv");

            return str.ToString();
        }

    }
}
