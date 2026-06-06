using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace forCodinginterviews._2025_interview_prep.Questions.LeetcodeQuestions.ImportantPriorityOrder
{
    public static class TwoSum
    {
        //bruteforce
        public static int[] TwoSumSolutionBruteForce(int[] numberArray, int target)
        {
            int sum = 0;

            for (int i = 0; i < numberArray.Length; i++)
            {
                sum = numberArray[i];
                for (int j = i + 1; j < numberArray.Length; j++)
                {
                    var resultNumber = sum + numberArray[j];
                   
                    if (resultNumber == target)
                    {
                        Console.WriteLine("pair found "+ numberArray[i] + " and " + numberArray[j]);
                        Console.WriteLine("position "+ i + " and " + j);
                    }
                }
            }
        
          
            return null;
        }

        //optimized solution using dictionary

        public static int[] TwoSumoptimized(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];

                if (map.ContainsKey(complement))
                {
                    return new int[] { map[complement], i };
                }
                if (!map.ContainsKey(nums[i]))
                {
                    map[nums[i]] = i;
                }
            }
            return new int[] { -1, -1 };
        }
    }
}
