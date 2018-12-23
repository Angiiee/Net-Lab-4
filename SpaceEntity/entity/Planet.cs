using System;
using System.Collections.Generic;

namespace SpaceEntity.entity
{
    public class Planet
    {
        private string name;
        private List<Ocean> oceans;
        private List<Continent> continents;
        private List<Island> islands;

        public List<Ocean> Oceans { get => oceans; set => oceans = value; }
        public List<Continent> Continents { get => continents; set => continents = value; }
        public List<Island> Islands { get => islands; set => islands = value; }
        public string Name { get => name; set => name = value; }

        public Planet()
        {
            Oceans = new List<Ocean>();
            Continents = new List<Continent>();
            Islands = new List<Island>();
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
            return "I'm a planet. My name is " + Name;
        }

        public void printToConsoleName()
        {
            Console.WriteLine(ToString());
        }

        public void printToConsoleContinentNumber()
        {
            string continentsInfo = ". I have " + Continents.Count + " continents. ";
            foreach(Continent con in Continents)
            {
                continentsInfo += con.ToString() + " ";
            }
            Console.WriteLine(ToString() + continentsInfo);
        }
    }
}
