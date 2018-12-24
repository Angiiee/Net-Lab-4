using NUnit.Framework;
using NUnit.Framework.Internal;
using SpaceEntity.entity;
using System;
using System.Collections.Generic;
using System.IO;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            StreamWriter standardOut = new StreamWriter(Console.OpenStandardOutput());
            standardOut.AutoFlush = true;
            Console.SetOut(standardOut);
        }

        [Test]
        public void Test1()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                Planet pl = new Planet();
                pl.Name = "Angie";
                pl.printToConsoleName();

                string tmp = "I'm a planet. My name is " + pl.Name + "{0}";
                string expected = string.Format(tmp, Environment.NewLine);
                Assert.AreEqual(expected, sw.ToString());
            }
        }

        [Test]
        public void Test2()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                Planet pl = new Planet();
                pl.Name = "Angie";
                Continent con1 = new Continent();
                con1.Name = "Australia";
                Continent con2 = new Continent();
                con2.Name = "Antarctida";
                pl.Continents = new List<Continent>() { con1, con2 };
                pl.printToConsoleContinentNumber();

                string tmp = "I'm a planet. My name is " + pl.Name + ". I have 2 continents. I'm a continent and my name is " + con1.Name + " I'm a continent and my name is " + con2.Name + " {0}";
                string expected = string.Format(tmp, Environment.NewLine);

                Assert.AreEqual(expected, sw.ToString());
            }
        }
    }
}