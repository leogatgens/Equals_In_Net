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

            if (objetoDeEntrada == null)
                return false;
            if (ReferenceEquals(objetoDeEntrada, this))
                return true;
            if (objetoDeEntrada.GetType() != this.GetType())
                return false;
            ConfiguracionMatrizDinamica objetoAComparar = (ConfiguracionMatrizDinamica)objetoDeEntrada;

            return this.IdEmpresaEstablecimiento == objetoAComparar.IdEmpresaEstablecimiento
               & this.IdEntidadVinculada == objetoAComparar.IdEntidadVinculada
               & this.IdFormulario == objetoAComparar.IdFormulario
               & this.CodigoPregunta == objetoAComparar.CodigoPregunta
               & this.CodigoCelda == objetoAComparar.CodigoCelda
               & this.PosValorMetadata == objetoAComparar.PosValorMetadata
                & this.NombreColumna == objetoAComparar.NombreColumna;
        }

        public override int GetHashCode()
        {
            return IdEmpresaEstablecimiento.GetHashCode() ^ IdEntidadVinculada.GetHashCode()
                ^ IdFormulario.GetHashCode() ^ CodigoPregunta.GetHashCode() ^ CodigoCelda.GetHashCode() ^ PosValorMetadata.GetHashCode()
                ^ NombreColumna.GetHashCode();
        }
    }

}
