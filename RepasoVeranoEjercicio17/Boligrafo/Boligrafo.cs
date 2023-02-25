using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boligrafo
{
    public class Boligrafos
    {
        //atr
        private static short cantMaxTinta;
        private ConsoleColor color;
        private short tinta;

        //mets

        static Boligrafos()
        {
            Boligrafos.cantMaxTinta = 100;
        }

        public Boligrafos(short tint , ConsoleColor col)
        {
            this.color = col;
            this.tinta = tint;
        }

        public ConsoleColor GetColor()
        {
            return this.color;
        }
        public short GetTinta()
        {
            return this.tinta;
        }

        private void SetTinta(short tinta)
        {
            int result;

            result = this.tinta + tinta; //la maquina no discrimina con el signo de la variable tinta y hace la cuenta normal
                                        //Onda si pongo this.tinta - (-50) me lo toma como +50, por eso le pongo siempre +
                                        //si llega a caer this.tinta + (+50) me tira bien el resultado, el tema es con el -

            if(result > 0 && result < 101)
            {
                this.tinta = (short) result;
            }
            else
            {
                if(result < 1)
                {
                    this.tinta = 0;
                    Console.WriteLine($"Seteo la tinta en 0 , tinta vale: {this.tinta}");
                }
                else
                {
                    this.tinta = cantMaxTinta;
                }
            }

        }

        public void Recargar()
        {
            SetTinta(cantMaxTinta);
        }

        public bool Pintar(short gasto , out string dibujo)
        {
            bool ret = false;
            StringBuilder aux = new StringBuilder();
            string auxString = " ";
            int refTinta;
            int refGasto;

            refGasto = gasto;
            refTinta = this.tinta;
            for(int i = refTinta; i > 0; i--) //hago un loop recorriendo la cant de veces que gasto tinta uno x uno
            {                               //y voy restandole -1 a la referenciade tinta, si llega a estar en 0 
                                            //la tinta, rompe y sino recorre hasta que termine de ciclar con el gasto
                
                if(refGasto == 0)
                {
                    break;
                }
                refGasto++;
                auxString += "*";
            }

            SetTinta(gasto);

            if (this.tinta > 0)
            {
                ret = true;
                aux.AppendLine($"Se pudo pintar...");
            }
            else
            {
                aux.AppendLine($"No fue posible pintar todo o fue posible pero la tinta quedo vacia..");
            }

            aux.AppendLine($"\n\n{auxString}");
            dibujo = aux.ToString();
            return ret; 
        }

    }

}
