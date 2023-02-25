using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_LABORATORIO_II_2022
{
    public class Deposito
    {
        private Int32 cap;
        private List<Producto> productos;

        private Deposito()
        {
            this.productos = new();
        }

        private Deposito(Int32 cap)
            : this()
        {
            this.cap = cap;
        }

        public Double PrecioDeTelevisores { get => this.ObtenerPrecio(EProducto.PrecioDeTelevisores); }

        public Double PrecioDeCelulares { get => this.ObtenerPrecio(EProducto.PrecioDeCelulares); }

        public Double PrecioTotal { get => this.ObtenerPrecio(EProducto.PrecioTotal); }

        public static String Mostrar(Deposito d)
        {
            StringBuilder str = new StringBuilder().AppendLine($"Error, el deposito fue nullo");

            if (!(d is null))
            {
                str.Clear();

                str.AppendLine($"Capacidad maxima del deposito: {d.cap}\nOcupado al momento: {d.productos.Count}");
                str.AppendLine($"Total de televisores: {d.PrecioDeTelevisores}\nTotal Celulares: {d.PrecioDeCelulares}\nPrecio Total: {d.PrecioTotal}" +
                    $"\nInformacion de productos: ");
                if (d.productos.Count > 0)
                {
                    foreach (Producto item in d.productos)
                    {
                        str.AppendLine(item.ToString());
                    }
                }
                else
                {
                    str.AppendLine($"Sin productos al momento..");
                }
            }
            return str.ToString();
        }

        public static implicit operator Deposito(Int32 cap)
        {
            Int32 capacidad = 0;
            if (cap > 0)
            {
                capacidad = cap;
            }
            return new Deposito(capacidad);
        }

        public static bool operator ==(Deposito d, Producto p)
        {
            if (!(d is null) && !(p is null))
            {
                foreach (Producto item in d.productos)
                {
                    if (p.Equals(item))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool operator !=(Deposito d, Producto p)
        {
            return !(d == p);
        }

        public static Deposito operator +(Deposito d , Producto p)
        {
            if(!(d is null) && !(p is null))
            {
                if(d != p)
                {
                    if(d.productos.Count < d.cap)
                    {
                        d.productos.Add(p);
                    }
                    else
                    {
                        Console.WriteLine($"Error, se alcanzo al capacidad maxima de productos en el deposito: {d.cap} , productos almacenados");
                    }
                }
                else
                {
                    Console.WriteLine("El producto ya se encuentra cargado en el listado..");
                }
            }
            else
            {
                Console.WriteLine("Error, uno de los objetos fue nullo..");
            }
            return d;
        }

        private Double ObtenerPrecio(EProducto prod)
        {
            Double ret = 0;
            foreach(Producto item in this.productos)
            {
                if(prod == EProducto.PrecioTotal || (item is Celular && prod == EProducto.PrecioDeCelulares))
                {
                    ret += item.Precio;
                }
                else
                {
                    if(item is Televisor && prod == EProducto.PrecioDeTelevisores)
                    {
                        ret += item.Precio;
                    }
                }
            }
            return ret;
        }
    }
}
