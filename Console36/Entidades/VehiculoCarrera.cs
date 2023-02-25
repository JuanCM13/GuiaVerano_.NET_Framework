using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class VehiculoCarrera
    {
        //fields
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        //props
        public short CantidadCombustible
        {
            get { return this.cantidadCombustible; }
            set { this.cantidadCombustible = value; }
        }

        public bool EnCompetencia
        {
            get { return this.enCompetencia; }
            set { this.enCompetencia = value; }
        }

        public string Escuderia
        {
            get { return this.escuderia; }
            set { this.escuderia = value; }
        }

        public short Numero
        {
            get { return this.numero; }
            set { this.numero = value; }
        }

        public short VueltasRestantes
        {
            get { return this.vueltasRestantes; }
            set { this.vueltasRestantes = value; }
        }

        //Constructors
        public VehiculoCarrera(short numero, string escuderia)
        {
            this.Numero = numero;
            this.Escuderia = escuderia;
        }

        //methods
        public string MostrarDatos()
        {
            StringBuilder aux = new StringBuilder();

            aux.Append($"Cantidad Combustible: {this.CantidadCombustible}\nEstado Competencia: {this.EnCompetencia}\nEscuderia: {this.Escuderia}");
            aux.Append($"\nNumero: {this.Numero}\nVueltas Restantes: {this.VueltasRestantes}");

            return aux.ToString();
        }

        //Operators Overload
        public static bool operator ==(VehiculoCarrera vUno , VehiculoCarrera vDos)
        {
            if(Object.ReferenceEquals(vUno , null) == false && Object.ReferenceEquals(vDos , null) == false)
            {
                if( (vUno.Numero == vDos.Numero) && (vUno.Escuderia == vDos.Escuderia))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(VehiculoCarrera vUno, VehiculoCarrera vDos)
        {
            if (Object.ReferenceEquals(vUno, null) == false && Object.ReferenceEquals(vDos, null) == false)
            {
                return !(vUno == vDos);
            }
            return false;
        }
    }
}
