using forCodinginterviews._2025_interview_prep.Questions.LeetcodeQuestions.Blind75;

class Program
{
    public static void Main(string[] args)
    {
        RunTest();
    }

    public static void RunTest()
    {
        var testCases = new string[]
        {
            // Basic palindrome
            "madam",

            // Basic non-palindrome
            "hello",

            // Uppercase + lowercase
            "Madam",

            // Spaces
            "n u r",

            // Spaces + punctuation
            "A man, a plan, a canal: Panama",

            // Not a palindrome
            "race a car",

            // Single character
            "a",

            // Empty string
            "",

            // Only spaces / special characters
            "   ",

            // Numbers
            "12321",

            // Letters + numbers
            "A1b2b1a",

            // Same letters but different order
            "abca"
        };

        foreach (var test in testCases)
        {
            var result = ValidPalindrome.IsPalindromeoptimized(test);

            Console.WriteLine(
                $"s = \"{test}\" => {result}"
            );
        }
    }
}