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
    }
}
