namespace forCodinginterviews._2025_interview_prep.Questions.LeetcodeQuestions.ImportantPriorityOrder
{
    public static class ContainsDuplicate
    {
        public static bool ContainsDuplicateSolution(int[] nums)
        {
            HashSet<int> tracker = new HashSet<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (tracker.Contains(nums[i]))
                {
                    return true;
                }
                tracker.Add(nums[i]);
            }
            return false;

        }

        //time 0(n)
        //space 0(n)
        public static bool ContainsDuplicate1(int[] nums)
        {
            HashSet<int> seen = new HashSet<int>();
            foreach (int num in nums)
            {
                if (seen.Contains(num))
                {
                    return true;
                }
                seen.Add(num);
            }
            return false;
        }
    

    }
}
