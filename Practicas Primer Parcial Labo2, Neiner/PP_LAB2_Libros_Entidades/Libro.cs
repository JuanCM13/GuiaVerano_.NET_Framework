using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_LAB2_Libros_Entidades
{
    public abstract class Libro
    {
        protected Autor autor;
        protected Int32 cantPaginas;
        protected static Random generadorPaginas;
        protected Single precio;
        protected String titulo;

        static Libro()
        {
            Libro.generadorPaginas = new Random();
        }

        public Libro(Single precio, String titulo, Autor autor)            
        {
            this.autor = autor;
            this.titulo = titulo;
            this.precio = precio;
        }

        public Libro(String titulo , String apellido , String nombre, Single precio)
            :this(precio,titulo,new Autor(nombre,apellido))
        {}

        /*etornará el valor correspondiente del atributo cantidadDePaginas, que
        se inicializará en dicha propiedad, si y sólo si su valor es cero. Para inicializar dicho atributo, se utilizará el atributo estático
        generadorDePaginas (valores aleatorios entre 10 y 570). Ninguno debe de repetirse.*/

        public Int32 CantidadPaginas
        {
            get 
            {
                if(this.cantPaginas == 0)
                {
                    this.cantPaginas = Libro.generadorPaginas.Next(10, 570);
                }
                return this.cantPaginas;
            }
        }

        private static String Mostrar(Libro l)
        {
            StringBuilder str = new StringBuilder();

            str.Append($"Autor: {(String)l.autor}\nTitulo: {l.titulo}\nCantidad Paginas: {l.CantidadPaginas}\nPrecio: {l.precio}");

            return str.ToString();
        }

        public static bool operator ==(Libro l1,Libro l2)
        {
            bool ret = false;
            if(!(l1 is null) && !(l2 is null))
            {
                if(l1.titulo == l2.titulo && l1.autor == l2.autor)
                {
                    ret = true;
                }
            }
            return ret;
        }

        public static bool operator !=(Libro l1, Libro l2)
        {
            return !(l1 == l2);
        }

        public static explicit operator String(Libro l)
        {
            if(!(l is null))
            {
                return Libro.Mostrar(l);
            }
            return String.Empty;
        }
    }
}
