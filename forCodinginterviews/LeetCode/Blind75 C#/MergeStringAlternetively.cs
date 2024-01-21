/////You are given two strings word1 and word2. Merge the strings by adding letters in alternating order, starting with word1. If a string is longer than the other, append the additional letters onto the end of the merged string.

//Return the merged string.



//Example 1:

//Input: word1 = "abc", word2 = "pqr"
//Output: "apbqcr"
//Explanation: The merged string will be merged as so:
//word1: a b   c
//word2:    p q   r
//merged: a p b q c r
//Example 2:

//Input: word1 = "ab", word2 = "pqrs"
//Output: "apbqrs"
//Explanation: Notice that as word2 is longer, "rs" is appended to the end.
//word1: a b
//word2: p q   r s
//merged: a p b q   r   s
//Example 3:

//Input: word1 = "abcd", word2 = "pq"
//Output: "apbqcd"
//Explanation: Notice that as word1 is longer, "cd" is appended to the end.
//word1: a b   c d
//word2:    p q 
//merged: a p b q c   d

//Constraints:

//1 <= word1.length, word2.length <= 100
//word1 and word2 consist of lowercase English letters.


using System.Text;

namespace forCodinginterviews.LeetCode.Blind75_C_
{
    public class MergeStringAlternetively
    {
        private readonly string word1;
        private readonly string word2;

        public MergeStringAlternetively(string word1, string word2)
        {
            this.word1 = word1;
            this.word2 = word2;
        }

        public string MergeAlternately()
        {
            int index1 = 0;
            int index2 = 0;

            string mergedResult = "";

            int minLength = Math.Min(word1.Length, word2.Length);

            while (index1 != minLength && index2 != minLength)
            {
                mergedResult += word1[index1++];

                mergedResult += word2[index2++];
            }
            while (index1 != word1.Length)
            {
                mergedResult += word1[index1++];
            }
            while (index2 != word2.Length)
            {
                mergedResult += word2[index2++];
            }

            return mergedResult;
        }

    }
}
