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



            return !this.Configuraciones.Except(objetoAComparar.Configuraciones).Any()
            & objetoAComparar.PosValores.Count == this.PosValores.Count
                & objetoAComparar.PosValores.Keys.All(llave => this.PosValores.ContainsKey(llave)
                 & Object.Equals(objetoAComparar.PosValores[llave], this.PosValores[llave]));


            //return this.Configuraciones.SequenceEqual(objetoAComparar .Configuraciones )
            //& objetoAComparar.PosValores.Count == this.PosValores.Count
            //    & objetoAComparar.PosValores.Keys.All(llave => this.PosValores.ContainsKey(llave)
            //     & Object.Equals(objetoAComparar.PosValores[llave], this.PosValores[llave]));
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }



}
