using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_LABORATORIO_II_2022
{
    public abstract class Producto
    {
        protected Fabricante fabricante;
        protected static Random generadorPrecios;
        protected String modelo;
        protected Double precio;

        static Producto()
        {
            Producto.generadorPrecios = new();
        }

        public Producto(String modelo , Fabricante fab)            
        {
            this.modelo = modelo;
            this.fabricante = fab;
        }

        public Producto(String modelo, String marca , EPais pais)
            : this(modelo , new Fabricante(pais , marca))
        {}

        public Double Precio
        {
            get 
            {
                if(this.precio == 0)
                {
                    this.precio = Producto.generadorPrecios.Next(10500, 125001);
                }
                return this.precio;
            }
        }

        public static bool operator ==(Producto p1 , Producto p2)
        {
            if(!(p1 is null) && !(p2 is null))
            {
                if(p1.modelo == p2.modelo && p1.fabricante == p2.fabricante)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }

        public static explicit operator String(Producto p)
        {
            if(!(p is null))
            {
                return Producto.Mostrar(p);
            }
            return String.Empty;
        }

        private static String Mostrar(Producto p)
        {
            return new StringBuilder().Append($"Tipo Producto: {p.GetType().Name}:\nModelo: {p.modelo}\nPrecio: {p.Precio}\nDatos Fabricante:\n" +
                $"{(String)p.fabricante}").ToString();
        }
    }
}
