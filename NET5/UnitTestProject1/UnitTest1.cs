using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NET5;

namespace UnitTestProject1
{
    [TestClass]
    public class vectorTest
    {
        [TestMethod]
        public void sum()
        {
            vector v1 = new vector(1, 1, 1);
            vector v2 = new vector(2, 2, 2);
            vector expected = new vector(3, 3, 3);
            vector actual = new vector();
            actual = v1 + v2;
            Assert.ReferenceEquals(expected, actual);
        }

        [TestMethod]
        public void minus()
        {
            vector v1 = new vector(3, 3, 3);
            vector v2 = new vector(2, 2, 2);
            vector expected = new vector(1, 1, 1);
            vector actual = new vector();
            actual = v1 - v2;
            Assert.ReferenceEquals(expected, actual);
        }

        [TestMethod]
        public void umn_ch()
        {
            vector v1 = new vector(1, 2, 3);
            int ch = 3;
            vector expected = new vector(3, 6, 6);
            vector actual = new vector();
            actual = v1 * ch;
            Assert.ReferenceEquals(expected, actual);
        }

        [TestMethod]
        public void umn()
        {
            vector v1 = new vector(1, 2, 3);
            vector v2 = new vector(2, 2, 2);
            int expected = 12;
            int actual = v1 * v2;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void dlina_test()
        {
            vector v1 = new vector(1, 2, 3);
            double expected = 3.74;
            double actual = Math.Round(v1.dlina(), 2);
            Assert.AreEqual(expected, actual);
        }
    }
}
