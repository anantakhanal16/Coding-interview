///solve 
/// string based
/// maximum substring for the given string
/// reverse array 
/// character occurance in string 
/// reverse the given words
/// remove duplicate character from string 

//array based
//  Writing a program to reverse an array
/// Finding the occurrence of an integer in the array
/// 

// 1. Palindrome Check:
//    Write a function to determine if a string is a palindrome.

// 2. Factorial Calculation:
//    Implement a function to calculate the factorial of a given number.

// 3. FizzBuzz:
//    Write a program that prints the numbers from 1 to 100. But for multiples of three, print "Fizz" instead of the number, 
//    and for the multiples of five, print "Buzz." For numbers that are multiples of both three and five, print "FizzBuzz."

// 4. Prime Numbers:
//    Write a function to check if a given number is prime.

// 5. Reverse Linked List:
//    Implement a function to reverse a singly linked list.

// 6. Anagram Check:
//    Write a function to check if two strings are anagrams of each other.

// 7. Remove Duplicates:
//    Given a sorted array, remove the duplicate elements in-place such that each element appears only once.

// 8. Binary Search:
//    Implement a binary search algorithm on a sorted array.

// 9. Power of Two:
//    Write a function to determine if a given integer is a power of two.

// 10. Merge Sorted Arrays:
//     Merge two sorted arrays into a new sorted array.

// 11. Stack Implementation:
//     Implement a basic stack class with push and pop operations.

// 12. Queue Implementation:
//     Implement a basic queue class with enqueue and dequeue operations.

// 13. Matrix Transpose:
//     Write a function to transpose a given matrix.

// 14. Substring Search:
//     Implement a function to find the first occurrence of a substring in a given string.

// 15. Counting Characters:
//     Write a program to count the occurrence of each character in a string.

// 16. Check for Balanced Parentheses:
//     Write a function to check if a given expression has balanced parentheses.

// 17. Linked List Cycle Detection:
//     Write a function to detect a cycle in a linked list.

// 18. Randomized Array Shuffle:
//     Implement an algorithm to shuffle an array randomly.

// 19. XML Parsing:
//     Write code to parse an XML file and extract relevant information.

// 20. Dependency Injection:
//     Explain the concept of dependency injection in C# and provide a simple example.


namespace forCodinginterviews
{
    public static class ForPratice
    {
        //prime numbers
        public static bool primeNumbers(int num)
        {


            if (num <= 1)
            {
                return false;
            }
            var condition = Math.Sqrt(num);

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)

                    return false;

            }
            return true;

        }

        ///reverse string 
        ///

        //public static string ReverseString(string inputString)
        //{
        //    string reversedString= "";


        //    char[] charray = inputString.ToCharArray();

        //    Array.Reverse(charray);

        //    string newArray = new string(charray);

        //    return newArray;

        //}

        ///
        public static string reverseString(string inputString)
        {
            char[] charArray = inputString.ToCharArray();

            Array.Reverse(charArray);

            string newString = new string(charArray);

            return newString;

        }
        
        //reverse number;
        public static int reverseNumber(int inputNumber)
        {
            char[] charArray = inputNumber.ToString().ToCharArray();

            Array.Reverse(charArray);

            string reversedString = new string(charArray);

            int reversedNumber = Convert.ToInt32(reversedString);

            return reversedNumber;

        }

        //string Length
        public static int stringLength(string inputString)
        {
            int length = inputString.Length;


            return length;
        }
        //even or odd
        public static bool evenOdd(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else 
            {
               return  false;
            }

        }

        //factorial of the number

        public static long factorialOfgivenNumber(int number)
        {

            if (number < 0)
            {
                throw new ArgumentException("Factorial is not defined for negative numbers.");
            }

            long result = 1;

            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            return result ;
        }

        ///armstrong number
        public static bool isArmstrongNumber(int number)
        {
            string Number = number.ToString();
            
            char [] chars = number.ToString().ToCharArray();
            
            var  totalcount = chars.Length;

            double result = 0;

            foreach (char c in chars) 
            {
               double  charpow = Math.Pow(c, totalcount);
                result += charpow;
            }

            if (Number.Equals(result.ToString()))
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        //palindrome number
        public static bool isPalindromeNumber(int number)
        {
           string originalString = number.ToString();

            char[] chars = number.ToString().ToCharArray();

            Array.Reverse(chars);

            string reverseString = new string(chars);

            if (originalString.Equals(reverseString))
            {
                return true;
            }
            else 
            {
                return false;
            }
            
        }

        ///fibonacii number
        public static int[] fibonacciSeries(int noOfterms)
        {
            int noofterms = noOfterms;

            int [] fibonacciArray = new int[noofterms];

            for (int i = 0; i < noofterms; i++)
            {
                fibonacciArray[i] = GetFinonacii(i);
            }
            
            static int GetFinonacii( int n)
            {
                if (n <= 1)
                {
                    return n;
                }
                else 
                {
                    return GetFinonacii(n - 1) + GetFinonacii(n - 2);
                }
            }

            return fibonacciArray;

        }
    }
}
