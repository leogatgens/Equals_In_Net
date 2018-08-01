using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualsAlgoritms.UnitTest
{
    [TestClass]
    public class EqualsWithObjects_Tests
    {
        private EqualsAlgoritmsLibrary.EqualsWithObjects validator;

        [TestInitialize]
        public void TestInit()
        {
            validator = new EqualsAlgoritmsLibrary.EqualsWithObjects();
        }

        [TestMethod]
        [ExpectedException(typeof(System.Exception))]
        public void ValidateObjects_WithDefaultEqualsMethod_ExceptionNotEqual()
        {
           
                

                NoOverriddenEqualsMethodOfClass object1 = new NoOverriddenEqualsMethodOfClass();
                NoOverriddenEqualsMethodOfClass object2 = new NoOverriddenEqualsMethodOfClass();

                bool obtained = validator.CompareTwoObjectWithSystemEquals(object1, object2);
                
           
           

        }


        [TestMethod]        
        public void ValidateObjects_WithOverridenEqualsMethod_AreEqual()
        {



            OverriddenMethodEqualsOfClass object1 = new OverriddenMethodEqualsOfClass();
            OverriddenMethodEqualsOfClass object2 = new OverriddenMethodEqualsOfClass();

            bool obtained = validator.CompareTwoObjectWithOverridenEquals(object1, object2);

            Assert.AreEqual(obtained, true);


        }







    }
}
