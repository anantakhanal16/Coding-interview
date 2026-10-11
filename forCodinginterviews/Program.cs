
using System;
using forCodinginterviews._2025_interview_prep.Questions.LeetcodeQuestions.Blind75;

class Program
{
    public static void Main(string[] args)
    {
        RunTest();
    }

    public static void RunTest()
    {
        var testCases = new (int[] Prices, int Expected)[]
        {
            // 1. Basic example
            (new[] { 7, 1, 5, 3, 6, 4 }, 5),

            // 2. Prices always decrease
            (new[] { 7, 6, 4, 3, 1 }, 0),

            // 3. Buy at the beginning, sell at the end
            (new[] { 1, 2, 3, 4, 5 }, 4),

            // 4. Only two prices: profitable
            (new[] { 1, 5 }, 4),

            // 5. Only two prices: not profitable
            (new[] { 5, 1 }, 0),

            // 6. Single day
            (new[] { 5 }, 0),

            // 7. Empty array
            (Array.Empty<int>(), 0),

            // 8. All prices are equal
            (new[] { 3, 3, 3, 3 }, 0),

            // 9. Minimum price occurs in the middle
            (new[] { 5, 4, 1, 6, 3 }, 5),

            // 10. Minimum price occurs after the maximum
            (new[] { 3, 2, 6, 1, 4 }, 4),

            // 11. Large profit
            (new[] { 1, 100 }, 99),

            // 12. Small price changes
            (new[] { 2, 4, 1 }, 2),

            // 13. Best profit occurs before the final day
            (new[] { 1, 5, 2, 3 }, 4),

            // 14. Lowest price at the end
            (new[] { 5, 4, 3, 2, 1 }, 0),

            // 15. Multiple possible profits
            (new[] { 2, 1, 2, 1, 3 }, 2),

            // 16. Buy at 2 and sell at 6
            (new[] { 3, 2, 6, 1, 4 }, 4),

            // 17. Larger values
            (new[] { 100, 180, 260, 310, 40, 535, 695 }, 655)
        };

        foreach (var test in testCases)
        {
            var result = BestTimeToBuyandSellStocks.MaxProfitOptimized(test.Prices);

            Console.WriteLine(
                $"Prices = [{string.Join(", ", test.Prices)}] " +
                $"=> Actual: {result}, Expected: {test.Expected}, " +
                $"Passed: {result == test.Expected}"
            );
        }
    }
}
