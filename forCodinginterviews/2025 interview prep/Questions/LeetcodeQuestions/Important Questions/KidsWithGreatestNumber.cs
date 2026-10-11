using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forCodinginterviews._2025_interview_prep.Questions.LeetcodeQuestions.Blind75
{
    public static  class KidsWithGreatestNumber
    {
        public static List<string> KidswithCandies(int[] candies, int extraCandies)
        {
            int max = 0;
            foreach (int candy in candies)
            {
                if (candy > max)
                {
                    max = candy;
                }
            }

            List<string> result = new List<string>();
            foreach (int candy in candies) 
            {
                result.Add((candy + extraCandies >= max).ToString().ToLower());
            }
            
            return result;
        }
    }
}
