using forCodinginterviews._2025_interview_prep.Questions.LeetcodeQuestions.Blind75;
using forCodinginterviews._2025_interview_prep.Questions.LeetcodeQuestions.ImportantPriorityOrder;

class Program
{
    public static void Main(string[] args)
    {
        RunTest(new int[] { 2, 7, 11, 15 }, 9);
        RunTest(new int[] { 3, 2, 4 }, 6);
        RunTest(new int[] { 3, 3 }, 6);

    }

    public static void RunTest(int[] candies, int target)
    {
        var result = TwoSum.TwoSumOptimized(candies, target);
      
    }
}