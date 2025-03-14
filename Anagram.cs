using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnagramAndFirstNonRepetitiveCharacter
{
    public static class Anagram
    {
        public static List<List<string>> GroupAnagrams(List<string> words)
        {
            
            var anagramGroups = new Dictionary<string, List<string>>(); // Keys are letters, value is a list of words

            foreach (string word in words)
            {
                // Sort the characters in the word
                string sorted = string.Concat(word.OrderBy(letter => letter));

                // If this sorted string isn't in the dictionary, add it.
                if (!anagramGroups.ContainsKey(sorted))
                {
                    anagramGroups[sorted] = new List<string>();
                }

                // Add the original word to the corresponding list.
                anagramGroups[sorted].Add(word);
            }

            return anagramGroups.Values.ToList();
        }

        public static void PrintGroupAnagrams(List<List<string>> anagramGroups)
        {
            // anagramGroups is a List<List<string>>
            foreach (var group in anagramGroups)
            {
                // group is a List<string>
                Console.WriteLine($"[{string.Join(", ", group.Select(word => $"\"{word}\""))}]");

            }
        }
    }
}
