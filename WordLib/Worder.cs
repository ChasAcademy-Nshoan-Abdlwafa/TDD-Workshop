namespace WordLib
{
    public class Worder
    {
        public static bool IsPalindrome(string input)
        {
            if (input == null)
            {
                throw new ArgumentNullException("input");
            }
            return string.Join(string.Empty, input.Reverse()) == input;
        }
    }
}