using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualsAlgoritmsLibrary.Objetos
{
    public class ConfiguracionMatrizDinamica
    {
        public int IdEmpresaEstablecimiento { get; set; }
        public int IdEntidadVinculada { get; set; }
        public int IdFormulario { get; set; }
        public string CodigoPregunta { get; set; }
        public string CodigoCelda { get; set; }

        public string PosValorMetadata { get; set; }

        public string NombreColumna { get; set; }

        public override bool Equals(object objetoDeEntrada)
        {
            ConfiguracionMatrizDinamica objetoAComparar = (ConfiguracionMatrizDinamica)objetoDeEntrada;

            return IdEmpresaEstablecimiento == objetoAComparar.IdEmpresaEstablecimiento
               & IdEntidadVinculada == objetoAComparar.IdEntidadVinculada
               & IdFormulario == objetoAComparar.IdFormulario
               & CodigoPregunta == objetoAComparar.CodigoPregunta
               & CodigoCelda == objetoAComparar.CodigoCelda
               & PosValorMetadata == objetoAComparar.PosValorMetadata
                & NombreColumna == objetoAComparar.NombreColumna;
        }
    }

}
