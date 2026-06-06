// 1071. Greatest Common Divisor of Strings
// Easy
// Problem:
// For two strings s and t, we say "t divides s"
// if s is formed by repeating t one or more times.
//
// Return the largest string x that divides both str1 and str2.
//
// Example:
// str1 = "ABCABC", str2 = "ABC" → "ABC"
// str1 = "ABABAB", str2 = "ABAB" → "AB"
// str1 = "LEET", str2 = "CODE" → ""

namespace forCodinginterviews._2025_interview_prep.Questions.LeetcodeQuestions.Blind75
{
    public class GreatestCommonDivisorofStrings
    {
        public static string GcdOfStrings(string str1, string str2)
        {
            // Key insight:
            // If two strings have a common divisor string,
            // then str1 + str2 must equal str2 + str1
            if (str1 + str2 != str2 + str1)
            {
                return "";
            }
            // Reduce problem to GCD of lengths
            int gcdLength = Gcd(str1.Length, str2.Length);

            // Answer is prefix of that length
            return str1.Substring(0, gcdLength);
        }

        // Euclidean Algorithm (used for gcd of lengths)
        public static int Gcd(int a, int b)
        {
            // Keep reducing until remainder becomes 0
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }
}