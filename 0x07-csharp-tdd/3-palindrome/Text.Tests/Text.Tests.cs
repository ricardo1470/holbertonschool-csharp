using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    public class Text_Tests
    {
        [Test]
        public void isPalindrome()
        {
            string test = "Never odd or even";
            bool result = Text.Str.IsPalindrome(test);
            Assert.AreEqual(true, result);
        }

        [Test]
        public void isNotPalindrome()
        {
            string test = "two";
            bool result = Text.Str.IsPalindrome(test);
            Assert.AreEqual(false, result);
        }

        [Test]
        public void isPalindrome_two()
        {
            string test = "Go hang a salami, I'm a lasagna hog";
            bool result = Text.Str.IsPalindrome(test);
            Assert.AreEqual(true, result);
        }

        [Test]
        public void hasPunctuationReturnsTrue()
        {
            string test = "A man, a plan, a canal: Panama.";
            bool result = Text.Str.IsPalindrome(test);
            Assert.AreEqual(true, result);
        }

        [Test]
        public void namepalimdrome()
        {
            string test = "Anna";
            bool result = Text.Str.IsPalindrome(test);
            Assert.AreEqual(true, result);
        }

        [Test]
        public void textpalimdrome()
        {
            string test = "Dammit I’m Mad";
            bool result = Text.Str.IsPalindrome(test);
            Assert.AreEqual(true, result);
        }

        [Test]
        public void text_palimdrome()
        {
            string test = "Evil is a deed as I live";
            bool result = Text.Str.IsPalindrome(test);
            Assert.AreEqual(true, result);
        }

        [Test]
        public void emptyStringReturnsTrue()
        {
            string test = "";
            bool result = Text.Str.IsPalindrome(test);
            Assert.AreEqual(true, result);
        }
    }
}
