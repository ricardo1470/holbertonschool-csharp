using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    public class SumTest
    {
        [Test]
        public void sum()
        {
            int a = 4;
            int b = 5;
            Assert.AreEqual(9, MyMath.Operations.Add(a, b));

        }

        [Test]
        public void negativesum()
        {
            int a = -3;
            int b = -6;
            Assert.AreEqual(-9, MyMath.Operations.Add(a, b));
        }

        [TestCase(0, 1)]
        [TestCase(1, -9)]
        [TestCase(3, 6)]
        [TestCase(-4, 4)]
        [TestCase(-5, 0)]
        [TestCase(-3, -2)]
        [TestCase(0, 0)]
        public void integers(int a, int b)
        {
            Assert.AreEqual(a + b, MyMath.Operations.Add(a, b));
        }
    }
}
