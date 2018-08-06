using System;

namespace EqualsAlgoritms.UnitTest
{
    public  class OverriddenMethodEqualsOfClass
    {
        public string Name
        { get; set; }


        public OverriddenMethodEqualsOfClass()
        {
            Name = "overriden";
        }

        public override bool Equals(object obj)
        {
            return obj is OverriddenMethodEqualsOfClass @class &&
                   Name == @class.Name;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }
}