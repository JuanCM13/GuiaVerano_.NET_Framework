using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueSeaLoQueElDieguitoQuiera
{
    public class Banano : Planta
    {
        private String codigo;

        public Banano(String nombre, Int32 tam, String cod)
            :base(nombre , tam)
        {
            this.codigo = cod;
        }

        public override bool TieneFlores { get { return true; } }

        public override bool TieneFruto { get { return true; } }

        public override string ResumenDeDatos()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine($"{this.GetType().Name}:\n{base.ResumenDeDatos()}Codigo Internacional: {this.codigo}");
            return str.ToString();
        }
    }
}
