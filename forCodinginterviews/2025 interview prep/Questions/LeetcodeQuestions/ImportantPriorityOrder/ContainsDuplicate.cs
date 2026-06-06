using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forCodinginterviews._2025_interview_prep.Questions.LeetcodeQuestions.ImportantPriorityOrder
{
    public static class ContainsDuplicate
    {
        public static bool ContainsDuplicateSolution(int[] nums)
        {
            Dictionary<int ,int> numbersTracker = new Dictionary<int ,int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (numbersTracker.ContainsKey(nums[i]))
                {
                    return true;
                }
                numbersTracker[nums[i]] = i;
            }
            return false;
        }
    }
}
