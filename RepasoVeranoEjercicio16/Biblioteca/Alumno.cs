using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Alumno
    {
        private byte notaUno;
        private byte notaDos;
        private float notaFinal;
        private string apellido;
        private int legajo;
        private string nombre;
        
        public Alumno(string apellido , int legajo , string nombre)
        {
            this.apellido = apellido;
            this.legajo = legajo;
            this.nombre = nombre;
            this.notaFinal = -1;
        }

        public string DevolverDatos()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine($"Nombre: {this.nombre}");
            str.AppendLine($"Apellido: {this.apellido}");
            

            float floatAux = this.CalcularFinal();
            if(floatAux != -1)
            {
                str.AppendLine($"ESTADO DE FINAL: APROBADO");
            }
            else
            {
                str.AppendLine($"ESTADO DE FINAL: DESAPROBADO");
            }

            return str.ToString();
        }

        public void Estudiar(byte notaA , byte notaB)
        {
            this.notaUno = notaA;
            this.notaDos = notaB;
        }

        /*public float NotaFinal()
        {
            float ret;

            ret = CalcularFinal();

            return ret;
        }*/

        private float CalcularFinal()
        {
            Random rnd;

            if(this.notaUno > 3 && this.notaDos > 3)
            {
                rnd = new Random();

                this.notaFinal = rnd.Next(1, 11);
            }

            return this.notaFinal;
        }


    }
}
