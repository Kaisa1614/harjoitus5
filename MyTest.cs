using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace harjoitus5
{
    [TestFixture]

    class MyTest
    {
        [TestCase]
        public void Add()
        {
            Math math = new Math();
            Assert.AreEqual(31, math.Add(20, 11));
        }

        [TestCase]
        public void sub()
        {
            Math math = new Math();
            Assert.AreEqual(10, math.Sub(20, 10));
        }

        [TestCase]
        public void mutlti()
        {
            Math math = new Math();
            Assert.AreEqual(10, math.Multi(2, 5));
        }

        [TestCase]
        public void divide()
        {
            Math math = new Math();
            Assert.AreEqual(7, math.Divide(14, 2));
        }

    }
}
