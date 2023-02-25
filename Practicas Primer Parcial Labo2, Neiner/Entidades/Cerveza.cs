using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Botellas
{
    public class Cerveza : Botella
    {
        public Int32 medida;
        public TipoCerveza tipo;

        public override double Ganancia
        {
            get 
            {
                return ((this.precio / 3) + (this.precio / 2));
            }
        }

        public Cerveza(String marca, Double precio, Int32 capacidad, TipoCerveza tipo , Int32 medida)
            :base(marca,precio,capacidad)
        {
            this.tipo = tipo;
            this.medida = medida;
        }

        public Cerveza(String marca, Double precio, Int32 capacidad, TipoCerveza tipo)
            : this(marca, precio, capacidad, tipo, capacidad/3)
        {}

        protected override void ServirMedida()
        {
            this.contenido -= this.medida;
            if(this.contenido < this.medida)
            {
                this.contenido = 0;
            }
        }

        public static bool operator ==(Cerveza c1, Cerveza c2)
        {
            bool ret = false;
            if (!(c1 is null) && !(c2 is null))
            {
                if (c1 == ((Botella)c2) && c1.tipo == c2.tipo)
                {
                    ret = true;
                }
            }
            return ret;
        }

        public static bool operator !=(Cerveza c1, Cerveza c2)        
        {
            return !(c1 == c2);
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
            if(obj is Cerveza)
            {
                ret = (this == ((Cerveza)obj));
            }
            return ret;
        }

    }
}
