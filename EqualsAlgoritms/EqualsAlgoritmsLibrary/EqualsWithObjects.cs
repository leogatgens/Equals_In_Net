using System;
using System.Collections.Generic;
using System.Text;
using EqualsAlgoritms.UnitTest;

namespace EqualsAlgoritmsLibrary
{
    public class EqualsWithObjects
    {
        public bool CompareTwoObjectWithSystemEquals(NoOverriddenEqualsMethodOfClass object1, NoOverriddenEqualsMethodOfClass object2)
        {

            if (object1.Equals(object2))
            {
                return true;
            }
            else {
                throw new Exception("LOL not Equals even have the same properties");
            }
            
        }

        public bool CompareTwoObjectWithOverridenEquals(OverriddenMethodEqualsOfClass object1, OverriddenMethodEqualsOfClass object2)
        {
            if (object1.Equals(object2))
            {
                return true;
            }
            return false ;
        }

    }
}
