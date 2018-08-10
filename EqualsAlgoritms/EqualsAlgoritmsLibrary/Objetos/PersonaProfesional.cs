using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualsAlgoritmsLibrary.Objetos
{
  public  class PersonaProfesional
    {
        public int Id { get; set; }


        public string  Nombre { get; set; }

        public string  Apellidos { get; set; }

        public List<Profesion> Profesiones { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (ReferenceEquals(obj, this))
                return true;
            if (obj.GetType() != this.GetType())
                return false;
            PersonaProfesional rhs = obj as PersonaProfesional;
            return this.Id == rhs.Id
                && this.Nombre == rhs.Nombre
                && this.Apellidos == rhs.Apellidos
             && this.Profesiones.SequenceEqual(rhs.Profesiones); //Compara utilizando el equals de la clase pero en orden sequencial


        }

        //public override bool Equals(object obj)
        //{


        //    if (obj == null)
        //        return false;
        //    if (ReferenceEquals(obj, this))
        //        return true;
        //    if (obj.GetType() != this.GetType())
        //        return false;
        //    PersonaProfesional rhs = obj as PersonaProfesional;

        //    return this.Id == rhs.Id
        //        && this.Nombre == rhs.Nombre
        //        && this.Apellidos == rhs.Apellidos
        //    && !this.Profesiones.Except(rhs.Profesiones).Any();//Compara utilizando el equals de la clase no importa el orden sequencial

        //}

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
