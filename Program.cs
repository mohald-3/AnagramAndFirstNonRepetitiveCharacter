namespace AnagramAndFirstNonRepetitiveCharacter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anagram Code Test");

            var input1 = new List<string> { "listen", "silent", "enlist", "rat", "tar", "art", "evil", "vile", "live" };
            var input2 = new List<string> { "abc", "cab", "bca", "zzz", "x" };
            var input3 = new List<string> {"one", "two", "neo", "eon", "notanagram", "wtf", "ftw"};

            var result1 = Anagram.GroupAnagrams(input1);
            var result2 = Anagram.GroupAnagrams(input2);
            var result3 = Anagram.GroupAnagrams(input3);

            Console.WriteLine("Test 1");
            Anagram.PrintGroupAnagrams(result1);
            Console.WriteLine("\nTest 2");
            Anagram.PrintGroupAnagrams(result2);
            Console.WriteLine("\nTest 3");
            Anagram.PrintGroupAnagrams(result3);


        }
    }
}
