using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using BibliotecaUniversidad;

namespace UnityTest_Universidad
{
    [TestClass]
    public class UnitTest1
    {
        //[DataRow(132 , "pepe123123")]
        //[DataRow(1145, "Luccaass12")]
        [DataRow(123123, "lucas123")]
        //[DataRow(112233, "pepePeposo2022")]
        [TestMethod]
        public void Login_Correcto(int data , string data2)
        {
            //AAA , ARRANGE , ACT, ACCERT
            //act
            bool aux = Universidad.Loguear(data, data2);

            //Accert
            Assert.IsTrue(aux);
        }


        [DataRow(132 , "pepe123123")]
        [DataRow(1145, "Luccaass12")]
        //[DataRow(123123, "lucas123")]
        [DataRow(112233, "pepePeposo2022")]        
        [TestMethod]
        [ExpectedException(typeof(UnauthorizedAccessException))]
        public void Login_Incorrecto(int data, string data2)
        {
            //AAA , ARRANGE , ACT, ACCERT
            //act
            if(Universidad.Loguear(data, data2))
            {
                Assert.IsTrue(true);
            }

        }

        [TestMethod]
        public void CargaAlumnosSupera100Fallos_Test()
        {
            //arrange
            List<Alumno> lista = Universidad.Alumnos;
            Int32 fallos;

            if(!(lista is null) && lista.Count > 0)
            {
                fallos = 0;
                foreach(Alumno item in lista)
                {
                    try
                    {
                        item.ToString();
                    }
                    catch(NullReferenceException ex)
                    {
                        fallos++;
                    }
                }

                if(fallos > 100)
                {
                    Console.WriteLine("La prueba no paso el test, mas de 60 de los alumnos vinieron en null, cant: {0}",fallos);
                    Assert.IsTrue(false);
                }
                else
                {
                    Assert.IsTrue(true);
                }
            }
            else
            {
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        public void CargaProfesoresSupera100Fallos_Test()
        {
            //arrange
            List<Profesor> lista = Universidad.Profesores;
            Int32 fallos;

            if (!(lista is null) && lista.Count > 0)
            {
                fallos = 0;
                foreach (Profesor item in lista)
                {
                    try
                    {
                        item.ToString();
                    }
                    catch (NullReferenceException ex)
                    {
                        fallos++;
                    }
                }

                if (fallos > 100)
                {
                    Console.WriteLine("La prueba no paso el test, mas de 100 de los profesores vinieron en null, cant: {0}", fallos);
                    Assert.IsTrue(false);
                }
                else
                {
                    Assert.IsTrue(true);
                }
            }
            else
            {
                Assert.IsTrue(false);
            }
        }

    }
}
