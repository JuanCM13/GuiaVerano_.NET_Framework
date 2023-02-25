using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Camion : AutoMovil //VehiculoTerrestre
    {
        /*Trate de ahorrar algo de codigo y herede camion de auto ya que nomas se diferencian del peso de carga y la cantidad de pasajeros
            pero creo que esta mal, o no es lo mejor a hacer, onda tengo que ignorar aca el atributo que hereda "cantidadPasajeros" y en el
            constructor hardcodearlo a 0.. por esto no creo que sea lo mas eficiente, pero asi no repito codigo....*/
       
        private int pesoCarga;

        public int PesoCarga
        {
            get { return this.pesoCarga; }
            private set { this.pesoCarga = value; }
        }

        public Camion(Colores color, short cantRuedas, short cantPuertas, int pesoCarga, short cantidadMarchas) 
            :base(color, cantRuedas, cantPuertas , 0 , cantidadMarchas) 
        {
            this.PesoCarga = pesoCarga;
        }

        public string GetDataCamion()
        {
            StringBuilder auxS = new StringBuilder();

            auxS.AppendLine($"Vehiculo: Camion\n{this.MostrarDataVehiculoTerrestre()}\nCantidad Marchas: {this.CantidadMarchas}\nPeso que Soporta: {this.PesoCarga}");

            return auxS.ToString();
        }

        /*private int pesoCarga;
        private short cantidadMarchas;
        
        public int PesoCarga
        {
            get { return this.pesoCarga; }
            private set { this.pesoCarga = value; }
        }

        public short CantidadMarchas
        {
            get { return this.cantidadMarchas; }
            private set { this.pesoCarga = value; }
        }


        public Camion(Colores color, short cantRuedas, short cantPuertas, int pesoCarga , short cantidadMarchas)
            : base(color, cantRuedas, cantPuertas)
        {
            this.CantidadPasajerosAuto = cantidadPasajeros;
            this.CantidadMarchas = cantidadMarchas;
        }*/
    }
}
