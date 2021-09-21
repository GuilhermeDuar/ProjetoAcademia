using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace BusinessLogicalLayer
{
    public class Normatization
    {
        public static string NormatizeString(string word, bool singleName)
        {
            word = word.Trim();
            if (singleName)
            {
                word = Regex.Replace(word, @"\s+", "");
            }
            else
            {
                word = Regex.Replace(word, @"\s+", " ");
            }
            TextInfo textInfo = Thread.CurrentThread.CurrentCulture.TextInfo;
            word = textInfo.ToTitleCase(word);
            return word;
        }
    }
}
