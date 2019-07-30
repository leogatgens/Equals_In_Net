using System;
using System.Collections.Generic;
using EqualsAlgoritmsLibrary.Objetos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EqualsAlgoritms.UnitTest
{
    [TestClass]
    public class EqualsWithList_Tests
    {
        private EqualsAlgoritmsLibrary.EqualsWithList validator;

        [TestInitialize]
        public void TestInit()
        {
            validator = new EqualsAlgoritmsLibrary.EqualsWithList();
        }

        [TestMethod]
        public void ValidaListaConObjectos_ConListaOrdenadas_SonIguales()
        {
           
            List<Profesion> profesionesPersona1 = new List<Profesion>
            {
                     new Profesion
                {
                    Id = 1,
                    TituloUniversitario = "Sistemas"
                },
                    new Profesion
                {
                    Id = 2,
                    TituloUniversitario = "Taxista"
                },
                    new Profesion
                {
                    Id = 3,
                    TituloUniversitario = "Abogado"
                }
            };


            List<Profesion> profesionesPersona2 = new List<Profesion>
            {

                     new Profesion
                {
                    Id = 1,
                    TituloUniversitario = "Sistemas"
                },
                    new Profesion
                {
                    Id = 2,
                    TituloUniversitario = "Taxista"
                },
                    new Profesion
                {
                    Id = 3,
                    TituloUniversitario = "Abogado"
                }
            };

            PersonaProfesional personaGraduada1 = new PersonaProfesional
            {
                Id = 1,
                Nombre = "Leonardo",
                Apellidos = "Melendez",
                Profesiones = profesionesPersona1 
                    
                
            };

            PersonaProfesional personaGraduada2 = new PersonaProfesional
            {
                Id = 1,
                Nombre = "Leonardo",
                Apellidos = "Melendez",
                Profesiones = profesionesPersona2


            };


            bool obtained = validator.ComparaObjetosConMetodoEquals(personaGraduada1,personaGraduada2 );
            bool expected = true;
            Assert.AreEqual(obtained, expected);

        }

        [TestMethod]
        public void ValidaListaConObjectos_ConListaDesordenadas_SonDistintas()
        {
            List<Profesion> profesionesPersona1 = new List<Profesion>
            {
                     new Profesion
                {
                    Id = 1,
                    TituloUniversitario = "Sistemas"
                },
                    new Profesion
                {
                    Id = 2,
                    TituloUniversitario = "Taxista"
                },
                    new Profesion
                {
                    Id = 3,
                    TituloUniversitario = "Abogado"
                }
            };


            ///Las profesiones son las mismas que la persona 1 pero el orden es distinto
            List<Profesion> profesionesPersona2 = new List<Profesion>
            {
                      new Profesion
                {
                    Id = 3,
                    TituloUniversitario = "Abogado"
                },
                new Profesion
                {
                    Id = 2,
                    TituloUniversitario = "Taxista"
                },
                   new Profesion
                {
                    Id = 1,
                    TituloUniversitario = "Sistemas"
                }

            };

            PersonaProfesional personaGraduada1 = new PersonaProfesional
            {
                Id = 1,
                Nombre = "Leonardo",
                Apellidos = "Melendez",
                Profesiones = profesionesPersona1


            };
            ///Es la misma persona pero las profesiones estan en otro orden.
            PersonaProfesional personaGraduada2 = new PersonaProfesional
            {
                Id = 1,
                Nombre = "Leonardo",
                Apellidos = "Melendez",
                Profesiones = profesionesPersona2


            };

            ///El resultado esperado es que no sean iguales. Por el orden
            bool obtained = validator.ComparaObjetosConMetodoEquals(personaGraduada1, personaGraduada2);
            bool expected = false;
            Assert.AreEqual(obtained, expected);

        }
    }
}
