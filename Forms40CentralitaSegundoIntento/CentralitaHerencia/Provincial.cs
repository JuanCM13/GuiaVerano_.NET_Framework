using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Provincial :Llamada
    {
        //fields
        private Franja franjaHoraria;

        //props
        public override float CostoLlamada
        {
            get { return this.CalcularCosto(); }
        }

        //enum
        public enum Franja { Franja_1, Franja_2, Franja_3 }

        //Constr
        public Provincial(Franja franjaHs, Llamada llamada) : this(llamada.NumOrigen, franjaHs, llamada.Duracion, llamada.NumDestino)
        {
        }

        public Provincial(string origen, Franja franjaHs, float duracion, string destino) : base(duracion, destino, origen)
        {
            this.franjaHoraria = franjaHs;
        }

        //meths
        private float CalcularCosto()
        {
            float valor = 0;
            float costo;

            //no me tomaba el 0,99. Me rompe el intelicense, google y es por que los valores hardcodeados son usados como double o algo asi
            //va 0.99 es double (8bits) no float (4bits), O declaro el auxiliar double o le especifico el tipo con la F delante

            switch (this.franjaHoraria)
            {
                case Provincial.Franja.Franja_1:
                    valor = 0.99F;
                    break;
                case Provincial.Franja.Franja_2:
                    valor = 1.25F;
                    break;
                case Provincial.Franja.Franja_3:
                    valor = 0.66F;
                    break;
            }

            costo = this.Duracion * valor;

            return costo;
        }

        protected override string MostrarDatos()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine($"{base.MostrarDatos()}");
            str.AppendLine($"Costo Llamada: {this.CostoLlamada}\nFranjaHoraria: {this.franjaHoraria}");

            return str.ToString();
        }

        //methods overload
        public override bool Equals(object obj)
        {
            if (obj is Provincial)
            {
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            return this.MostrarDatos();
        }
    }
}
