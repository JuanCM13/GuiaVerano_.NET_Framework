using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto : VehiculoTerrestre
    {
        private short cilindrada;

        public short Cilindrada
        {
            get { return this.cilindrada; }
            private set { this.cilindrada = value; }
        }

        public Moto(Colores color, short cantRuedas, short cantPuertas, short cilindrada)
            : base(color , cantRuedas , cantPuertas) 
        {
            this.Cilindrada = cilindrada;
        }

        public string GetDataMoto()
        {
            StringBuilder auxS = new StringBuilder();

            auxS.AppendLine($"Vehiculo: Moto\n{this.MostrarDataVehiculoTerrestre()}\nCilindrada: {this.Cilindrada}cc");

            return auxS.ToString();
        }

    }
}
