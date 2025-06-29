using System;
using forCodinginterviews._2025_interview_prep.Questions.ArrayBasedEasyQuestions;
using forCodinginterviews._2025_interview_prep.Questions.Easy;
using forCodinginterviews._2025_interview_prep.Questions.EasyStringBasedQuestions;


class Program
{
    public static void Main(string[] args)
    {
        
        int[] arr = { 1, 2, 3,4,5 };

        var result = LeftCircularRoatation.PerformArrayRotation(arr);
        Console.WriteLine($"Input String: {result}");

    }
}


