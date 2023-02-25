using System;
using PP_LAB2_LaLibreriaUtnPagina_Entidades;

namespace PP_LAB2_LaLibreriaUtnPagina_Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "MendezJuaCruz";

            Vendedor v = new Vendedor("Jorge");
            Biografia p1 = (Biografia)"Life (Keith Richards)";
            Biografia p2 = new Biografia("White line fever (Lemmy)", 5);
            Biografia p3 = new Biografia("Commando (Johnny Ramone)", 2, 5000);
            Comic p4 = new Comic("La Muerte de Superman (Superman)", true, 1, 1850);
            Comic p5 = new Comic("Año Uno (Batman)", false, 3, 1270);

            bool ret = v + p1;            
            ret = v + p2;
            ret = v + p3;
            ret = v + p4;
            ret = v + p5;

            Console.WriteLine(v.ObtenerInformeDeVentas());

            Console.ReadKey();
        }
    }
}
