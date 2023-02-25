using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_LAB_2_Plantas_Entidades
{
    public class Banano : Planta
    {
        private String codigo;

        public Banano(String nombre, Int32 tam, String codigo)
            :base(nombre,tam)
        {
            this.codigo = codigo;
        }

        public override bool TieneFlores
        {
            get { return true; }
        }

        public override bool TieneFruto
        {
            get { return true; }
        }

        public override string ResumenDeDatos()
        {
            StringBuilder str = new StringBuilder();

            str.Append($"Codigo Internacional: {this.codigo}\n{base.ResumenDeDatos()}");

            return str.ToString();
        }
    }
}
