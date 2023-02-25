using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;
 
namespace RepasoVeranoEjercicio34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicicio34RepasoVerano";

            int queEs = -1; //si no la inicializo me tira error despues shit
            VehiculoTerrestre[] array = new VehiculoTerrestre[3];
            AutoMovil auto = new AutoMovil(AutoMovil.Colores.Negro , 4 , 3 , 6 , 5);
            Camion camion = new Camion(Camion.Colores.Blanco, 8, 2, 85000, 6);
            Moto moto = new Moto(Moto.Colores.Rojo, 2, 0, 255);

            array[0] = auto;
            array[1] = camion;
            array[2] = moto;

            foreach(VehiculoTerrestre aux in array)
            {
                if(aux != null)
                {
                    if(aux is Moto)
                    {
                        queEs = 1;
                    }
                    else
                    {
                        if(aux is Camion)
                        {
                            queEs = 2;
                        }
                        else
                        {
                            queEs = 3; //automovil
                        }
                    }
                }

                switch(queEs)
                {
                    case 1:
                        Moto auxMoto = (Moto)aux;
                        Console.WriteLine(auxMoto.GetDataMoto());
                    break;
                    case 2:
                        Camion auxCamion = (Camion)aux;
                        Console.WriteLine(auxCamion.GetDataCamion());
                    break;
                    case 3:
                        AutoMovil auxAuto = (AutoMovil)aux;
                        Console.WriteLine(auxAuto.GetDataAuto());
                    break;
                }

            }
            Console.ReadKey();
        }
    }
}
