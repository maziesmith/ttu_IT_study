using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using Tasks;

namespace Tests.Tasks {
    [TestClass]
    public class Week1Tests {
        [TestMethod]
        public void Puzzle1Test() {
            Assert.AreEqual("abc", Week1.Puzzle1("cba"));
            Assert.AreEqual("", Week1.Puzzle1(null));
        }

        [TestMethod]
        public void Puzzle2Test() {
            Assert.AreEqual(0, Week1.Puzzle2(""));
            Assert.AreEqual(0, Week1.Puzzle2(null));
            Assert.AreEqual(97, Week1.Puzzle2("a"));
            Assert.AreEqual(194, Week1.Puzzle2("aa"));
            Assert.AreEqual(98, Week1.Puzzle2("b"));
            Assert.AreEqual(294, Week1.Puzzle2("abc"));
        }

        [TestMethod]
        public void Puzzle3Test() {
            Assert.AreEqual("", Week1.Puzzle3(""));
            Assert.AreEqual("", Week1.Puzzle3(null));
            Assert.AreEqual("d", Week1.Puzzle3("a"));
            Assert.AreEqual("dd", Week1.Puzzle3("aa"));
            Assert.AreEqual("e", Week1.Puzzle3("b"));
            Assert.AreEqual("def", Week1.Puzzle3("abc"));
            Assert.AreEqual("abc", Week1.Puzzle3("xyz"));
        }

        [TestMethod]
        public void Puzzle4Test() {
            Assert.AreEqual("", Week1.Puzzle4(""));
            Assert.AreEqual("", Week1.Puzzle4(null));
            Assert.AreEqual("a", Week1.Puzzle4("a"));
            Assert.AreEqual("a", Week1.Puzzle4("aa"));
            Assert.AreEqual("b", Week1.Puzzle4("b"));
            Assert.AreEqual("abc", Week1.Puzzle4("abc"));
            Assert.AreEqual("a", Week1.Puzzle4("aaaa"));
            Assert.AreEqual("ab", Week1.Puzzle4("ababa"));
        }

        [TestMethod]
        public void Puzzle5Test() {
            Assert.AreEqual("", Week1.Puzzle5(""));
            Assert.AreEqual("", Week1.Puzzle5(null));
            Assert.AreEqual("97", Week1.Puzzle5("a"));
            Assert.AreEqual("98", Week1.Puzzle5("b"));
            Assert.AreEqual("120", Week1.Puzzle5("x"));
            Assert.AreEqual("9797", Week1.Puzzle5("aa"));
            Assert.AreEqual("120121122", Week1.Puzzle5("xyz"));
        }

        [TestMethod]
        public void Puzzle6Test() {
            Assert.AreEqual(0, Week1.Puzzle6(0));
            Assert.AreEqual(1, Week1.Puzzle6(1));
            Assert.AreEqual(4, Week1.Puzzle6(2));
            Assert.AreEqual(9, Week1.Puzzle6(3));
            Assert.AreEqual(625, Week1.Puzzle6(25));
        }

        [TestMethod]
        public void Puzzle7Test() {
            Assert.AreEqual(0, Week1.Puzzle7(0));
            Assert.AreEqual(2, Week1.Puzzle7(1, 1));
            Assert.AreEqual(15, Week1.Puzzle7(1, 2, 3, 4, 5));
        }

        [TestMethod]
        public void Puzzle8Test() {
            Assert.AreEqual(0, Week1.Puzzle8(0, 0));
            Assert.AreEqual(243, Week1.Puzzle8(121, 122));
        }

        [TestMethod]
        public void Puzzle9Test() {
            Assert.AreEqual(0, Week1.Puzzle9(0));
            Assert.AreEqual(1, Week1.Puzzle9(1, 1));
            Assert.AreEqual(208, Week1.Puzzle9(1, 208, 3, 4, 5));
        }

        [TestMethod]
        public void Puzzle10Test() {
            Assert.AreEqual(0, Week1.Puzzle10(0));
            Assert.AreEqual(-1, Week1.Puzzle10(1));
            Assert.AreEqual(10, Week1.Puzzle10(-10));
        }
    }
}
