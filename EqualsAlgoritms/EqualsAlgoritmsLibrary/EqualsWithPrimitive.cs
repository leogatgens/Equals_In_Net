using System;
using System.Collections.Generic;
using System.Text;

namespace EqualsAlgoritmsLibrary
{
    public class EqualsWithPrimitive
    {
        public Boolean CompareStringsWithEqualsMethod(string word1, string word2)
        {
            bool areEqualsWords = false;
            if (word1.Equals(word2))
            {
                areEqualsWords = true;
            }
            else {
                throw new Exception("WTF not equal");
            }
            return areEqualsWords;
        }


        public Boolean CompareStringsWithEqualsOperator(string word1, string word2)
        {
            bool areEqualsWords = false;
            if (word1 == word2)
            {
                areEqualsWords = true;
            }
            else
            {
                throw new Exception("WTF not equal");
            }
            return areEqualsWords;
        }
    }
}
