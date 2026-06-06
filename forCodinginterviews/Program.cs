using forCodinginterviews._2025_interview_prep.Questions.LeetcodeQuestions.Blind75;
using forCodinginterviews._2025_interview_prep.Questions.LeetcodeQuestions.ImportantPriorityOrder;

class Program
{
    public static void Main(string[] args)
    {
        RunTest(new int[] { 2, 7, 2, 15 });
  
    }

    public static void RunTest(int[] candies)
    {
        var result = ContainsDuplicate.ContainsDuplicateSolution(candies);
        Console.WriteLine($"Contains duplicate: {result}");
    }
}