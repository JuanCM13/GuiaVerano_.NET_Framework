using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AutoMovil : VehiculoTerrestre
    {
        private short cantidadMarchas;
        private int cantidadPasajeros;

        public short CantidadMarchas
        {
            get { return this.cantidadMarchas; }
            private set { this.cantidadMarchas = value; }
        }

        /*Aca mande fruta con los modificadores de acceso, pero la idea es de como camion hereda de aca, para que por accidente el
            usuario no invoque la cantidad de pasajeros ya que en teoria el camion no tendria... igual si quiere ver los pasajeros del auto
            que llame al getDataAuto y que no rompa las bolas... ah*/
        internal int CantidadPasajerosAuto
        {
            get { return this.cantidadPasajeros; }
            private set { this.cantidadPasajeros = value; }
        }

        public AutoMovil(Colores color, short cantRuedas, short cantPuertas , int cantidadPasajeros , short cantidadMarchas) 
            : base(color,cantRuedas , cantPuertas)
        {
            this.CantidadPasajerosAuto = cantidadPasajeros;
            this.CantidadMarchas = cantidadMarchas;
        }

        public string GetDataAuto()
        {
            StringBuilder auxS = new StringBuilder();

            auxS.AppendLine($"Vehiculo: Auto\n{this.MostrarDataVehiculoTerrestre()}\nCantidad Pasajeros: {this.CantidadPasajerosAuto}\nCantidad Marchas: {this.CantidadMarchas}");

            return auxS.ToString();
        }

    }
}
