using System.Linq;

namespace FindTheParityOutlier
{
    public class Kata
    {
        public int Find(int[] integers)
        {
            if (integers.Length == 0 || (integers.Length == integers.Count(x => x == 0)))
            {
                return -1;
            }
            var odd = integers.Count(x => x % 2 != 0);
            var even = integers.Count(x => x % 2 == 0);
            if (odd == 0 || even == 0)
            {
                return -1;
            }

            return odd > even ? integers.Single(x => x % 2 == 0) : integers.First(x => x % 2 != 0);
        }
    }
}