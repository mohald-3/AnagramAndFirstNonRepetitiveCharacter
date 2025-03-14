namespace AnagramAndFirstNonRepetitiveCharacter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FirstNonRepetitiveCharacter");

            //test 1
            string input1 = "swiss";
            char result1 = FirstNonRepetitiveCharacter.GetFirstNonRepetitiveCharacter(input1);
            Console.WriteLine($"Input: {input1}  ->  Output: {result1}");

            // Test 2
            string input2 = "racecars";
            char result2 = FirstNonRepetitiveCharacter.GetFirstNonRepetitiveCharacter(input2);
            Console.WriteLine($"Input: {input2}  ->  Output: {result2}");

            // Test 3
            string input3 = "aabb";
            char result3 = FirstNonRepetitiveCharacter.GetFirstNonRepetitiveCharacter(input3);
            Console.WriteLine($"Input: {input3}  ->  Output: {result3}");
        }
    }
}
