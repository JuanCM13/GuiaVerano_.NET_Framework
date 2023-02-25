using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class VehiculoTerrestre
    {
        private Colores color;
        private short cantRuedas;
        private short cantPuertas;

        public Colores Color
        {
            get { return this.color; }
        }

        public short CantidadRuedas
        {
            get { return this.cantRuedas; }
        }

        public short CantidadPuertas
        {
            get { return this.cantPuertas; }
        }

        public enum Colores { Rojo = 1 , Blanco , Azul , Gris , Negro}

        public VehiculoTerrestre(Colores color , short ruedas , short puertas)
        {
            this.color = color;
            this.cantRuedas = ruedas;
            this.cantPuertas = puertas;
        }

        internal string MostrarDataVehiculoTerrestre()
        {
            StringBuilder aux = new StringBuilder();

            aux.Append($"Color: {this.Color}\nCantidad Ruedas: {this.CantidadRuedas}\nCantidad Puertas: {this.CantidadPuertas}");

            return aux.ToString();
        }
        


    }
}
