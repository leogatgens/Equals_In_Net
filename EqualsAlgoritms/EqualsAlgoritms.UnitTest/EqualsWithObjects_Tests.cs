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
        public void ValidateObjects_WithEqualsMethod_AreEqual()
        {
            try
            {
                

                NoOverriddenEqualsMethodOfClass object1 = new NoOverriddenEqualsMethodOfClass();
                NoOverriddenEqualsMethodOfClass object2 = new NoOverriddenEqualsMethodOfClass();

                bool obtained = validator.CompareTwoObjectWithSystemEquals(object1, object2);
                var expected = new NoOverriddenEqualsMethodOfClass();
                Assert.AreEqual(obtained, expected);
            }
            catch (Exception)
            {

                throw;
            }
           

        }


       

       

    }
}
