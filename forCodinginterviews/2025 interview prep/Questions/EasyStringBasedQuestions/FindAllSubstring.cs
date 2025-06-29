using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace forCodinginterviews._2025_interview_prep.Questions.EasyStringBasedQuestions
{
    // Q.7: How to find all possible substring of a given string?
    //abcd 
    public static class FindAllSubstring
    {
        public static string AllSubstring(string givenString)
        {
            if (string.IsNullOrEmpty(givenString))
                return string.Empty;

            givenString = givenString.ToLower();
            List<string> substrings = new List<string>();

            for (int i = 0; i < givenString.Length; i++)
            {
                string current = string.Empty;
                for (int j = i; j < givenString.Length; j++)
                {
                    current += givenString[j];

                    substrings.Add(current);
                } 
            }

            return string.Join(",", substrings.Distinct());
        }

    }

}
