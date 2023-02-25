using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploCreacionObjetosClase3
{
    public class Mascota
    {
        //atributos, declarados como privado por que es una mala practica acceder directamente a los atributos
        //desde fuera de la clase, por ahora aunque la guia diga que lo ponga public, lo hago private (los atributos)


        private string nombre;
        private DateTime nacimiento; //DateTime es un tipo de dato que me proporciona c#, de tipo fecha, usar que facilita la vida
        private string especie; //aunque podria ser una clase aparte
        //private static ratioEdad; ejemplo constructor estatico


        //metodos constructores
        //al momento que creo el constructor, el que existe por defecto del ide deja de existir, no lo reconoce mas
        //se llama igual que la clase SIEMPRE!!!! y no devuelve nada.

        public Mascota(string nombre , DateTime fecha , string especiee)
        {
            //usar palabra reservada this. hace referencia a miembros del objeto o metodo de este..

            this.nombre = nombre; //al atributo nombre le asigno el parametro que resivo nombre
            this.nacimiento = fecha;
            this.especie = especiee;

        }

           //Constructor estatico ejemplo: se inicializan antes de tratar de usar la clase y ya inicializa todos los estaitcos

            /*static Mascota()
            {
                Mascota.ratioEdad = 2; //nombre de la clase + atributo = valor;
            }*/

        public string MostrarDatos()
        {
            StringBuilder builder = new StringBuilder();

            //metodo 1 de string builder .Append (anexa sin saltos de linea)
            //metodo 2 de string builder .AppendLine (anexa con saltos de linea)
            //metodo 3 de string builder .AppendFormat (deja poner mascaras como con el console.writeLine)

            builder.AppendLine($"Nombre: {this.nombre}");
            builder.AppendLine($"Fecha: {this.nacimiento.ToString("dd/MM/yyyy")}");
            /*
             * dateTime.toString me permite darle el formato que quiero que imprima la fecha
             * Si pongo dateTime.toShortDateString me imprime ej: 4/7/2022
             * Si pongo dateTime.toLongDateString me pone "jueves 4 de julio del 2022" dato copadooo
             */
            builder.AppendLine($"Especie: {this.especie}");

            return builder.ToString(); 
        }
    }
}
