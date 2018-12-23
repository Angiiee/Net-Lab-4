using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceEntity.entity
{
    public class Ocean
    {
        private string name;

        public string Name { get => name; set => name = value; }

        public Ocean()
        {
        }

        public Ocean(string name)
        {
            Name = name;
        }

        public override bool Equals(object obj)
        {
            var ocean = obj as Ocean;
            return ocean != null &&
                   Name == ocean.Name;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name);
        }

        public override string ToString()
        {
            return "I'm an ocean. My name is " + Name;
        }
    }
}
