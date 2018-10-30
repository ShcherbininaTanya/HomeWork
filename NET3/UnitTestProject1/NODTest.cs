using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NET3;

namespace NODTests
{
    [TestClass]
    public class NODTest
    {
        [TestMethod]
        public void TestNODEv2()
        {
            int a = 45;
            int b = 15;
            int expected = 15;

            NOD n = new NOD();
            int actual = n.nodEv(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestNODEv3()
        {
            int a = 45;
            int b = 15;
            int c = 10;
            int expected = 5;

            NOD n = new NOD();
            int actual = n.nodEv(a, b, c);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestNODEv4()
        {
            int a = 45;
            int b = 15;
            int c = 10;
            int d = 5;
            int expected = 5;

            NOD n = new NOD();
            int actual = n.nodEv(a, b, c, d);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestNODEv5()
        {
            int a = 55;
            int b = 121;
            int c = 11;
            int d = 22;
            int e = 33;
            int expected = 11;

            NOD n = new NOD();
            int actual = n.nodEv(a, b, c, d, e);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestNODBin()
        {
            int a = 16;
            int b = 8;
            int expected = 8;

            NOD n = new NOD();
            int actual = n.nodBin(a, b);

            Assert.AreEqual(expected, actual);
        }
    }
}
