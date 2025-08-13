using System;

public class EvenNumberChecker
{
    public static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine()); 

        if (number % 2 == 0) 
        {
            Console.WriteLine($"The number {number} is even."); 
        }
    }
}
