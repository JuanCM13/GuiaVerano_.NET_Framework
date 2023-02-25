using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local : Llamada
    {
        //fields
        private float costo;

        //props
        public float CostoLlamada
        {
            get { return this.CalcularCosto(); }
        }

        //Constr
        public Local(Llamada llamada, float costo) :this(llamada.NumOrigen ,  llamada.Duracion , llamada.NumDestino , costo)
        {
        }

        public Local(string origen, float duracion, string destino, float costo) : base(duracion , destino , origen)
        {
            this.costo = costo;
        }
        
        //meths
        private float CalcularCosto()
        {
            float auxCosto;

            auxCosto = this.Duracion * this.costo;

            return auxCosto;
        }

        public string MostrarDatos()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine($"{Llamada.MostrarDatos((Llamada)this)}");
            str.AppendLine($"Costo Llamada: {this.CostoLlamada}");

            return str.ToString();
        }

    }

}
