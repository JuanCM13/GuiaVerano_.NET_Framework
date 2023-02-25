using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MotoCross : VehiculoCarrera
    {
        private short cilindrada;

        //prop
        public short Cilindrada
        {
            get { return this.cilindrada; }
            set { this.cilindrada = value; }
        }

        //construc
        public MotoCross(short numero, string escuderia) : base(numero, escuderia)
        {
        }

        public MotoCross(short numero, string escuderia, short cilindrada) : this(numero, escuderia)
        {
            this.Cilindrada = cilindrada;
        }

        //operator overload
        public static bool operator ==(MotoCross a, MotoCross b)
        {
            if (Object.ReferenceEquals(a, null) && Object.ReferenceEquals(b, null))
            {
                if (((VehiculoCarrera)a == (VehiculoCarrera)b) && (a.Cilindrada == b.Cilindrada))
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(MotoCross a, MotoCross b)
        {
            return !(a == b);
        }

        //meths
        public string MostrarDatosMoto()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine($"Vehiculo: Moto\n{this.MostrarDatos()}\nCilindrada: {this.Cilindrada}cc");

            return str.ToString();
        }
    }
}
