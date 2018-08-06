using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualsAlgoritmsLibrary.Objetos
{
  public  class Profesion
    {

        public int Id { get; set; }


        public string TituloUniversitario { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (ReferenceEquals(obj, this))
                return true;
            if (obj.GetType() != this.GetType())
                return false;
            Profesion objComparado = obj as Profesion;
            return this.Id == objComparado.Id
                && this.TituloUniversitario  == objComparado.TituloUniversitario;
        
        }

        public override int GetHashCode()
        {

            return Id.GetHashCode() ^ TituloUniversitario.GetHashCode () ;
        }
    }
}
