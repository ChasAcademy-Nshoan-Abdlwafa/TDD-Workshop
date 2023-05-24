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
            string expected = "radar"; 

            // Act
            var actual = worder.IsPalindrome(entry);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsPalindrome_GivenNonPalindromeString_ShouldReturnPalindromeString()
        {
            // Arrange
            Worder worder = new Worder();
            string entry = "test";
            string expected = "tset";

            // Act
            var actual = worder.IsPalindrome(entry);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsPalindrome_GivenNullString_ShouldThrowNullException()
        {
            // Arrange
            Worder worder = new Worder();
            string entry = null;
            string expected = null;

            // Act
            Assert.ThrowsException<ArgumentNullException>(() => worder.IsPalindrome(entry));
            string? actual = null;

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}