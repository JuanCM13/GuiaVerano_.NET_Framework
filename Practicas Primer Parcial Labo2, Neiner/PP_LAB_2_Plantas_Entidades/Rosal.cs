using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_LAB_2_Plantas_Entidades
{
    public class Rosal : Planta
    {
        private Color color;

        public Rosal(String nombre, Int32 tam)
            :base(nombre, tam)
        {}

        public Rosal(String nombre, Int32 tam, Color colorFlor)
            :this(nombre , tam)
        {
            this.color = colorFlor;
        }

        public override bool TieneFlores
        {
            get { return true; }
        }

        public override bool TieneFruto
        {
            get { return false; }
        }

        public override string ResumenDeDatos()
        {
            StringBuilder str = new StringBuilder();

            String colorF = this.color != 0 ? Enum.GetName(this.color) : "Color sin especificar";

            str.Append($"Color Flor: {colorF}\n{base.ResumenDeDatos()}");

            return str.ToString();
        }



    }
}
