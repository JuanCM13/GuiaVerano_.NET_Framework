using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CentralitaHerencia;
namespace Ejercicio37RepasoVerano
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Dato:
             para evitar usar polimorfismo o sobrecargar un dato con new u override para los metodos MostrarDatos().
            Opte por declarar el metodo estatico en la base, el cual recibe por parametro un objeto de tipo Llamada e imprime
            la data de ese objeto (duracion , origen y destino) y desde la heredada llama a ese metodo casteando el this
            osea el tipo de dato derivado a la clase base (Llamada), a continuacion le concateno la data especifica de esa clase
            hija o subclase. Dato no hace falta castearlo de manera explicita igual por las dudas le dejo el casteo explicito
            
            ** IGUAL PENSANDOLO SERIA UNA SOBRECARGA, POR QUE EL PRIMERO AUNQUESEA ESTATICO RECIBE UN PARAMETRO Y LOS OTROS NO :/ **
            PERO UE QUE LA SOBEN
            
            Ej:

            clase base: Llamada
            public static string MostrarData(Llamada llamado)
            {
                str = llamado.Duracion + llamado.Origen + llamado.Destino;
            }

            subclase Local
            public string MostrarData()
            {
                str = {Llamada.MostrarData( (Llamada) this )};
                str += this.DatoEspecificoDeEstaClaseHija;
            }

             */
            Console.Title = "RepasoVeanoEjercicio37";

            //codigo de prueba, en vez de hardodear y agregar las llamadas via c.Llamadas.Add(llamada)
            //cree un metodo en centralita que agrega una llamada

            //Mi central
            Centralita c = new Centralita("Fede Center");

            //Mis 4 Llamadas //el nombre solo con numeros no me lo permite, tengo que si o si agregarle alguna letra al inicio
            Local llamada11 = new Local("Bernal", 30, "Rosario", 2.65F);
            Provincial llamada12 = new Provincial("Moron" , Provincial.Franja.Franja_1 , 21 , "Bernal");
            Local llamada13 = new Local("Lanus", 45, "San Rafael", 1.99F);
            Provincial llamada14 = new Provincial("Palermo" , Provincial.Franja.Franja_3, 12 , "Recoleta");

            if(c.AgregarLlamadaAlista(llamada11) && c.AgregarLlamadaAlista(llamada12) && c.AgregarLlamadaAlista(llamada13) && c.AgregarLlamadaAlista(llamada14))
            {
                Console.WriteLine(c.Mostrar());
            }

            c.OrdenarLlamadas();
            Console.WriteLine($"\nLista Ordenada: \n\n{c.Mostrar()}");

            Console.ReadKey();
        }
    }
}
