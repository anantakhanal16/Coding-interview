using System.Security.Cryptography.X509Certificates;

namespace forCodinginterviews._2025_interview_prep.Questions.LeetcodeQuestions.Blind75
{
    //    1. Brute-force idea

    //The easiest way is:

    //Remove characters we don't care about.
    //Convert to lowercase.
    //Reverse the string.
    //Compare original vs reversed.
    public static class ValidPalindrome
    {
        public static bool IsPalindromeBruteForce(string inputString)
        {
            string cleaned = "";
            foreach (char c in inputString)
            {
                if (char.IsLetterOrDigit(c))
                {
                    cleaned += char.ToLower(c);
                }
            }

            string reversed = new string(cleaned.Reverse().ToArray());
            if (cleaned == reversed)
            {
                return true;
            }
            return false;
        }

        //optimized 
        //moving pointers
        public static bool IsPalindromeoptimized(string inputString)
        {
            int left = 0;
            int right = inputString.Length - 1;
            while (left < right)
            {
                //skippping non characters from left
                if (!char.IsLetterOrDigit(inputString[left]))
                {
                    left++;
                    continue;
                }
                if (!char.IsLetterOrDigit(inputString[right]))
                {

                    right--;
                    continue;
                }
                var leftString = inputString[left].ToString();

                var rightString = inputString[right].ToString();
                //compare characters 
                if (char.ToLower(inputString[left]) 
                    != char.ToLower(inputString[right]))
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
            
        }
    }
}
