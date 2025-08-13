using System;

class Program 
{
   static void Main()
    {
        Console.Write("Enter the student's score: ");
        int score = Convert.ToInt32(Console.ReadLine());

        string result = (score >= 50) ? "Passed" : "Failed";

        Console.WriteLine($"The student has: {result}");
    }
}