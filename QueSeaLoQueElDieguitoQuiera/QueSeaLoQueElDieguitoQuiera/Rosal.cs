using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueSeaLoQueElDieguitoQuiera
{
    public class Rosal : Planta
    {
        private Color color;

        public Rosal(String nombre, Int32 tam)
            :base(nombre, tam)
        {}

        public Rosal(String nombre, Int32 tam , Color col)
            :this(nombre , tam)
        {
            this.color = col;
        }

        public override bool TieneFlores { get { return true; } }

        public override bool TieneFruto { get { return false; } }

        public override string ResumenDeDatos()
        {
            StringBuilder str = new StringBuilder();

            String aux = this.color == 0 ? "Sin especificar.." : Enum.GetName(this.color);
            str.AppendLine($"{this.GetType().Name}:\n{base.ResumenDeDatos()}Color: {aux}");
            return str.ToString();
        }

    }
}
