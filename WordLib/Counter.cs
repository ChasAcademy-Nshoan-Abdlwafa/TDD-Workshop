namespace WordLib
{
    public class Counter
    {
        public static int CharCounter(string input)
        {
            if (input == null)
            {
                throw new ArgumentNullException("input");
            }
            // Returns the amount of characters inside the input string
            return input.Length;
        }
    }
}