using System.Linq;

namespace System
{
    public static class StringExtensions
    {
        public static string Shorten(this string str, int numWords)
        {
            if (numWords < 0)
            {
                throw new ArgumentOutOfRangeException("Number of words must be >= 0");
            }

            var strList = str.Split(' ');
            if (strList.Length <= numWords)
            {
                return str;
            }

            return string.Join(" ", strList.Take(numWords)) + "...";
        }
    }
}
