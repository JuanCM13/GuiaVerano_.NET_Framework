using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidacionesEjercicio12
{
    public class ValidarRespuesta
    {
        public static bool validaS_N(char opcion)
        {
            bool ret;

            ret = false;

            if(opcion == 's')
            {
                ret = true;
            }

            return ret;
        }
    }
}
