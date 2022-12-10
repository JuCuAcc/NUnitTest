using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTest
{
    [TestFixture]
    internal class MyTestCase
    {
        [TestCase]
        public void Add()
        {
            MyMath math = new MyMath();
            Assert.AreEqual(31, math.Add(20, 11));
        }
        [TestCase]
        public void Sub()
        {
            MyMath math = new MyMath();
            Assert.AreEqual(10, math.Sub(20, 10));
        }
    }
}
