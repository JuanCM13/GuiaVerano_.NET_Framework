using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicacionExcepcionesRepasoVerano
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ExplicacionExcepciones";

            //double resultado = calcular(5, 0); // si esto esta por fuera del try catch, no le va a dar bola al de abajo por que no sigue
                //corriendo el programa para adelante, sino que arranca a buscar hacia arriba algun catch con el exception correcto, sino llega
                    //al main y rompe..
            try
            {
                Console.WriteLine("Arranco el program..");
                double resultado = calcular(5, 0);
                Console.WriteLine("Ya ejecuto"); //esta linea no la ejecuta. Al momento de encontrar una excepcion o error de 
                                                //compilacion corta la ejecucion del programa y arranca a buscar algun catch, si no lo tiene
                                                    //en el try, pasa a arrancar a desapilar la stack con metodos cargados (LIFO) y si encuentra
                                                        //algun catch mas arriba lo agarra, sino recien ahi rompe el programa y lo corta...

            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Controle la excepcion");
            }
            Console.ReadKey();
        }

        public static double calcular(int i, int x)
        {
            try
            {
                return i / x;
            } 
            catch(DivideByZeroException ex) //la excepcion es un objeto, si le pongo un nombre como aca ex, puedo manejarlo y  
                                            //acceder a sus metodos...
            {
                Console.WriteLine(ex.Message); //en este caso el mensaje que tira por defecto es, intento dividir por cero..
                 
                throw; //esto la devuelve, osea tira de nuevo una excepcion de tipo Divide, asi vuelve al main y ejecuta el bloque catch tambien..
                //tambien en este caso la retorno, por que me pide que retorne algo si o si... podria usar una var auxiliar y retornar eso y ahorrarme el throw que esta al dope
            }  
        }
    }
}
