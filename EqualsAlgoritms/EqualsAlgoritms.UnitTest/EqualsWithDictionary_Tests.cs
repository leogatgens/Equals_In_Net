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
    class EqualsWithDictionary_Tests
    {

        private EqualsAlgoritmsLibrary.EqualsWithDictionary validator;

        [TestInitialize]
        public void TestInit()
        {
            validator = new EqualsAlgoritmsLibrary.EqualsWithDictionary();
        }

        [TestMethod]
        public void ValidaListaConObjectos_ConListaOrdenadas_SonIguales()
        {


            ConfiguracionMatrizConPosValores configuracionMatriz1 = new ConfiguracionMatrizConPosValores();
            List<ConfiguracionMatrizDinamica> configuracionMatrizDinamica = new List<ConfiguracionMatrizDinamica>();

            ConfiguracionMatrizDinamica configuracionA = new ConfiguracionMatrizDinamica()
            {
                IdEmpresaEstablecimiento = 1,
                IdEntidadVinculada = 1,
                CodigoCelda = "M.1.1",
                CodigoPregunta = "M.1",
                IdFormulario = 10,
                PosValorMetadata = "NP_01"
            };

            ConfiguracionMatrizDinamica configuracionB = new ConfiguracionMatrizDinamica()
            {
                CodigoCelda = "Celda.1.2.2",
                CodigoPregunta = "A.1.2.3",
                IdFormulario = 1,
                PosValorMetadata = "NP_02"
            };

            ConfiguracionMatrizDinamica configuracionC = new ConfiguracionMatrizDinamica()
            {
                CodigoCelda = "Celda.1.2.3",
                CodigoPregunta = "A.1.2.3",
                IdFormulario = 1,
                PosValorMetadata = "NP_03"
            };

            configuracionMatrizDinamica.Add(configuracionA);
            configuracionMatrizDinamica.Add(configuracionB);
            configuracionMatrizDinamica.Add(configuracionC);

            configuracionMatriz1.Configuraciones = configuracionMatrizDinamica;
            configuracionMatriz1.PosValores = new Dictionary<string, int>() { { "NP_01", -1 }, { "NP_02", -1 }, { "NP_03", -1 } };


         bool resultado =    validator.ComparaDiccionariosConMetodoEquals(configuracionMatriz1, configuracionMatriz1);

            Assert.AreEqual(resultado ,true );
        }


    }


}

