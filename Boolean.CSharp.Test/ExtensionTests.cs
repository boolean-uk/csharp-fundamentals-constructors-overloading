using Boolean.CSharp.Main;
using Boolean.CSharp.Main.Misc;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public void TestQuestion1() //diy testing
        {
            Aeroplane plane = _extension.Question1();
            Assert.IsTrue(plane.Getnumbers() > 0);
        }
        [Test]
        public void TestQuestion2() //diy testing
        {
            Aeroplane plane = _extension.Question2();
            AeroplanePassengerManifest manifest = new AeroplanePassengerManifest();
            int initialNumberOfPassengers = manifest.NumberOfPassengers;
            Assert.AreEqual(initialNumberOfPassengers + 1, plane.Getnumbers());
            Assert.IsTrue(plane._passengerManifest.Passengers.Contains("Dylan Verwimp"));
        }
    }
}
