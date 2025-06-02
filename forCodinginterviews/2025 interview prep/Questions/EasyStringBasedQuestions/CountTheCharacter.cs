using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forCodinginterviews._2025_interview_prep.Questions.Easy
{
    public static class CountTheCharacter
    {
        public static string CountCharacters(string word)
        {
            if (string.IsNullOrWhiteSpace(word))
                return string.Empty;

            var characterCount = new Dictionary<char, int>();

            foreach (char c in word.ToLower()) 
            {
                if (characterCount.ContainsKey(c))
                    characterCount[c]++;
                else
                    characterCount[c] = 1;
            }

            var result = characterCount
                .Select(kvp => $"{kvp.Key} {kvp.Value}")
                .ToList();

            return string.Join(", ", result);
        }
    }
}
