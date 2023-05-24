using WordLib;

namespace WordLibTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BasicWorderTest()
        {
            // Instance to be tested
            Worder worder = new Worder();

            // Values are defined for both test input and output
            string expectedResult = "radar";
            string input = expectedResult;

            // Method is run under the test
            string actualResult = worder.IsPalidrome(input);

            // Result is verified
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}