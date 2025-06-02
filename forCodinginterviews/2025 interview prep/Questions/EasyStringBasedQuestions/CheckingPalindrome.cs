using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forCodinginterviews._2025_interview_prep.Questions
{
    public  static class CheckingPalindrome
    {
        /* input:- madam ; output:- Palindrome
            
              A palindrome is a string that reads the same forward and backward.
               example: "madam", "racecar", "level", etc.

            * */
        public static  bool CheckPallidromeString(string givenString)
        {
          
            var reversedString =string.Empty;
          
             reversedString = new string(givenString.Reverse().ToArray());


            if (reversedString.Equals(givenString))
            {
                return true;
            }
            else return false;
                
        }
    }
}
