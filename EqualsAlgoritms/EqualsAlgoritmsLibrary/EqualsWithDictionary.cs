using System;
using System.Collections.Generic;
using System.Text;
using EqualsAlgoritmsLibrary.Objetos;

namespace EqualsAlgoritmsLibrary
{
    public class EqualsWithDictionary
    {
        public bool ComparaDiccionariosConMetodoEquals(ConfiguracionMatrizConPosValores configuracionMatriz1, ConfiguracionMatrizConPosValores configuracionMatriz2)
        {
            if (configuracionMatriz1.Equals(configuracionMatriz2))
            {
                return true;
            }else{

                return false;
            }

        }
    }
}
