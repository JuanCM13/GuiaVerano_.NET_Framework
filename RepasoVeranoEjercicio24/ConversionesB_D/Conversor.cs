using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionesB_D
{
    public class Conversor
    {
        public static string ConversorD_B(int dato)
        {
            /*
             * La idea es que toma numeros que se pueden representar solo con 8 bits
             * Va dividiendo /2 y saca el resto %2
             * El dato lo voy pisando con lo que me devuelve la division y el resto lo guardo en un array de enteros
             * Hace este proceso siempre que el dato sea mayor a 0 sino rompe, y si el contador llega a 7 tambien rompe, ya no
             * se podria representar el numero en 8 bits..
             * Despues para completar los ceros hago un ciclo for, desde el contador + 1 hasta < 8 agregando ceros
             * Despues para dar vuelta el resultado, hago otro for, del ultimo al primero, concatenandole a un auxiliar de tipo string
             * y parseandolo a string con el metodo .ToString(),
             * Devuelvo el aux string y listorti
             */

            //string aux = " ";
            int resto;
            //string restoString;
            string ret = " ";
            int cos;
            int counter = 0;
            int lenArray = 8;
            int[] array = new int[lenArray];

            if (dato > -1 && dato < 256)
            {
                do
                {
                    //Console.WriteLine("Dato vale: " + dato);
                    cos = dato / 2;
                    resto = dato % 2;
                    //Console.WriteLine("Resto vale:" + resto);

                    //restoString = resto.ToString();

                    //aux += restoString;

                    array[counter] = resto;

                    dato = cos;
                    //Console.WriteLine("Y ahora dato vale: " + dato);

                    if (dato <= 0 || counter == 7)
                    {
                        break;
                    }

                    counter++;

                } while (true);

                for (int i = counter + 1; i < 8; i++)
                {
                    array[i] = 0;
                }

                for (int h = lenArray - 1; h >= 0; h--)
                {
                    ret += array[h].ToString();
                }

                // ret = array.ToString(); //no me lo asigna asi, nose que onda me tira int [32} nose que otra mierda

            }
            else
            {
                ret = "No se pudo calcular, no entra en el rango de los 8 bits..";
            }

            return ret;
        }

        //--------------------------------------------------------------------------------------

        public static int ConversorB_D(string dato)
        {
            /*
             *  Convierte el string a un array de char
             *  Loopeo desde el largo del array -1 hasta 0 (asi hace la cuenta con ese control, 2^9 2^8 asi, ya que la cuenta se hace
             *  arrancando de derecha a izquierda 
             *  Despues genera una var control que arranca en 0 y llega al len del array -1 (asi va calculando y al mismo tiempo tiene la referencia del index 
             *  del num que se esta calculando)
             *  y compara, si el array en esa posision tiene un 1 lo acumula sino no
             */
            int ret = 0;
            int cuenta;
            char[] numBinario = dato.ToCharArray();
            int varControl;

            varControl = 0;

            for (int i = numBinario.Length - 1; i >= 0; i--)
            {
                cuenta = (int)Math.Pow(2, i);

                if (numBinario[varControl] == '1') //Si no comparo como si fuera caracter, no me lo toma el 1
                {
                    ret += cuenta;
                }
                varControl++;
            }
            return ret;
        }
        //--------------------------------------------------------------------------------------

        public bool Esbinario(string dato)
        {
            bool ret;
            char[] arrayAux = dato.ToCharArray();

            ret = true; //todo ok
            for (int i = 0; i < arrayAux.Length; i++)
            {
                if (arrayAux[i] != '1' && arrayAux[i] != '0')
                {
                    ret = false;//no esta formado solo por 1 y 0
                    break;
                }
            }
            return ret;
        }
    }
}
