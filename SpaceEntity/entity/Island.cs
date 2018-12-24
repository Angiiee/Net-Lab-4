using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceEntity.entity
{
    public class Island : Continent
    {

        public Island()
        {
        }

        public Island(string name) : base(name)
        {
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return "I'm an island and my name is " + Name;
        }
    }
}
