using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_LAB2_Comiqueria_Entidades
{
    public class Figura : Producto
    {
        private Double altura;

        public Figura(Int32 stock, Double precio, Double altura)               
            :this($"Figura: {altura} cm" , stock, precio,altura)
        {}

        public Figura(String descripcion, Int32 stock, Double precio, Double altura)
            :base(descripcion, stock,precio)
        {
            this.altura = altura;
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine($"Figura: \n{base.ToString()}Altura: {this.altura}");
            return str.ToString();
        }
    }
}
