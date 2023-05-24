using System.Diagnostics.Metrics;
using System.Drawing;
using WordLib;

namespace WordLibTests
{
    [TestClass]
    public class WorderTests
    {
        [TestMethod]
        public void IsPalindrome_GivenPalindromeString_ShouldReturnSameString()
        {
            // Arrange
            Worder worder = new Worder();
            string entry = "radar";

            // Act
            var actual = Worder.IsPalindrome(entry);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void IsPalindrome_GivenNonPalindromeString_ShouldReturnPalindromeString()
        {
            // Arrange
            Worder worder = new Worder();
            string entry = "test";

            // Act
            var actual = Worder.IsPalindrome(entry);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void IsPalindrome_GivenNullString_ShouldThrowNullException()
        {
            // Arrange
            Worder worder = new Worder();
            string entry = null;

            // Act
            // Assert
            Assert.ThrowsException<ArgumentNullException>(() => Worder.IsPalindrome(entry));
        }
    }

    [TestClass]
    public class CounterTests
    {
        [TestMethod]
        public void CharCounter_GivenString_ShouldReturnAmountOfCharacters()
        {
            // Arrange
            Counter counter = new Counter();
            string entry = "radar";
            int expected = 5;

            // Act
            var actual = Counter.CharCounter(entry);

            // Assert
            Assert.AreEqual(expected, actual);
            
        }

        [TestMethod]
        public void CharCounter_GivenComplexString_ShouldReturnAmountOfCharacters()
        {
            // Arrange
            Counter counter = new Counter();
            string entry = "Hello! I am 23 years old.";
            int expected = 25;

            // Act
            var actual = Counter.CharCounter(entry);

            // Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void CharCounter_GivenNullString_ShouldThrowNullException()
        {
            // Arrange
            Counter counter = new Counter();
            string entry = null;

            // Act
            // Assert
            Assert.ThrowsException<ArgumentNullException>(() => Counter.CharCounter(entry));
        }
    }
}