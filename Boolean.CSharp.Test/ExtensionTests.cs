using Boolean.CSharp.Main;
using Boolean.CSharp.Main.Misc;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace Boolean.CSharp.Test
{
    [TestFixture]
    public class ExtensionTests
    {
        private Extension _extension;
        public ExtensionTests()
        {
            _extension = new Extension();
        }
        [Test]
        public void TestQuestion1()
        {
            AeroplanePassengerManifest currentListOfPassingers = new AeroplanePassengerManifest();
            Assert.IsTrue(_extension.Question1().FlightDetails(currentListOfPassingers) == currentListOfPassingers.NumberOfPassengers);
        }
        [Test]
        public void TestQuestion2()
        {
            Assert.IsTrue(_extension.Question2() == true);
        }
    }
}
