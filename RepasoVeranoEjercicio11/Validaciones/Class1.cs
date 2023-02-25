using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validaciones
{
    public class Validacion
    {
        public static bool Validar(int valor, int minimo, int max)
        {
            bool ret;

            ret = false;

            if(valor >= minimo && valor <= max)
            {
                ret = true;
            }

            return ret;
        }
    }
}
