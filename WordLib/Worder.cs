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
            // Joins the characters inside the empty string
            return string.Join(string.Empty, input.Reverse()) == input;
        }
    }
}