using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobreescrito
{
    public abstract class ClassSobreescrito
    {
        protected string miAtributo;

        public ClassSobreescrito()
        {
            this.miAtributo = "Probar Abstractos";
        }

        public abstract string MiPropiedad { get; }

        public abstract string MiMetodo();


        public override string ToString()
        {
            return "¡ESTE ES MI METODO ToString SOBREESCRITO";
        }

        public override bool Equals(object obj)
        {
            if (obj is ClassSobreescrito)
            {
                return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return 1142510187;
        }
    }
}
