using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    public class Text_Tests
    {
        [Test]
        public void one()
        {
            string test = "one";
            int result = Text.Str.CamelCase(test);
            Assert.AreEqual(1, result);
        }

        [Test]
        public void two()
        {
            string test = "twoWords";
            int result = Text.Str.CamelCase(test);
            Assert.AreEqual(2, result);
        }

        [Test]
        public void empty()
        {
            string test = "";
            int result = Text.Str.CamelCase(test);
            Assert.AreEqual(0, result);
        }
    }
}
