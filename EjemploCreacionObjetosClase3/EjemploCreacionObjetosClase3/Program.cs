using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EjemploCreacionObjetosClase3
{
    internal class EjemploMascotas
    {
        static void Main(string[] args)
        {
            //Constructor instancia:
            //
            //mascota:

            Mascota mascotaUno = new Mascota("Salem" , new DateTime(10 , 05 , 2022) , "gato");
            Mascota mascotaDos = new Mascota("Poly", new DateTime(21, 03, 2011) , "perro");
            Mascota mascotaTres = new Mascota("Lucho", new DateTime(26, 15, 2011) , "iguana");
            Mascota mascotaCuatro = new Mascota("Faso", new DateTime(20, 01, 2000), "loro");
            //Mascota mascota; //cuando la declaro no vale nada, vale null osea una no direccion de memoria

            //mascota = new Mascota(); //asi lo instancio o creo el objeto, y lo almaceno en la variable mascota, no guardo el objeto
            //sino la referencia al espacio en memoria del objeto (como un puntero apuntando a ese objeto)

            //mascota = new Mascota("Salem" , new DateTime(1990 , 01 , 20) , "Gato"); //el dateTime tambien tengo que inicializarlo, hay varios constructores de ese mismo

            //--------------------

            Console.WriteLine(mascotaUno.MostrarDatos());
            Console.WriteLine(mascotaDos.MostrarDatos());
            Console.WriteLine(mascotaTres.MostrarDatos());
            Console.WriteLine(mascotaCuatro.MostrarDatos());

            Console.ReadKey();

        }
    }
}
