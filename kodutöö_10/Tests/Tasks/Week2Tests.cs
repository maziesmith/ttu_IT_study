using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using Tasks;

namespace Tests.Tasks {
    [TestClass]
    public class Week2Tests {
        [TestMethod]
        public void Puzzle1Test() {
            Assert.AreEqual('c', Week2.Puzzle1(5, 'a', 'b', 'c'));
            Assert.AreEqual('b', Week2.Puzzle1(1, 'a', 'b', 'c'));
            Assert.AreEqual('x', Week2.Puzzle1(2, 'x', 'y', 'x', 'a', 'b'));
        }

        [TestMethod]
        public void Puzzle2Test() {
            Assert.AreEqual('\0', Week2.Puzzle2(5, null));
            Assert.AreEqual('\0', Week2.Puzzle2(5, new char[] { }));
            Assert.AreEqual('b', Week2.Puzzle2(1, new[] { 'a', 'b', 'c' }));
            Assert.AreEqual('b', Week2.Puzzle2(1, new[] { 'a', 'b', 'c' }));
            Assert.AreEqual('b', Week2.Puzzle2(4, new[] { 'x', 'y', 'x', 'a', 'b' }));
        }

        [TestMethod]
        public void Puzzle3Test() {
            int x;

            x = 4;
            Week2.Puzzle3(ref x);
            Assert.AreEqual(16, x);

            x = 5;
            Week2.Puzzle3(ref x);
            Assert.AreEqual(25, x);
        }

        [TestMethod]
        public void Puzzle4Test() {
            int x;

            x = 4;
            Week2.Puzzle4(x);
            Assert.AreEqual(4, x);

            x = 5;
            Week2.Puzzle4(x);
            Assert.AreEqual(5, x);
        }

        [TestMethod]
        public void Puzzle5Test() {
            int x;

            Week2.Puzzle5(4, out x);
            Assert.AreEqual(16, x);

            Week2.Puzzle5(5, out x);
            Assert.AreEqual(25, x);
        }

        [TestMethod]
        public void Puzzle6Test() {
            Assert.AreEqual(16, Week2.Puzzle6(4));
            Assert.AreEqual(25, Week2.Puzzle6(5));
        }

        [TestMethod]
        public void Puzzle7Test() {
            Assert.AreEqual(1, Week2.Puzzle7(0));
            Assert.AreEqual(1, Week2.Puzzle7(1));
            Assert.AreEqual(2, Week2.Puzzle7(2));
            Assert.AreEqual(6, Week2.Puzzle7(3));
            Assert.AreEqual(24, Week2.Puzzle7(4));
            Assert.AreEqual(120, Week2.Puzzle7(5));
            Assert.AreEqual(720, Week2.Puzzle7(6));
        }

        [TestMethod]
        public void Puzzle8Tests() {
            Assert.AreEqual("", Week2.Puzzle8(null));
            Assert.AreEqual("", Week2.Puzzle8(string.Empty));
            Assert.AreEqual("a", Week2.Puzzle8("a"));
            Assert.AreEqual("cba", Week2.Puzzle8("abc"));
        }

        [TestMethod]
        public void Puzzle9Tests() {
            Assert.AreEqual(false, Week2.Puzzle9(null));
            Assert.AreEqual(false, Week2.Puzzle9(string.Empty));
            Assert.AreEqual(true, Week2.Puzzle9("a"));
            Assert.AreEqual(true, Week2.Puzzle9("anna"));
            Assert.AreEqual(false, Week2.Puzzle9("beta"));
            Assert.AreEqual(true, Week2.Puzzle9("123454321"));
        }

        [TestMethod]
        public void Puzzle10Tests() {
            Assert.AreEqual(0, Week2.Puzzle10(0));
            Assert.AreEqual(1, Week2.Puzzle10(1));
            Assert.AreEqual(2, Week2.Puzzle10(2));
            Assert.AreEqual(3, Week2.Puzzle10(3));
            Assert.AreEqual(5, Week2.Puzzle10(4));
            Assert.AreEqual(8, Week2.Puzzle10(5));
            Assert.AreEqual(13, Week2.Puzzle10(6));
            Assert.AreEqual(21, Week2.Puzzle10(7));
            Assert.AreEqual(34, Week2.Puzzle10(8));
        }
    }
}