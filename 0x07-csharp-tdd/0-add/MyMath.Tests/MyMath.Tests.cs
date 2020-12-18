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
            Assert.AreEqual(MyMath.operations.Add(a, b), 9);
        }

        [Test]
        public void negativesum()
        {
            int a = -3;
            int b = -6;
            Assert.AreEqual(MyMath.Operations.Add(a, b), -9);
        }

        [TesCases(0, 1)]
        [TesCases(1, -9)]
        [TesCases(3, 6)]
        [TesCases(-4, 4)]
        [TesCases(-5, 0)]
        [TesCases(-3, -2)]
        [TesCases(0, 0)]
        [Test]
        public void integers(int a, int b)
        {
            Assert.AreEqual(MyMath.Operations.Add(a, b), a+b);
        }
    }
}
