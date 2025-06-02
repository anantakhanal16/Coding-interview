using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forCodinginterviews._2025_interview_prep.Questions
{

    public class ReverseString
    {
        public static string ReverseGivenString(string givenSentense)
        {
            var reversedString = string.Empty;
            for (int i = givenSentense.Length - 1; i >= 0; i--)
            {
                reversedString = reversedString + givenSentense[i];
            }

            return reversedString;
        }
    }


}
