using EqualsAlgoritmsLibrary.Objetos;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualsAlgoritms.UnitTest
{
    [TestClass]
    public class EqualsWithDictionary_Tests
    {

        private EqualsAlgoritmsLibrary.EqualsWithDictionary validator;

        [TestInitialize]
        public void TestInit()
        {
            validator = new EqualsAlgoritmsLibrary.EqualsWithDictionary();
        }

        [TestMethod]
        public void ValidaListaDiccionario_ConDiccionariosEquivalentes_SonIguales()
        {


          
            List<ConfiguracionMatrizDinamica> configuracionMatrizDinamica1 = CrearConfiguracionMatrizDinamica1();
            ConfiguracionMatrizConPosValores MatrizConPosValores1 = new ConfiguracionMatrizConPosValores()
            {
                    Configuraciones = configuracionMatrizDinamica1,
                    PosValores = new Dictionary<string, int>() { { "NP_01", -1 }, { "NP_02", -1 }, { "NP_03", -1 } }
             };

            List<ConfiguracionMatrizDinamica> configuracionMatrizDinamica2 = CrearConfiguracionMatrizDinamica2();
            ConfiguracionMatrizConPosValores MatrizConPosValores2 = new ConfiguracionMatrizConPosValores()
                {
                    Configuraciones = configuracionMatrizDinamica2,
                    PosValores = new Dictionary<string, int>() { { "NP_01", -1 }, { "NP_02", -1 }, { "NP_03", -1 } }
                };






            bool resultado = validator.ComparaDiccionariosConMetodoEquals(MatrizConPosValores1, MatrizConPosValores2);

                Assert.AreEqual(resultado, true);
           
        }

        private static List<ConfiguracionMatrizDinamica> CrearConfiguracionMatrizDinamica1()
        {
            List<ConfiguracionMatrizDinamica> configuracionMatrizDinamica = new List<ConfiguracionMatrizDinamica>();

            ConfiguracionMatrizDinamica configuracionA = new ConfiguracionMatrizDinamica()
            {
                IdEmpresaEstablecimiento = 1,
                IdEntidadVinculada = 1,
                CodigoCelda = "M.1.1",
                CodigoPregunta = "M.1",
                IdFormulario = 10,
                PosValorMetadata = "NP_01",
                NombreColumna = "DatodePrueba"
            };

            ConfiguracionMatrizDinamica configuracionB = new ConfiguracionMatrizDinamica()
            {
                CodigoCelda = "Celda.1.2.2",
                CodigoPregunta = "A.1.2.3",
                IdFormulario = 1,
                PosValorMetadata = "NP_02",
                NombreColumna = "DatodePrueba"
            };

            ConfiguracionMatrizDinamica configuracionC = new ConfiguracionMatrizDinamica()
            {
                CodigoCelda = "Celda.1.2.3",
                CodigoPregunta = "A.1.2.3",
                IdFormulario = 1,
                PosValorMetadata = "NP_03",
                NombreColumna = "DatodePrueba"
            };

            configuracionMatrizDinamica.Add(configuracionA);
            configuracionMatrizDinamica.Add(configuracionB);
            configuracionMatrizDinamica.Add(configuracionC);
            return configuracionMatrizDinamica;
        }

        private static List<ConfiguracionMatrizDinamica> CrearConfiguracionMatrizDinamica2()
        {
            List<ConfiguracionMatrizDinamica> configuracionMatrizDinamica = new List<ConfiguracionMatrizDinamica>();

            ConfiguracionMatrizDinamica configuracionA = new ConfiguracionMatrizDinamica()
            {
                IdEmpresaEstablecimiento = 1,
                IdEntidadVinculada = 1,
                CodigoCelda = "M.1.1",
                CodigoPregunta = "M.1",
                IdFormulario = 10,
                PosValorMetadata = "NP_01",
                NombreColumna = "DatodePrueba"
            };

            ConfiguracionMatrizDinamica configuracionB = new ConfiguracionMatrizDinamica()
            {
                CodigoCelda = "Celda.1.2.2",
                CodigoPregunta = "A.1.2.3",
                IdFormulario = 1,
                PosValorMetadata = "NP_02",
                NombreColumna = "DatodePrueba"
            };

            ConfiguracionMatrizDinamica configuracionC = new ConfiguracionMatrizDinamica()
            {
                CodigoCelda = "Celda.1.2.3",
                CodigoPregunta = "A.1.2.3",
                IdFormulario = 1,
                PosValorMetadata = "NP_03",
                NombreColumna = "DatodePrueba"
            };

            configuracionMatrizDinamica.Add(configuracionA);
            configuracionMatrizDinamica.Add(configuracionB);
            configuracionMatrizDinamica.Add(configuracionC);
            return configuracionMatrizDinamica;
        }
    }


}

