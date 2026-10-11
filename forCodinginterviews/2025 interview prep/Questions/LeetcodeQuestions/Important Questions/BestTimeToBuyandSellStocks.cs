using System.Diagnostics;

namespace forCodinginterviews._2025_interview_prep.Questions.LeetcodeQuestions.Blind75
{
    public static  class BestTimeToBuyandSellStocks
    {
        public static int BuyAndSellStockBruteForce(int[] stockDays)
        {

            int maxProfit = 0;
            for (int i=0; i < stockDays.Length; i++)
            {
                for (int j= i+1; j < stockDays.Length; j++)
                {
                    var broughtAt = stockDays[i];
                    var soldAt = stockDays[j];

                    int profit =  stockDays[j]- stockDays[i];
                    if (profit > maxProfit)
                    {
                        maxProfit = profit;
                    }

                }
            }
            return maxProfit;
        }

        public static int MaxProfitOptimized(int[] prices)
        {
            if (prices == null || prices.Length < 2)
                return 0;
            int minPrice = prices[0];
            int maxProfit = 0;
            foreach (var price in prices)
            {
                if (price < minPrice)
                {
                    minPrice = price;
                }
                else 
                {
                    int profit = price - minPrice;
                    if (profit > maxProfit)
                    {
                        maxProfit = profit;
                    }
                }
            }
            return maxProfit;
        }

    }
}
