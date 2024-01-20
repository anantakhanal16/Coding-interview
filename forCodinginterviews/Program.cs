using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string inputString = Console.ReadLine();

        string longestWord = FindLongestWord(inputString);

        Console.WriteLine("The longest word is: " + longestWord);
    }

    static string FindLongestWord(string input)
    {
        string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        string longestWord = "";

        foreach (var word in words)
        {
            if (word.Length > longestWord.Length)
            {
                longestWord = word;
            }
        }

        return longestWord;
    }
}
