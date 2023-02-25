using System;
using System.Text;

namespace PP_LAB_2_Plantas_Entidades
{
    public abstract class Planta
    {
        private String nombre;
        private Int32 tamanio;

        public Int32 Tamanio
        {
            get { return this.tamanio; }
        }

        public abstract bool TieneFlores { get; }

        public abstract bool TieneFruto { get; }
    
        protected Planta(String nombre, Int32 tam)
        {
            this.nombre = nombre;
            this.tamanio = tam;
        }

        public virtual String ResumenDeDatos()
        {
            StringBuilder str = new StringBuilder();

            String aux1 = this.TieneFruto ? "Tiene" : "No tiene";
            String aux2 = this.TieneFlores? "Tiene" : "No tiene";

            str.AppendLine($"Nombre Planta: {this.nombre}\nTamaño: {this.Tamanio}\nFrutos: {aux1}\nFlores: {aux2}");

            return str.ToString();
        }
    
    }
}
