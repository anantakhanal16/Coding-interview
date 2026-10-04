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
                        Console.WriteLine("pair found " + numberArray[i] + " and " + numberArray[j]);
                        Console.WriteLine("position " + i + " and " + j);
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

        public static int[] TwoSumOptimized1(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            Console.WriteLine("   ");
            Console.WriteLine($"Array: [{string.Join(", ", nums)}]");

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                Console.WriteLine("============");
                Console.WriteLine("Iteration  = " + i);
                Console.WriteLine("  ");

                Console.WriteLine($"\nIndex: {i}, Number: {nums[i]} , target:{target} , Complement: {complement}");
                Console.WriteLine($"Dictionary before: {string.Join(", ", map.Select(x => $"{x.Key}:{x.Value}"))}");

                if (map.ContainsKey(complement))
                {
                    int firstIndex = map[complement];
                    int secondIndex = i;

                    Console.WriteLine($"FOUND {complement} at index {firstIndex}");

                    Console.WriteLine($"Returning: [{firstIndex}, {secondIndex}]");

                    return new int[] { firstIndex, secondIndex };
                }

                if (!map.ContainsKey(nums[i]))
                {
                    map[nums[i]] = i;
                    Console.WriteLine("  ");
                    Console.WriteLine($"Added: {nums[i]} -> index {i}");
                    Console.WriteLine($"Dictionary after: {string.Join(", ", map.Select(x => $"{x.Key}:{x.Value}"))}");

                }
            }

            Console.WriteLine("No pair found");

            return new int[] { -1, -1 };
        }

        public static int[] TwoSumOptimized(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i=0; i<nums.Length;i++)
            {
                int comp = target - nums[i];

                if (map.ContainsKey(comp))
                {
                    return new int[] { map[comp],i };
                }
                if (!map.ContainsKey(nums[i]))
                {
                    map.Add(nums[i],i);
                }
            }
            return Array.Empty<int>();
        }

    }
}
