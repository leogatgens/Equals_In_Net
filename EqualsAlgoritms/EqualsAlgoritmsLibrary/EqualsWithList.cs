using EqualsAlgoritmsLibrary.Objetos;
using System;

namespace EqualsAlgoritmsLibrary
{
    public class EqualsWithList
    {
        public bool ComparaObjetosConMetodoEquals(PersonaProfesional personaGraduada1, PersonaProfesional personaGraduada2)
        {
            
           var algo = object.ReferenceEquals(personaGraduada1,personaGraduada2  );
            if (algo == true) {
                throw new Exception();
            }
            if (personaGraduada1.Equals(personaGraduada2)) {
                return true;
            }
            else {
                return false;
            }

        }
    }
}
