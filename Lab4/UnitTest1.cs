using NUnit.Framework;
using SpaceEntity.entity;
using System.Collections.Generic;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            Planet pl = new Planet();
            pl.Name = "Angie";
            Continent con1 = new Continent();
            con1.Name = "Australia";
            Continent con2 = new Continent();
            con2.Name = "Antarctida";
            pl.Continents = new List<Continent>() {con1, con2};
            pl.printToConsoleName();
            pl.printToConsoleContinentNumber();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}