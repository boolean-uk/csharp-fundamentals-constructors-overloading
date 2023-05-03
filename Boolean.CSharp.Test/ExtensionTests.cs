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
        public void TestQuestion1()
        {
            Aeroplane plane = new Aeroplane();
            Assert.IsTrue(plane.FlightDetails(new AeroplanePassengerManifest())>1);
        }

        [Test]
        public void TestQuestion2()
        {
        Assert.Pass();
        }
    }

    }
