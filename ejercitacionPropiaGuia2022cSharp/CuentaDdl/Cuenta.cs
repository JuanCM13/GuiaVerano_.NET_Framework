using System;
using System.Text;

namespace CuentaDdl
{
    public class Cuenta
    {
        private string razonSocial;
        private double cantidad;

        public string RazonSocial
        {
            get { return this.razonSocial; }
            set { this.razonSocial = value; }
        }

        public double Cantidad
        {
            get { return this.cantidad; }
            set
            {
                if (value > 0)
                {
                    this.cantidad = value;
                }
            }
        }

        public Cuenta() : this(" ", 0)
        { }

        public Cuenta(string rS, double cant)
        {
            this.Cantidad = cant;
            this.RazonSocial = rS;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Razon Social: {this.RazonSocial}\nSaldo disponible: ${this.Cantidad}");

            return sb.ToString();
        }

        public void Ingresar(double aIngresar)
        {
            this.Cantidad = (this.Cantidad + aIngresar); 
        }

        public void Retirar(double aRetirar)
        {
            this.Cantidad = (this.Cantidad - aRetirar);
        }

    }
}
