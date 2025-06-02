using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forCodinginterviews._2025_interview_prep.Questions.Easy
{
    public static   class ReverseEachWord
    {
        public static string ReverseEachWordOfString(string givenString)
        {
             // input:- Welcome to Csharp corner ; output:- emocleW ot prahsC renroc
             
            if (string.IsNullOrEmpty(givenString))
            {
                return "";
            }
           var words = givenString.Split(' ');
            string reversedWordOfSentence = "";
            for (int i = 0; i < words.Length ; i++)
            {
                var reverseWord =  new string(words[i].Reverse().ToArray());

                reversedWordOfSentence = reversedWordOfSentence + " " + reverseWord;
            }

            return reversedWordOfSentence;

        }
    }
}
