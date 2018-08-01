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
            var @class = obj as OverriddenMethodEqualsOfClass;
            return @class != null &&
                   Name == @class.Name;
        }
    }
}