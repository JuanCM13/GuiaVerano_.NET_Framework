using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_LAB2_Libros_Entidades
{
    public class Biblioteca
    {
        private Int32 capacidad;
        private List<Libro> libros;

        private Biblioteca()
        {
            this.libros = new List<Libro>();
        }

        private Biblioteca(Int32 cap)
            : this()
        {
            this.capacidad = cap;
        }

        public Double PrecioManuales
        {
            get { return this.ObtenerPrecio(ELibros.PrecioDeManuales); }
        }

        public Double PrecioNovelas
        {
            get { return this.ObtenerPrecio(ELibros.PrecioDeNovelas); }
        }
        public Double PrecioTotal
        {
            get { return this.ObtenerPrecio(ELibros.PrecioTotal); }
        }

        public static implicit operator Biblioteca(Int32 cant)
        {
            Int32 aux = cant;
            if (cant < 0)
            {
                aux = 0;
            }
            return new Biblioteca(aux);
        }

        public static bool operator ==(Biblioteca bib, Libro lib)
        {
            bool ret = false;
            if (!(bib is null) && !(lib is null))
            {
                foreach (Libro item in bib.libros)
                {
                    if (item.Equals(lib))
                    {
                        ret = true;
                        break;
                    }
                }
            }
            return ret;
        }

        public static bool operator !=(Biblioteca bib, Libro lib)
        {
            return !(bib == lib);
        }

        public static Biblioteca operator +(Biblioteca bib, Libro lib)
        {
            if(!(bib is null))
            {
                if(bib.libros.Count < bib.capacidad)
                {
                    if(bib != lib)
                    {
                        bib.libros.Add(lib);
                    }
                    else
                    {
                        Console.WriteLine("El elemento ya se encuentra en la lista..");
                    }
                }
                else
                {
                    Console.WriteLine("La lista esta completa!!");
                }
            }
            else
            {
                Console.WriteLine("Un elemento no fue instanciado..");
            }
            return bib;
        }
        

        private Double ObtenerPrecio(ELibros tipo)
        {
            Double acum = 0;
            
            foreach(Libro item in this.libros)
            {
                if(item is Manual && (tipo == ELibros.PrecioDeManuales || tipo == ELibros.PrecioTotal))
                {
                    acum += (Single)((Manual)item);
                }
                else
                {
                    if (item is Novela && (tipo == ELibros.PrecioDeNovelas || tipo == ELibros.PrecioTotal))
                    {
                        acum += ((Novela)item);
                    }
                }
            }
            return acum;
        }

        public static String Mostrar(Biblioteca b)
        {
            StringBuilder str = new StringBuilder();
            if(!(b is null))
            {
                str.AppendLine($"Hay {b.libros.Count} Libros de {b.capacidad} lugares");
                str.AppendLine($"Ganancia Total: {b.PrecioTotal}");
                str.AppendLine($"Ganancia Manuales: {b.PrecioManuales}");
                str.AppendLine($"Ganancia Novelas: {b.PrecioNovelas}");
                str.AppendLine($"--------------------------------------------");
                str.AppendLine($"             Libros Cargados");
                str.AppendLine($"--------------------------------------------");

                if(b.libros.Count > 0)
                {
                    foreach(Libro item in b.libros)
                    {
                        str.AppendLine(item.ToString());
                    }
                }
                else
                {
                    str.AppendLine($"Sin libros cargados al momento..");
                }
            }
            else
            {
                str.AppendLine("La biblioteca no esta creada..");
            }
            return str.ToString();
        }

    }
}
