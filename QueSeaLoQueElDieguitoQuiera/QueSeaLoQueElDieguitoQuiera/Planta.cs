
using System;
using System.Text;

namespace QueSeaLoQueElDieguitoQuiera
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
    
        public Planta(String nombre, Int32 tam)
        {
            this.nombre = nombre;
            this.tamanio = tam;
        }

        public virtual String ResumenDeDatos()
        {
            StringBuilder str = new StringBuilder();

            String auxFlores = this.TieneFlores ? "Si" : "No";
            String auxFruto = this.TieneFruto ? "Si" : "No";
            str.AppendLine($"Nombre: {this.nombre}\nFlores: {auxFlores}\nFruto: {auxFruto}");
            return str.ToString();
        }
    
    }
}
