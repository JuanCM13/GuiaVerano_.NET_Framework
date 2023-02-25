using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionesB_D
{
    public class NumeroBinario
    {
        public string numero;

        public NumeroBinario() : this(" ")
        {

        }

        private NumeroBinario(string dato)
        {
            this.numero = dato;
        }

        public string GetCantidad()
        {
            return this.numero;
        }

        //Conversor

        public static implicit operator NumeroBinario(string dato)
        {
            NumeroBinario aux = new NumeroBinario(dato);

            //probar devolviendo return new NumeroDecimal(dato); tendria que funcar igual y devolver la referencia a ese objeto

            return aux;
        }

        public static explicit operator NumeroDecimal(NumeroBinario dato)
        {
            int aux;
            NumeroDecimal auxDecimal;

            aux = Conversor.ConversorB_D(dato.numero);
            auxDecimal = aux;

            return auxDecimal;
        }

        //Sobrecargas de operadores


        //Operador + - 
        public static string operator +(NumeroBinario numBinario, NumeroDecimal numDecimal)
        {
            //Leer comentarios para entender el proceso


            int aux; //variable donde se va a almacenar el valor de la suma decimal de (decimal)numBinario + numDecimal

            NumeroDecimal auxDecimalConResultado; //auxiliar donde se va a almacenar aux(double) para despues ser transformado a NumeroBinario

            NumeroBinario retorno; //auxiliar donde se va a convertir la suma decimal a valor binario




            aux =  numDecimal + numBinario; //se llama al operador Decimal sobrecargado + (recibe NumeroDecimal,NumeroBinario), devuelve la suma en double

            auxDecimalConResultado = aux; //se hace la asihnacion implicita de el resultado (double) y se asigna implicitamente a el auxiliar NumeroDecimal

            retorno = (NumeroBinario)auxDecimalConResultado; //se ahace la conversion explicita a binario asi transforma el valor decimal del auxiliar NumeroDecimal
                                                             //a NumeroBinario



            return retorno.numero; //se devuelve el valor ya convertido a binario, en forma de string(el campo numero del dato NumeroDecimal)
        }

        public static string operator -(NumeroBinario numBinario, NumeroDecimal numDecimal)
        {
            //es lo mismo que el metodo de arriba, nomas cambia al operador sobrecargado que llama (-)
            int aux;
            NumeroDecimal auxDecimalConResultado;
            NumeroBinario retorno;


            aux = numDecimal - numBinario;
            auxDecimalConResultado = aux;

            retorno = (NumeroBinario)auxDecimalConResultado;

            return retorno.numero;
        }

        //Operador == !=
        public static bool operator ==(NumeroBinario numBinario, NumeroDecimal numDecimal)
        {
            //En vez de escribir codigo al dope, reutilizo el operador == de la clase NumeroDecimal total devuelve lo mismo
            //En vez de convertir el decimal a binario, comparar en if etc... total es lo mismo el == va a convertir
            //el binario a decimal y ahi compara y lo que devuelve lo retorno por aca...

            return numDecimal == numBinario;
        }

        public static bool operator !=(NumeroBinario numBinario, NumeroDecimal numDecimal)
        {
            //llamo a == y lo !

            return !(numBinario == numDecimal);
        }
    }
}
