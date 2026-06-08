using forCodinginterviews._2025_interview_prep.Questions.LeetcodeQuestions.Blind75;
using forCodinginterviews._2025_interview_prep.Questions.LeetcodeQuestions.ImportantPriorityOrder;

class Program
{
    public static void Main(string[] args)
    {
        RunTest();

    }

    public static void RunTest()
    {
        var testCases = new (string first, string second)[]
       {
            ("listen", "silent"),   // true
            ("hello", "bello"),     // false
            ("anagram", "nagaram"), // true
            ("rat", "car")          // false
       };

        foreach (var test in testCases)
        {
            var result = ValidAnagram.ValidAnagramBruteForce(test.first, test.second);
            Console.WriteLine($"{test.first}, {test.second} => {result}");
        }
    }
}