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
        [TestCase]
        public void Multi()
        {
            MyMath math = new MyMath();
            Assert.AreEqual(220, math.Multi(20, 11));
        }
        [TestCase]
        public void Div()
        {
            MyMath math = new MyMath();
            Assert.AreEqual(2, math.Div(20, 10));
        }

        // Sad Path
        [TestCase]
        public void Add2()
        {
            MyMath math = new MyMath();
            Assert.AreNotEqual(30, math.Add(20, 11));
        }
        [TestCase]
        public void Sub2()
        {
            MyMath math = new MyMath();
            Assert.AreNotEqual(10, math.Sub(10, 10));
        }
        [TestCase]
        public void Multi2()
        {
            MyMath math = new MyMath();
            Assert.AreNotEqual(22, math.Multi(20, 11));
        }
        [TestCase]
        public void Div2()
        {
            MyMath math = new MyMath();
            Assert.AreNotEqual(0, math.Div(10, 10));
        }
    }
}
