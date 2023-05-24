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
}