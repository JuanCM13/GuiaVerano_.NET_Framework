using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Mascota
    {
        string nombre;
        DateTime fechaNacimiento;
        string especie;

        public Mascota(string nom , DateTime fecha , string espe)
        {
            this.nombre = nom;
            this.fechaNacimiento = fecha;
            this.especie = espe;
        }

        public string MostrarDatos()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine($"Nombre: {this.nombre}");
            str.AppendLine($"Fecha de Nacimiento: {this.fechaNacimiento.ToShortDateString()}");
            str.AppendLine($"Especie: {this.especie}");

            return str.ToString();
        }

        public int GetEdad()
        {
            int ret;
            DateTime fechaActual = DateTime.Today;

            ret = fechaActual.Year - this.fechaNacimiento.Year;

            if(this.fechaNacimiento.AddYears(ret) > fechaActual)
            {
                ret--;
            }
            return ret;
        }
    }



}
