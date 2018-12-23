using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceEntity.entity
{
    public class Island : Continent
    {
        private string name;

        public string Name { get => name; set => name = value; }

        public Island()
        {
        }

        public Island(string name)
        {
            Name = name;
        }

        public override bool Equals(object obj)
        {
            var island = obj as Island;
            return island != null &&
                   Name == island.Name;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name);
        }

        public override string ToString()
        {
            return "I'm an island. My name is " + Name;
        }
    }
}
