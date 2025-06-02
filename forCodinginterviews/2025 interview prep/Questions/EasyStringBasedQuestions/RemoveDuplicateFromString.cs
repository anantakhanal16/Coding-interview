using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace forCodinginterviews._2025_interview_prep.Questions.Easy
{
    public static class RemoveDuplicateFromString
    {

        public static string RemoveDuplicate(string givenString)
        {
            if (string.IsNullOrWhiteSpace(givenString))
                return string.Empty;

            var arraystring = givenString.ToLower().ToCharArray();
            var charCount = new Dictionary<char, int>();
            var result = new StringBuilder();

            for (int i = 0; i < arraystring.Length; i++)
            {
                if (!charCount.ContainsKey(arraystring[i]))
                {
                    charCount.Add(arraystring[i], 1);
                    result.Append(arraystring[i]);
                }
            }

            return result.ToString();
        }

    }
}
