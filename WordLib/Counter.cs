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
            return input.Length;
        }
    }
}