using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml;

namespace AnagramAndFirstNonRepetitiveCharacter
{
    public static class FirstNonRepetitiveCharacter
    {
        public static char GetFirstNonRepetitiveCharacter(string text)
        {
            // Dictionary to store counts of each character
            var lettersCount = new Dictionary<char, int>();

            // Iterate through the word, adding unique letters and their appearance increments each time they repeat.
            foreach (char charecter in text)
            {
                if (!lettersCount.ContainsKey(charecter))
                {
                    lettersCount[charecter] = 0;
                }
                lettersCount[charecter]++;
            }

            // I will iterate second time through the word to check which key had a value of 1, returning the key of the first letter that I get.
            foreach (char charecter in text)
            {
                if (lettersCount[charecter] == 1)
                {
                    return charecter;
                }
            }

            // If nothing was returned, return the value “_”.
            return '_';
        }
    }
}
