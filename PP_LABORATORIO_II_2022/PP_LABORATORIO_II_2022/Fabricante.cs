using System;

namespace PP_LABORATORIO_II_2022
{
    public class Fabricante
    {
        private String marca;
        private EPais pais;

        public Fabricante(EPais pa , String mar)
        {
            this.marca = mar;
            this.pais = pa;
        }

        public static bool operator ==(Fabricante f1 , Fabricante f2)
        {
            if(!(f1 is null) && !(f2 is null))
            {
                if(f1.marca == f2.marca && f1.pais == f2.pais)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Fabricante f1, Fabricante f2)
        {
            return !(f1 == f2);
        }

        public static implicit operator String(Fabricante f)
        {
            if(!(f is null))
            {
                return "Marca: " + f.marca + " -- " + Enum.GetName(f.pais);
            }
            return default;
        }
    }
}
