using System;
using System.Text;

//substring
class Program
{
    static void Main()
    {
        removeDuplicateCharacter();
    }

    //suBstring
    static void Substring()
    {
        // Step 1: Get input from the user
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        // Step 2: Find and print all substrings
        Console.WriteLine("All substrings:");
        for (int i = 0; i < input.Length; i++)
        {
            for (int j = i + 1; j <= input.Length; j++)
            {


                var startrange = i;
                var endrange = j - 1;
                var Outstring = input.Substring(i, j - i);
                Console.WriteLine(input.Substring(i, j - i));
            }
        }
    }

    //reverse array
    public static void  reverseArray()
    {
        var inputSt = "test";
        
        char [] charray = inputSt.ToCharArray();

        Array.Reverse(charray);

        string newArray = new string(charray);
    }
    
    //character occurance in string 
    public static void characterOccurance()
    {
        var inputString = "abcedeab";

        Dictionary<char, int> charatercounter = new Dictionary<char, int>();

        foreach (char c in inputString)
        {
            if (charatercounter.ContainsKey(c))
               
                charatercounter[c]++;
            else

            charatercounter[c]= 1;
        }
        foreach (var charandcount in charatercounter)
        {
            Console.WriteLine("word"+ charandcount.Key + ",count" + charandcount.Value);
        }
    }

    //reverse the given words
    public static void reversegivenword()
    {
        string word = "hello test";
        
        string [] newwords = word.Split(' ');


        for (int i = 0; i < newwords.Length; i++)
        {
            char[] charArray = newwords[i].ToCharArray();

            Array.Reverse(charArray);

            newwords[i] = new string(charArray);
        }

        string reversedWordsString = string.Join(" ", newwords);
    }

    //remove duplicate character from string 

    //remove duplicate Character
    public static void removeDuplicateCharacter()
    {
        var inputString = "aabbccdddee";

        HashSet<char> uniqueChar = new HashSet<char>();

        StringBuilder result = new StringBuilder();

        foreach (char c in inputString)
        { 
            if(uniqueChar.Contains(c))
            {
                result.Append(c);
            }
        }
        Console.WriteLine("string with duplicate removed" + result.ToString());
    }
}
