using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Similaritipsum.Services
{
    internal class TextServices
    {
        /// <summary>
        /// method that removes all special characters and numbers but leaves whitespaces and letters A-Z, a-z and numbers in string
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string RemoveSpecialCharacters(string s)
        {
            return Regex.Replace(s, "[^ a-zA-Z_]+", "", RegexOptions.Compiled);
        }

        /// <summary>
        ///  The Damereau-Levenshein Distance algorithm calculates the number of letter additions, subtractions, substitutions,
        /// and transpositions (swaps) necessary to convert one string to another.
        /// The lower the score, the more similar they are
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <returns>Returns levenstein distance between two strings</returns>
        public static int LevensteinDistance(string s, string t)
        {
            if (string.IsNullOrEmpty(s))
            {
                if (string.IsNullOrEmpty(t))
                    return 0;
                return t.Length;
            }

            if (string.IsNullOrEmpty(t))
            {
                return s.Length;
            }

            int n = s.Length;
            int m = t.Length;
            int[,] d = new int[n + 1, m + 1];

            for (int i = 0; i <= n; d[i, 0] = i++) ;
            for (int j = 1; j <= m; d[0, j] = j++) ;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= m; j++)
                {
                    int cost = (t[j - 1] == s[i - 1]) ? 0 : 1;
                    int min1 = d[i - 1, j] + 1;
                    int min2 = d[i, j - 1] + 1;
                    int min3 = d[i - 1, j - 1] + cost;
                    d[i, j] = Math.Min(Math.Min(min1, min2), min3);
                }
            }
            return d[n, m];
        }
    }
}
