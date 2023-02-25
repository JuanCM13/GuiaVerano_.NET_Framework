using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionesB_D
{
    public class NumeroDecimal
    {
        public int numero;

        public NumeroDecimal() : this(0)
        {

        }

        private NumeroDecimal(int dato)
        {
            this.numero = dato;
        }

        public double GetCantidad()
        {
            return this.numero;
        }

        //Conversor

        public static implicit operator NumeroDecimal(int dato)
        {
            NumeroDecimal aux = new NumeroDecimal(dato);

            //probar devolviendo return new NumeroDecimal(dato); tendria que funcar igual y devolver la referencia a ese objeto

            return aux;
        }

        public static explicit operator NumeroBinario(NumeroDecimal dato)
        {
            string aux;
            NumeroBinario auxBinario;

            aux = Conversor.ConversorD_B(dato.numero);
            auxBinario = aux;

            return auxBinario;
        }


        //Sobrecargas de operadores


        //Operador + - 
        public static int operator +(NumeroDecimal numDecimal, NumeroBinario numBinario)
        {
            int resultado;
            NumeroDecimal auxD = (NumeroDecimal)numBinario;

            resultado = numDecimal.numero + auxD.numero;

            return resultado;
        }

        public static int operator -(NumeroDecimal numDecimal, NumeroBinario numBinario)
        {
            int resultado;
            NumeroDecimal auxD = (NumeroDecimal)numBinario;

            resultado = numDecimal.numero - auxD.numero;
            //Console.WriteLine($"{auxD.numero} - {numDecimal.numero} da: {resultado}");

            return resultado;
        }

        //Operador == !=
        public static bool operator ==(NumeroDecimal numDecimal, NumeroBinario numBinario)
        {
            bool resultado;
            NumeroDecimal aux;

            resultado = false;
            aux = (NumeroDecimal)numBinario;

            if (aux.numero == numDecimal.numero)
            {
                resultado = true;
            }

            return resultado;
        }

        public static bool operator !=(NumeroDecimal numDecimal, NumeroBinario numBinario)
        {
            return !(numDecimal == numBinario);
        }
    }    
}
