using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class DirectorTecnico : Persona
    {
        private DateTime fechaNacimiento;

        public DateTime FechaNacimiento
        {
            get { return this.fechaNacimiento; }
            set { this.fechaNacimiento = value; }
        }

        /* Probar si hace falta declarar el constructor y aparte llamar al base, o si de por si el constructor solo string ya lo adjudica
         * a nombre. probar en el main
         */

        public DirectorTecnico(string nombre) : base(nombre)
        { 
        }
        
        public DirectorTecnico(string nombre, DateTime fechaN) : base(nombre)
        {
            this.FechaNacimiento = fechaN;
        }

        public string MostrarDatosDirector()
        {
            StringBuilder auxS = new StringBuilder();

            auxS.AppendLine($"{this.MostrarDatos()}\nFecha Nacimiento: {this.FechaNacimiento}");

            return auxS.ToString();
        }

        public static bool operator ==(DirectorTecnico dUno , DirectorTecnico dDos)
        {
            if(object.ReferenceEquals(dUno , null) == false && object.ReferenceEquals(dDos , null) == false)
            {
                if((dUno.Dni == dDos.Dni) && (dUno.Nombre == dDos.Nombre))
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(DirectorTecnico dUno , DirectorTecnico dDos)
        {
            return !(dUno == dDos);
        }

    }
}
