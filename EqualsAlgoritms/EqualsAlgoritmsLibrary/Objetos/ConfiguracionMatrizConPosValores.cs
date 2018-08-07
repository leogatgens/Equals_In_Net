using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualsAlgoritmsLibrary.Objetos
{

    public class ConfiguracionMatrizConPosValores
    {
        public List<ConfiguracionMatrizDinamica> Configuraciones { get; set; }
        public Dictionary<string, int> PosValores { get; set; }

        public override bool Equals(object objetoDeEntrada)
        {
            ConfiguracionMatrizConPosValores objetoAComparar = (ConfiguracionMatrizConPosValores)objetoDeEntrada;

            return Configuraciones.Except(objetoAComparar.Configuraciones).Any()
               & objetoAComparar.PosValores.Count == PosValores.Count
                & objetoAComparar.PosValores.Keys.All(llave => PosValores.ContainsKey(llave)
                 & Object.Equals(objetoAComparar.PosValores[llave], PosValores[llave]));
        }
    }



}
