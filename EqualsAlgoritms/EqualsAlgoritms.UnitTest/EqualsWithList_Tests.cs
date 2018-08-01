using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EqualsAlgoritms.UnitTest
{
    [TestClass]
    public class EqualsWithList_Tests
    {
        private EqualsAlgoritmsLibrary.EqualsWithPrimitive validator;

        [TestInitialize]
        public void TestInit()
        {
            validator = new EqualsAlgoritmsLibrary.EqualsWithPrimitive();
        }

        [TestMethod]
        public void ValidateStringsValues_WithEqualsMethod_AreEqual()
        {


            string word1 = "Hello";
            string word2 = "Hello";

            var obtained = validator.CompareStringsWithEqualsMethod(word1, word2);
            bool expected = true;
            Assert.AreEqual(obtained, expected);

        }
      

    }
}
