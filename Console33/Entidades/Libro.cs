using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Libro
    {
        private List<string> paginas;

        public Libro()
        {
            this.paginas = new List<string>();
        }

        public string this[int i]
        {
            get
            {
                if(i < paginas.Count && paginas.ElementAt(i) != null) //pregunto si es distinto a null por que si llego a cargar un elemento
                {                                                       //y despues para borrarlo a esa posision le asigno un null, sigue estando
                    return this.paginas[i];                             //y podria llegar a romperme el programa..
                }

                return string.Empty; //es lo mismo que devolver " " 
            }
            set
            {
                if(this.paginas.ElementAtOrDefault(i) != null)
                {
                    this.paginas[i] = value;
                }
                else
                {
                    this.paginas.Add(value);
                }
            }

        }
    }
}
