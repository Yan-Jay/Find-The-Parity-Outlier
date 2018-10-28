using FindTheParityOutlier;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FindTheParityOutlierTests
{
    [TestClass()]
    public class KataTests
    {
        [TestMethod()]
        public void OnlyOddNumber()
        {
            int[] input = { 2, 4, 0, 100, 4, 11, 2602, 36 };
            var actual = new Kata().Find(input);
            var expect = 11;
            Assert.AreEqual(expect, actual);
        }
        [TestMethod()]
        public void OnlyEvenNumber()
        {
            int[] input = { 160, 3, 1719, 19, 11, 13, -21 };
            var actual = new Kata().Find(input);
            var expect = 160;
            Assert.AreEqual(expect, actual);
        }
        [TestMethod()]
        public void AllOddNumber()
        {
            int[] input = { 2, 4, 0, 100, 4, 12, 2602, 36 };
            var actual = new Kata().Find(input);
            var expect = -1;
            Assert.AreEqual(expect, actual);
        }
        [TestMethod()]
        public void AllEvenNumber()
        {
            int[] input = { 161, 3, 1719, 19, 11, 13, -21 };
            var actual = new Kata().Find(input);
            var expect = -1;
            Assert.AreEqual(expect, actual);
        }
        [TestMethod()]
        public void NoInput()
        {
            int[] input = { };
            var actual = new Kata().Find(input);
            var expect = -1;
            Assert.AreEqual(expect, actual);
        }
        [TestMethod()]
        public void NullInput()
        {
            int[] input = new int[5];
            var actual = new Kata().Find(input);
            var expect = -1;
            Assert.AreEqual(expect, actual);
        }

    }
}