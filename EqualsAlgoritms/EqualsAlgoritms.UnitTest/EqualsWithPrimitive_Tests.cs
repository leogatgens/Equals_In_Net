using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EqualsAlgoritms.UnitTest
{
    [TestClass]
    public class EqualsWithPrimitive_Tests
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

      
            string word1 = "Hello" ;
            string word2 = "Hello" ;

            var obtained = validator.CompareStringsWithEqualsMethod(word1 ,word2 );
            bool expected = true;
            Assert.AreEqual(obtained,expected );
            
        }
        [TestMethod]
        [ExpectedException(typeof(System.Exception))]
        public void ValidateStringsValues_WithEqualsMethod_Exception()
        {

            
            string word1 = "Diferent";
            string word2 = "Words";

            var obtained = validator.CompareStringsWithEqualsMethod(word1, word2);
            

        }



        [TestMethod]
        public void ValidateStringsValues_WithEqualsOperator_AreEqual()
        {           
            string word1 = "Hello";
            string word2 = "Hello";
            var obtained = validator.CompareStringsWithEqualsOperator (word1, word2);

            bool expected = true;
            Assert.AreEqual(obtained, expected);

        }

         
        [TestMethod]
        [ExpectedException(typeof(System.Exception ))]
        public void ValidateStringsValues_WithEqualsOperator_AreNotEqual()
        {            
            string word1 = "Diferents";
            string word2 = "Words";
            
            var result = validator.CompareStringsWithEqualsOperator (word1, word2);
            

        }
    
}
}
