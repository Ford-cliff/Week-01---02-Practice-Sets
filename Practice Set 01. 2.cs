using System;

class Program
{
    public static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine()); 

        if (number > 0)
        {
            Console.WriteLine($"The number {number} is positive.");
        }
        else
        {
            Console.WriteLine($"The number {number} is negative.");
        }
    }
}
