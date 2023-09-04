using Boolean.CSharp.Main;
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
            
            Console.WriteLine();
            Assert.IsTrue(_extension.Question1().PassengersNum == 35);
        }
        [Test]
        public void TestQuestion2()
        {
            Assert.IsTrue(_extension.Question2().PassengersNum == 1);
        }
    }
}
