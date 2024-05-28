namespace HackerRank.Week1
{
    internal static class FlippingBits
    {
        public static long flippingBits(long n)
        {
            if (n < 0 || n > 4294967295)
            {
                throw new ArgumentOutOfRangeException(nameof(n), "Input must be a 32-bit unsigned integer.");
            }

            uint flipped = ~((uint)n);
            return (long)flipped;
        }
    }
}
