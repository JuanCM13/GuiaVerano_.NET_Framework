using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueSeaLoQueElDieguitoQuiera
{
    public class Arbusto : Planta
    {
        public Arbusto(String nombre , Int32 tam)
            :base(nombre , tam)
        {}

        public override bool TieneFlores { get { return false; } }

        public override bool TieneFruto { get { return false; } }
    }
}
