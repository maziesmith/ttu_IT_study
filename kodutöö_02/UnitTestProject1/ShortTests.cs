using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShortTests {
    [TestClass]
    public class ShortTests {
        [TestMethod]
        public void ShortMaxValueTest () {
            Assert.AreEqual(32767, short.MaxValue);
        }

        [TestMethod]
        public void ShortMinValueTest () {
            Assert.AreEqual(-32768, short.MinValue);
        }

        [TestMethod]
        public void ShortParseTest () {
            string maxValue = short.MaxValue.ToString();

            Assert.AreEqual(short.MaxValue, short.Parse(maxValue));
        }

        [TestMethod]
        public void ShortTryParseTest () {
            short u1;

            Assert.IsFalse(short.TryParse("99999999", out u1));
            Assert.IsTrue(short.TryParse("1337", out u1));
        }
    }
}
