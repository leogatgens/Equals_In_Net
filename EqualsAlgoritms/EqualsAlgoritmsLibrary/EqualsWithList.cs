using System;
using EqualsAlgoritmsLibrary.Objetos;

namespace EqualsAlgoritmsLibrary
{
    public class EqualsWithList
    {
        public bool ComparaObjetosConMetodoEquals(PersonaProfesional personaGraduada1, PersonaProfesional personaGraduada2)
        {

           var algo = object.ReferenceEquals(personaGraduada1,personaGraduada2  ); 
            if (personaGraduada1.Equals(personaGraduada2)) {
                return true;
            }
            else {
                return false;
            }

        }
    }
}
