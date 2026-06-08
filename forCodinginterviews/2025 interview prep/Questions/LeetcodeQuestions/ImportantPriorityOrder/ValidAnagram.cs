using static System.Runtime.InteropServices.JavaScript.JSType;

namespace forCodinginterviews._2025_interview_prep.Questions.LeetcodeQuestions.ImportantPriorityOrder
{
    public static class ValidAnagram
    {
        public static bool ValidAnagramBruteForce(string firstString, string secoandString)
        {
            if (firstString.Length != secoandString.Length)
                return false;

            Dictionary<char, int> firstStringLetterCount = new Dictionary<char, int>();
            for (int i = 0; i < firstString.Length; i++)
            {
                if (firstStringLetterCount.ContainsKey(firstString[i]))
                {
                    firstStringLetterCount[firstString[i]]++;
                }
                else
                {
                    firstStringLetterCount[firstString[i]] = 1;
                }
            }

            Dictionary<char, int> secoandStringCharCount = new Dictionary<char, int>();
            for (int i = 0; i < secoandString.Length; i++)
            {
                if (secoandStringCharCount.ContainsKey(secoandString[i]))
                {
                    secoandStringCharCount[secoandString[i]]++;
                }
                else
                {
                    secoandStringCharCount[secoandString[i]] = 1;
                }
            }

            foreach (KeyValuePair<char, int> item in firstStringLetterCount)
            {
                if (!secoandStringCharCount.ContainsKey(item.Key))
                    return false;

                if (secoandStringCharCount[item.Key] != item.Value)
                    return false;
            }

            return true;
        }

        public static bool ValidAnagramOptimized(string firstString, string secondString)
        {
            if (firstString.Length != secondString.Length)
            {
                return false;
            }

            Dictionary<char, int> map = new Dictionary<char, int>();

            // Count characters from first string
            foreach (char c in firstString)
            {
                if (map.ContainsKey(c))
                {
                    map[c]++;
                }
                else
                {
                    map[c] = 1;
                }
            }

            // Decrease count using second string
            foreach (char c in secondString)
            {
                if (!map.ContainsKey(c))
                {
                    return false;
                }

                map[c]--;

                if (map[c] < 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
