using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NET_5_2;

namespace UnitTestProject1
{
    [TestClass]
    public class mnch_test
    {
        [TestMethod]
        public void sum()
        {
            mnogochlen m1 = new mnogochlen(1, 1, 1);
            mnogochlen m2 = new mnogochlen(2, 2, 2);
            mnogochlen expected = new mnogochlen(3, 3, 3);
            mnogochlen actual = new mnogochlen();
            actual = m1 + m2;
            Assert.ReferenceEquals(expected, actual);
        }

        [TestMethod]
        public void minus()
        {
            mnogochlen m1 = new mnogochlen(3, 3, 3);
            mnogochlen m2 = new mnogochlen(2, 2, 2);
            mnogochlen expected = new mnogochlen(1, 1, 1);
            mnogochlen actual = new mnogochlen();
            actual = m1 - m2;
            Assert.ReferenceEquals(expected, actual);
        }

        [TestMethod]
        public void umn_ch()
        {
            mnogochlen m1 = new mnogochlen(1, 2, 3);
            int ch = 3;
            mnogochlen expected = new mnogochlen(3, 6, 6);
            mnogochlen actual = new mnogochlen();
            actual = m1 * ch;
            Assert.ReferenceEquals(expected, actual);
        }
    }
}
