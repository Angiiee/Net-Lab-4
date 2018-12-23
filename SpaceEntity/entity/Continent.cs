using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceEntity.entity
{
    public class Continent
    {
        private string name;

        public string Name { get => name; set => name = value; }

        public Continent()
        {
        }

        public Continent(string name)
        {
            Name = name;
        }

        public override bool Equals(object obj)
        {
            var continent = obj as Continent;
            return continent != null &&
                   Name == continent.Name;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name);
        }

        public override string ToString()
        {
            return "I'm a continent. My name is " + Name;
        }
    }
}
