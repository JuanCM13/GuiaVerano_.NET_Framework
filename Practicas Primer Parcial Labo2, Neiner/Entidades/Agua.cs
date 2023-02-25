using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Botellas
{
    public class Agua : Botella
    {
        public TipoAgua tipo;

        public override double Ganancia
        {
            get { return (this.precio + (this.precio * (float)0.25)); }
        }

        public Agua(String marca, Double precio, Int32 capacidad, TipoAgua tipo)
            : base(marca, precio, capacidad)
        {
            this.tipo = tipo;
        }

        public Agua(String marca, Double precio, TipoAgua tipo)
            : this(marca, precio, 500, tipo)
        { }

        protected override void ServirMedida()
        {
            this.contenido = 0;
        }

        public static bool operator ==(Agua a1, Agua a2)
        {
            bool ret = false;
            if (!(a1 is null) && !(a2 is null))
            {
                if (a1 == ((Botella)a2) && a1.tipo == a2.tipo)
                {
                    ret = true;
                }
            }
            return ret;
        }

        public static bool operator !=(Agua a1, Agua a2)
        {
            return !(a1 == a2);
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine($"{this.GetType().Name}\nTipo: {Enum.GetName(this.tipo)}\n{base.ToString()}\n");

            return str.ToString();
        }

        public override bool Equals(object obj)
        {
            bool ret = false;
            if(obj is Agua)
            {
                ret = this == ((Agua)obj);
            }
            return ret;
        }
    }
}
