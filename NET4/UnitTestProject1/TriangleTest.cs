using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NET4;

namespace TriangleTests
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void TestP()
        {
            int a = 10;
            int b = 15;
            int c = 20;
            int expected = 45;

            triangle t = new triangle();
            t.a = a;
            t.b = b;
            t.c = c;
            int actual = t.Perimetr();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestS()
        {
            int a = 3;
            int b = 4;
            int c = 5;
            double expected = 6;

            triangle t = new triangle();
            t.a = a;
            t.b = b;
            t.c = c;
            double actual = t.Ploshad();

            Assert.AreEqual(expected, actual);
        }
    }
}
