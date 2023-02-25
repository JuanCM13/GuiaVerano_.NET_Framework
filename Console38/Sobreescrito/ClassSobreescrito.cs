using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobreescrito
{
    public class ClassSobreescrito
    {
        public override string ToString()
        {
            return "¡ESTE ES MI METODO ToString SOBREESCRITO";
        }

        public override bool Equals(object obj)
        {
            if(obj is ClassSobreescrito)
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
